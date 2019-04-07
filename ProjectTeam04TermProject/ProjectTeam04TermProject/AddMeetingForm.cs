using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MeetingManagementClassLibrary;

namespace ProjectTeam04TermProject
{
    public partial class AddMeetingForm : Form
    {
        // Information from Main Form
        private MeetingManagementEntities context;
        private User loggedinUser;

        // Display Meeting Rooms
        List<MeetingRoom> displayMeetingRooms;
        
        // Selected Meeting Room detail
        MeetingRoom selectedMeetingRoom;

        // New Meeting to add
        public Meeting NewMeeting { get; private set; }

        public AddMeetingForm()
        {
            InitializeComponent();

            // Get context and user info from MainForm
            context = MainForm.context;
            loggedinUser = MainForm.loggedinUser;

            // Setup Meeting view
            SetupMeetingRoomDataGridView();
            DefaultFields();
            BindEventsForControllers();
            LoadMeetingRooms();

            // Default select first row
            if (dataGridViewMeetingRooms.Rows.Count > 0)
            {
                dataGridViewMeetingRooms.Rows[0].Selected = true;
                selectedMeetingRoom = displayMeetingRooms[0];
            }
            DisplayMeetingRoomDetail();
        }

        private void SetupMeetingRoomDataGridView()
        {
            // Disable edit datagridview
            dataGridViewMeetingRooms.ReadOnly = true;
            dataGridViewMeetingRooms.AllowUserToAddRows = false;
            dataGridViewMeetingRooms.AllowUserToDeleteRows = false;
            dataGridViewMeetingRooms.RowHeadersVisible = false;
            dataGridViewMeetingRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMeetingRooms.Columns.Clear();

            // Add columns
            DataGridViewTextBoxColumn[] meetingRoomColumns = new DataGridViewTextBoxColumn[] {
                new DataGridViewTextBoxColumn() { Name = "ID", Visible = false },
                new DataGridViewTextBoxColumn() { Name = "Room Name" },
                new DataGridViewTextBoxColumn() { Name = "Location" }
            };
            dataGridViewMeetingRooms.Columns.AddRange(meetingRoomColumns);

            // Disable edit datagridview
            dataGridViewUpcomingMeetings.ReadOnly = true;
            dataGridViewUpcomingMeetings.AllowUserToAddRows = false;
            dataGridViewUpcomingMeetings.AllowUserToDeleteRows = false;
            dataGridViewUpcomingMeetings.RowHeadersVisible = false;
            dataGridViewUpcomingMeetings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUpcomingMeetings.Columns.Clear();

            // Add columns
            DataGridViewTextBoxColumn[] upcomingMeetingColumns = new DataGridViewTextBoxColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Title" },
                new DataGridViewTextBoxColumn() { Name = "From" },
                new DataGridViewTextBoxColumn() { Name = "To" }
            };
            dataGridViewUpcomingMeetings.Columns.AddRange(upcomingMeetingColumns);
        }

        private void DefaultFields()
        {
            // Default for date time fields
            DateTime defaultDay = DateTime.Now;
            dateTimePickerDate.Value = defaultDay;
            dateTimePickerFrom.Value = defaultDay.AddMinutes(10);
            dateTimePickerTo.Value = defaultDay.AddHours(1);
        }

        private void BindEventsForControllers()
        {
            // Event click on Cell/Row of datagridview
            dataGridViewMeetingRooms.CellClick += DataGridViewCellClick;

            // Click on Filter button
            buttonFilterMeetingRooms.Click += (s, e) =>
            {
                LoadMeetingRooms();

                // Default select first row
                if (dataGridViewMeetingRooms.Rows.Count > 0)
                {
                    dataGridViewMeetingRooms.Rows[0].Selected = true;
                    selectedMeetingRoom = displayMeetingRooms[0];
                }
                DisplayMeetingRoomDetail();
            };

            // Click on Cancel button
            buttonCancel.Click += (s, e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };

            // Click on Add Meeting button
            buttonAddMeeting.Click += AddMeeting;
        }

        private void LoadMeetingRooms()
        {
            // Reset display data
            dataGridViewMeetingRooms.Rows.Clear();
            selectedMeetingRoom = null;
            context.MeetingRooms.Load();

            // Get all available meeting rooms
            var rooms = from room in context.MeetingRooms
                        where room.Disabled == false
                        select room;
            displayMeetingRooms = rooms.ToList();

            // Filter by room name
            string roomNameFilter = textBoxFilterRoomName.Text.Trim();
            displayMeetingRooms = displayMeetingRooms.Where(r => r.RoomName.Contains(roomNameFilter)).ToList();

            // Filter by room location
            string roomLocationFilter = textBoxFilterRoomLocation.Text.Trim();
            displayMeetingRooms = displayMeetingRooms.Where(r => r.Location.Contains(roomLocationFilter)).ToList();

            // Filter by minimum seat
            int minimumSeats = 0;
            int.TryParse(textBoxMinimumSeats.Text.Trim(), out minimumSeats);
            displayMeetingRooms = displayMeetingRooms.Where(r => r.NumberOfSeats >= minimumSeats).ToList();

            // Filter by has phone checkbox
            if (checkBoxMustHavePhone.Checked)
            {
                displayMeetingRooms = displayMeetingRooms.Where(r => r.HasPhone).ToList();
            }

            // Filter by has projector checkbox
            if (checkBoxMustHaveProjector.Checked)
            {
                displayMeetingRooms = displayMeetingRooms.Where(r => r.HasProjector).ToList();
            }

            // Add rooms to datagridview
            displayMeetingRooms.ForEach(room => dataGridViewMeetingRooms.Rows.Add(
                    room.Id,
                    room.RoomName,
                    room.Location
                ));
        }

        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // When user click on column header

            // Hilight the selected row
            for (int i = 0; i < dataGridViewMeetingRooms.Rows.Count; i++)
            {
                if (i == e.RowIndex)
                {
                    dataGridViewMeetingRooms.Rows[i].Selected = true;
                    selectedMeetingRoom = displayMeetingRooms.Where(r => r.Id == int.Parse(dataGridViewMeetingRooms.Rows[i].Cells[0].Value.ToString())).ToList()[0];
                }
                else dataGridViewMeetingRooms.Rows[i].Selected = false;
            }

            // Display the selected meeting room
            DisplayMeetingRoomDetail();
        }

        private void DisplayMeetingRoomDetail()
        {
            if (selectedMeetingRoom != null)
            {                
                // Show upcomming meetings in selected room
                context.Meetings.Load();
                var meetings = from meeting in context.Meetings
                               where meeting.MeetingRoomId == selectedMeetingRoom.Id
                               where meeting.From >= DateTime.Today
                               orderby meeting.From ascending
                               select meeting;
                dataGridViewUpcomingMeetings.Rows.Clear();
                meetings.ToList().ForEach(m => dataGridViewUpcomingMeetings.Rows.Add(
                        m.Title,
                        m.From,
                        m.To
                    ));                
            }
        }

        private void AddMeeting(object sender, EventArgs e)
        {
            // Initialize a new meeting
            NewMeeting = new Meeting();

            // Validate meeting info
            string meetingTitle = textBoxMeetingTitle.Text.Trim();
            if (meetingTitle == "")
            {
                MessageBox.Show("Meeting Title is required");
                return;
            }
            NewMeeting.Title = meetingTitle;
            NewMeeting.Description = textBoxMeetingDescription.Text.Trim();
            NewMeeting.Notes = textBoxMeetingNotes.Text.Trim();

            // Validate meeting room
            if (selectedMeetingRoom == null)
            {
                MessageBox.Show("A Meeting Room is required");
                return;
            }
            NewMeeting.MeetingRoomId = selectedMeetingRoom.Id;

            // Validate book time
            DateTime date = dateTimePickerDate.Value;
            DateTime from = new DateTime(date.Year, date.Month, date.Day, dateTimePickerFrom.Value.Hour, dateTimePickerFrom.Value.Minute, 0);
            DateTime to = new DateTime(date.Year, date.Month, date.Day, dateTimePickerTo.Value.Hour, dateTimePickerTo.Value.Minute, 0);
            if (from < DateTime.Today)
            {
                MessageBox.Show("Your Meeting can't start in the past. \n(Current time is: " + DateTime.Now.ToString() + ")");
                return;
            }
            else if (from.TimeOfDay > to.TimeOfDay)
            {
                MessageBox.Show("Start Time is after End Time");
                return;
            }
            else if (selectedMeetingRoom.Meetings.Any(m => (m.From <= to && from <= m.To)))
            {
                MessageBox.Show("Your Meeting Timeframe overlaps with another Meeting");
                return;
            }
            NewMeeting.From = from;
            NewMeeting.To = to;

            // Set created by with current user
            NewMeeting.CreatedBy = loggedinUser.Id;

            // Default new meeting with canceled false
            NewMeeting.Canceled = false;

            // Save to database
            context.Meetings.Add(NewMeeting);
            MainForm.SaveChangesToDatabase();

            // Show success message
            MessageBox.Show("New Meeting added. \nYou can now add participants to this meeting clicking Manage Participants button.");

            // Close dialog and return to main form
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
