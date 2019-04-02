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
    public partial class MeetingManageTabControl : UserControl
    {
        // Information from Main Form
        private MeetingManagementEntities context;
        private User loggedinUser;

        // Display Meetings List
        List<Meeting> displayMeetings;

        // Selected Meeting detail
        Meeting selectedMeeting;

        public MeetingManageTabControl()
        {
            InitializeComponent();

            // Get context and user info from MainForm
            context = MainForm.context;
            loggedinUser = MainForm.loggedinUser;

            SetupScheduleDataGridView();

            DefaultFields();

            BindEventsForControllers();

            LoadMeetings();

            // Default select first row
            if (dataGridViewMyMeetings.Rows.Count > 0)
            {
                dataGridViewMyMeetings.Rows[0].Selected = true;
                selectedMeeting = displayMeetings[0];
                DisplayMeetingDetail();
            }
        }

        private void SetupScheduleDataGridView()
        {
            dataGridViewMyMeetings.ReadOnly = true;
            dataGridViewMyMeetings.AllowUserToAddRows = false;
            dataGridViewMyMeetings.AllowUserToDeleteRows = false;
            dataGridViewMyMeetings.AllowUserToOrderColumns = false;
            dataGridViewMyMeetings.RowHeadersVisible = false;
            dataGridViewMyMeetings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMyMeetings.Columns.Clear();

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
            textBoxTextSearch.Text = "";
            checkBoxShowTodayMeeting.Checked = true;
            checkBoxCreatedByMe.Checked = false;
            checkBoxShowPastMeeting.Checked = false;
        }

        private void BindEventsForControllers()
        {
            buttonFilterMeetings.Click += (s, e) =>
            {
                LoadMeetings();

                // Default select first row
                if (dataGridViewMyMeetings.Rows.Count > 0)
                {
                    dataGridViewMyMeetings.Rows[0].Selected = true;
                    selectedMeeting = displayMeetings[0];
                    DisplayMeetingDetail();
                }
            };

            dataGridViewMyMeetings.CellClick += DataGridViewCellClick;
        }

        private void LoadMeetings()
        {
            dataGridViewMyMeetings.Rows.Clear();

            context.Users.Load();

            // Get search term
            string searchTerm = textBoxTextSearch.Text;

            // Get meetings of this user
            var invitedMeetings = from meeting in context.Meetings
                              where meeting.Users.Any(user => user.Id == loggedinUser.Id)
                                    || meeting.Groups.Any(g => g.Users.Any(user => user.Id == loggedinUser.Id))
                              where meeting.Title.Contains(searchTerm) || meeting.Description.Contains(searchTerm) || meeting.Notes.Contains(searchTerm)
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

            for (int i = 0; i < dataGridViewMyMeetings.Rows.Count; i++)
            {
                if (i == e.RowIndex)
                {
                    dataGridViewMyMeetings.Rows[i].Selected = true;
                    selectedMeeting = displayMeetings.Where(m => m.Id == int.Parse(dataGridViewMyMeetings.Rows[i].Cells[0].Value.ToString())).ToList()[0];
                } 
                else dataGridViewMyMeetings.Rows[i].Selected = false;
            }

            DisplayMeetingDetail();
        }

        private void DisplayMeetingDetail()
        {
            if (selectedMeeting != null)
            {
                labelDisplayMeetingTitle.Text = selectedMeeting.Title;
                labelDisplayDescription.Text = selectedMeeting.Description;
                labelDisplayFrom.Text = selectedMeeting.From.ToLongDateString();
                labelDisplayTo.Text = selectedMeeting.To.ToLongDateString();
                labelDisplayMeetingRoom.Text = selectedMeeting.MeetingRoom.RoomName;
                labelDisplayLocation.Text = selectedMeeting.MeetingRoom.Location;
                labelDisplayNotes.Text = selectedMeeting.Notes;
            }
        }
    }
}
