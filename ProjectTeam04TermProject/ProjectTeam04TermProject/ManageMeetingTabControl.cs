using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MeetingManagementClassLibrary;

namespace ProjectTeam04TermProject
{
    public partial class ManageMeetingTabControl : UserControl
    {
        // Information from Main Form
        private MeetingManagementEntities context;
        private User loggedinUser;

        // Display Meetings List
        List<Meeting> displayMeetings;

        // Selected Meeting detail
        Meeting selectedMeeting;

        public ManageMeetingTabControl()
        {
            InitializeComponent();

            // Get context and user info from MainForm
            context = MainForm.context;
            loggedinUser = MainForm.loggedinUser;

            // Setup Meeting view
            SetupScheduleDataGridView();
            DefaultFields();
            BindEventsForControllers();
            LoadMeetings();

            // Default select first row
            if (dataGridViewMyMeetings.Rows.Count > 0)
            {
                dataGridViewMyMeetings.Rows[0].Selected = true;
                selectedMeeting = displayMeetings[0];                
            }
            DisplayMeetingDetail();
        }

        private void SetupScheduleDataGridView()
        {
            // Disable edit on datagridview
            dataGridViewMyMeetings.ReadOnly = true;
            dataGridViewMyMeetings.AllowUserToAddRows = false;
            dataGridViewMyMeetings.AllowUserToDeleteRows = false;
            dataGridViewMyMeetings.AllowUserToOrderColumns = false;
            dataGridViewMyMeetings.RowHeadersVisible = false;
            dataGridViewMyMeetings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMyMeetings.Columns.Clear();

            // Add columns
            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[] {
                new DataGridViewTextBoxColumn() { Name = "ID", Visible = false },
                new DataGridViewTextBoxColumn() { Name = "Title" },
                new DataGridViewTextBoxColumn() { Name = "From" },
                new DataGridViewTextBoxColumn() { Name = "To" },
                new DataGridViewTextBoxColumn() { Name = "MeetingRoom" }
            };
            dataGridViewMyMeetings.Columns.AddRange(columns);
        }

        private void DefaultFields()
        {
            // Default for search form
            textBoxTextSearch.Text = "";
            checkBoxShowTodayMeeting.Checked = true;
            checkBoxCreatedByMe.Checked = false;
            checkBoxShowPastMeeting.Checked = false;

            // If normal user, disable form textboxex and hide form buttons
            if (loggedinUser.Role == Constants.USER_ROLE_USER)
            {
                textBoxMeetingTitle.ReadOnly = true;
                textBoxMeetingDescription.ReadOnly = true;
                textBoxMeetingNotes.ReadOnly = true;
                buttonManageParticipants.Visible = false;
                buttonCancelMeeting.Visible = false;
                buttonUpdateMeetingInfo.Visible = false;
                buttonResetMeetingForm.Visible = false;
                buttonShowAddMeeting.Visible = false;
            }
        }

        private void BindEventsForControllers()
        {
            // Event click on Cell/Row of datagridview
            dataGridViewMyMeetings.CellClick += DataGridViewCellClick;

            // Click on Filter button
            buttonFilterMeetings.Click += (s, e) =>
            {
                LoadMeetings();

                // Default select first row
                if (dataGridViewMyMeetings.Rows.Count > 0)
                {
                    dataGridViewMyMeetings.Rows[0].Selected = true;
                    selectedMeeting = displayMeetings[0];                    
                }
                DisplayMeetingDetail();
            };

            // Click on Update Meeting buttons
            buttonCancelMeeting.Click += CancelMeeting;
            buttonUpdateMeetingInfo.Click += UpdateMeetingInfo;
            buttonResetMeetingForm.Click += (s, e) => DisplayMeetingDetail();

            // Click on Add Meeting button
            buttonShowAddMeeting.Click += DisplayAddMeetingForm;

            // Click on Manage Participants button
            buttonManageParticipants.Click += DisplayManageParticipantsForm;
        }

        private void LoadMeetings()
        {
            // Reset display data
            dataGridViewMyMeetings.Rows.Clear();
            selectedMeeting = null;
            context.Users.Load();

            // Get search term
            string searchTerm = textBoxTextSearch.Text;

            // Get meetings of this user
            var invitedMeetings = from meeting in context.Meetings
                              where meeting.Users.Any(user => user.Id == loggedinUser.Id)
                                    || meeting.Groups.Any(g => g.Users.Any(user => user.Id == loggedinUser.Id))
                                    || meeting.CreatedBy == loggedinUser.Id
                              where meeting.Title.Contains(searchTerm) || meeting.Description.Contains(searchTerm) || meeting.Notes.Contains(searchTerm)
                              where meeting.Canceled == false
                              orderby meeting.From ascending
                              select meeting;
            displayMeetings = invitedMeetings.ToList();

            // Filter by past date checkbox
            if (!checkBoxShowPastMeeting.Checked)
            {
                displayMeetings = displayMeetings.Where(meeting => meeting.From >= DateTime.Today).ToList();
            }

            // Filter by today only checkbox
            if (checkBoxShowTodayMeeting.Checked)
            {
                displayMeetings = displayMeetings.Where(meeting => meeting.From.Date == DateTime.Today.Date).ToList();
            }

            // Filter by created by me checkbox
            if (checkBoxCreatedByMe.Checked)
            {
                displayMeetings = displayMeetings.Where(meeting => meeting.User.Id == loggedinUser.Id).ToList();
            }

            // Add meetings to datagrid
            displayMeetings.ForEach(meeting => dataGridViewMyMeetings.Rows.Add(
                    meeting.Id,
                    meeting.Title,
                    meeting.From,
                    meeting.To,
                    meeting.MeetingRoom.RoomName
                ));            
        }

        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // When user click on column header

            // Hilight the selected row
            for (int i = 0; i < dataGridViewMyMeetings.Rows.Count; i++)
            {
                if (i == e.RowIndex)
                {
                    dataGridViewMyMeetings.Rows[i].Selected = true;
                    selectedMeeting = displayMeetings.Where(m => m.Id == int.Parse(dataGridViewMyMeetings.Rows[i].Cells[0].Value.ToString())).ToList()[0];
                } 
                else dataGridViewMyMeetings.Rows[i].Selected = false;
            }

            // Display selected meeting
            DisplayMeetingDetail();
        }

        private void DisplayMeetingDetail()
        {
            if (selectedMeeting != null) // There is a meeting selected
            {
                // Display meeting info
                textBoxMeetingTitle.Text = selectedMeeting.Title;
                textBoxMeetingDescription.Text = selectedMeeting.Description;
                labelDisplayFrom.Text = selectedMeeting.From.ToString();
                labelDisplayTo.Text = selectedMeeting.To.ToString();
                labelDisplayMeetingRoom.Text = selectedMeeting.MeetingRoom.RoomName;
                labelDisplayLocation.Text = selectedMeeting.MeetingRoom.Location;
                textBoxMeetingNotes.Text = selectedMeeting.Notes;
                string displayParticipants = "(Users: "+ (selectedMeeting.Users.Count + 1) +"; Groups: "+ selectedMeeting.Groups.Count +")\n";
                displayParticipants += selectedMeeting.User.Username + " (Initiator)";
                selectedMeeting.Users.ToList().ForEach(u => displayParticipants += "; " + u.Username);
                selectedMeeting.Groups.ToList().ForEach(g => displayParticipants += "; " + g.GroupName);
                labelDisplayMeetingParticipants.Text = displayParticipants;

                // If selected meeting is created by current user and is a future meeting, enable meeting form
                if (selectedMeeting.CreatedBy == loggedinUser.Id && selectedMeeting.From > DateTime.Today)
                {
                    // Enable form textboxes
                    textBoxMeetingTitle.ReadOnly = false;
                    textBoxMeetingDescription.ReadOnly = false;
                    textBoxMeetingNotes.ReadOnly = false;

                    // Enable meeting form buttons
                    buttonManageParticipants.Enabled = true;
                    buttonCancelMeeting.Enabled = true;
                    buttonUpdateMeetingInfo.Enabled = true;
                    buttonResetMeetingForm.Enabled = true;
                }
                else
                {
                    // Disable form textboxes
                    textBoxMeetingTitle.ReadOnly = true;
                    textBoxMeetingDescription.ReadOnly = true;
                    textBoxMeetingNotes.ReadOnly = true;

                    // Disable meeting form buttons
                    buttonManageParticipants.Enabled = false;
                    buttonCancelMeeting.Enabled = false;
                    buttonUpdateMeetingInfo.Enabled = false;
                    buttonResetMeetingForm.Enabled = false;
                }
            }
            else // No meeting selected
            {
                // Clear meeting info
                textBoxMeetingTitle.Text = "";
                textBoxMeetingDescription.Text = "";
                labelDisplayFrom.Text = "";
                labelDisplayTo.Text = "";
                labelDisplayMeetingRoom.Text = "";
                labelDisplayLocation.Text = "";
                textBoxMeetingNotes.Text = "";
                labelDisplayMeetingParticipants.Text = "";

                // Disable form textboxes
                textBoxMeetingTitle.ReadOnly = true;
                textBoxMeetingDescription.ReadOnly = true;
                textBoxMeetingNotes.ReadOnly = true;

                // Disable meeting form buttons
                buttonManageParticipants.Enabled = false;
                buttonCancelMeeting.Enabled = false;
                buttonUpdateMeetingInfo.Enabled = false;
                buttonResetMeetingForm.Enabled = false;
            }
        }

        private void CancelMeeting(object sender, EventArgs e)
        {
            // Get cancel meeting
            Meeting meetingToCancel = context.Meetings.Single(m => m.Id == selectedMeeting.Id);

            // Set canceled to true
            meetingToCancel.Canceled = true;

            // Update database
            MainForm.SaveChangesToDatabase();

            // Reload datagridview
            LoadMeetings();

            // Default select first row
            if (dataGridViewMyMeetings.Rows.Count > 0)
            {
                dataGridViewMyMeetings.Rows[0].Selected = true;
                selectedMeeting = displayMeetings[0];
            }
            DisplayMeetingDetail();
        }

        private void UpdateMeetingInfo(object sender, EventArgs e)
        {
            // Get input from fields
            string meetingTitle = textBoxMeetingTitle.Text.Trim();
            string meetingDescription = textBoxMeetingDescription.Text.Trim();
            string meetingNotes = textBoxMeetingNotes.Text.Trim();

            // Validate meeting title
            if (meetingTitle == "")
            {
                MessageBox.Show("Meeting Title is required");
                return;
            }

            // Get meeting to update
            Meeting meetingToUpdate = context.Meetings.Single(m => m.Id == selectedMeeting.Id);

            // Update meeting info
            meetingToUpdate.Title = meetingTitle;
            meetingToUpdate.Description = meetingDescription;
            meetingToUpdate.Notes = meetingNotes;

            // Update database
            MainForm.SaveChangesToDatabase();

            // Reload datagridview
            LoadMeetings();

            // Default select updated row
            for (int i = 0; i < dataGridViewMyMeetings.Rows.Count; i++)
            {
                if (meetingToUpdate.Id.ToString() == dataGridViewMyMeetings.Rows[i].Cells[0].Value.ToString())
                {
                    dataGridViewMyMeetings.Rows[i].Selected = true;
                    selectedMeeting = displayMeetings[i];
                }
                else
                {
                    dataGridViewMyMeetings.Rows[i].Selected = false;
                }
                DisplayMeetingDetail();
            }
        }

        private void UpdateMeetingParticipants()
        {            
            // Update database
            MainForm.SaveChangesToDatabase();

            // Reload updated meeting
            DisplayMeetingDetail();
        }

        private void DisplayAddMeetingForm(object sender, EventArgs e)
        {
            // Show Add Meeting Dialog
            AddMeetingForm addForm = new AddMeetingForm();
            DialogResult result = addForm.ShowDialog(this.Parent);

            // Check Dialog result
            if (result == DialogResult.OK)
            {
                // Get the added meeting
                Meeting meetingAdded = addForm.NewMeeting;

                // Make sure added meeting is shown
                textBoxTextSearch.Text = "";
                checkBoxShowTodayMeeting.Checked = false;

                // Reload datagridview
                LoadMeetings();

                // Default select the added meeting
                for (int i = 0; i < dataGridViewMyMeetings.Rows.Count; i++)
                {
                    if (meetingAdded.Id.ToString() == dataGridViewMyMeetings.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridViewMyMeetings.Rows[i].Selected = true;
                        selectedMeeting = displayMeetings[i];
                    }
                    else
                    {
                        dataGridViewMyMeetings.Rows[i].Selected = false;
                    }
                    DisplayMeetingDetail();
                }

                // Dispose add form
                addForm.Close();
            }
        }

        private void DisplayManageParticipantsForm(object sender, EventArgs e)
        {
            ManageMeetingParticipantsForm participantsForm = new ManageMeetingParticipantsForm(selectedMeeting);
            DialogResult result = participantsForm.ShowDialog(this.Parent);

            if (result == DialogResult.OK)
            {
                // Update meeting participants
                UpdateMeetingParticipants();

                // Dispose participants form
                participantsForm.Close();
            }
        }
    }
}
