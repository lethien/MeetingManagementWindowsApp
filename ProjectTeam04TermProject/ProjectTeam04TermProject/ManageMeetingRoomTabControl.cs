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
    public partial class ManageMeetingRoomTabControl : UserControl
    {
        // Information from Main Form
        private MeetingManagementEntities context;
        private User loggedinUser;

        // Display Meeting rooms list
        List<MeetingRoom> displayRooms;

        // Selected Meeting room
        MeetingRoom selectedRoom;

        public ManageMeetingRoomTabControl()
        {
            InitializeComponent();

            // Get context and user info from MainForm
            context = MainForm.context;
            loggedinUser = MainForm.loggedinUser;

            SetupDataGridViews();

            DefaultFields();

            BindEventsForControllers();

            LoadMeetingRooms();

            // Default select first row
            if (dataGridViewMeetingRooms.Rows.Count > 0)
            {
                dataGridViewMeetingRooms.Rows[0].Selected = true;
                selectedRoom = displayRooms[0];
                DisplayMeetingRoomDetail();
            }
        }

        private void SetupDataGridViews()
        {
            dataGridViewMeetingRooms.ReadOnly = true;
            dataGridViewMeetingRooms.AllowUserToAddRows = false;
            dataGridViewMeetingRooms.AllowUserToDeleteRows = false;
            dataGridViewMeetingRooms.RowHeadersVisible = false;
            dataGridViewMeetingRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMeetingRooms.Columns.Clear();

            DataGridViewTextBoxColumn[] meetingRoomColumns = new DataGridViewTextBoxColumn[] {
                new DataGridViewTextBoxColumn() { Name = "ID", Visible = false },
                new DataGridViewTextBoxColumn() { Name = "Room Name" },
                new DataGridViewTextBoxColumn() { Name = "Location" }
            };

            dataGridViewMeetingRooms.Columns.AddRange(meetingRoomColumns);

            dataGridViewUpcomingMeetings.ReadOnly = true;
            dataGridViewUpcomingMeetings.AllowUserToAddRows = false;
            dataGridViewUpcomingMeetings.AllowUserToDeleteRows = false;
            dataGridViewUpcomingMeetings.RowHeadersVisible = false;
            dataGridViewUpcomingMeetings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUpcomingMeetings.Columns.Clear();

            DataGridViewTextBoxColumn[] upcomingMeetingColumns = new DataGridViewTextBoxColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Title" },
                new DataGridViewTextBoxColumn() { Name = "From" },
                new DataGridViewTextBoxColumn() { Name = "To" }
            };

            dataGridViewUpcomingMeetings.Columns.AddRange(upcomingMeetingColumns);
        }

        private void DefaultFields()
        {
            // For Not Admin - Disable update fields
            if (loggedinUser.Role != Constants.USER_ROLE_ADMIN)
            {
                textBoxRoomName.ReadOnly = true;
                textBoxRoomLocation.ReadOnly = true;
                textBoxNumberOfSeats.ReadOnly = true;
                radioButtonHasPhoneYes.Enabled = false;
                radioButtonHasPhoneNo.Enabled = false;
                radioButtonHasProjectorYes.Enabled = false;
                radioButtonHasProjectorNo.Enabled = false;
                radioButtonDisabledYes.Enabled = false;
                radioButtonDisabledNo.Enabled = false;

                buttonUpdateRoom.Visible = false;
            }
            else
            {
                buttonUpdateRoom.Click += UpdateMeetingRoom;
            }
        }

        private void BindEventsForControllers()
        {
            dataGridViewMeetingRooms.CellClick += DataGridViewCellClick;
        }

        private void LoadMeetingRooms()
        {
            dataGridViewMeetingRooms.Rows.Clear();

            context.MeetingRooms.Load();

            // Get all meeting rooms
            var rooms = from room in context.MeetingRooms
                        select room;

            displayRooms = rooms.ToList();

            // Add rooms to datagridview
            displayRooms.ForEach(room => dataGridViewMeetingRooms.Rows.Add(
                    room.Id,
                    room.RoomName,
                    room.Location
                ));
        }

        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // When user click on column header

            for (int i = 0; i < dataGridViewMeetingRooms.Rows.Count; i++)
            {
                if (i == e.RowIndex)
                {
                    dataGridViewMeetingRooms.Rows[i].Selected = true;
                    selectedRoom = displayRooms.Where(r => r.Id == int.Parse(dataGridViewMeetingRooms.Rows[i].Cells[0].Value.ToString())).ToList()[0];
                }
                else dataGridViewMeetingRooms.Rows[i].Selected = false;
            }

            DisplayMeetingRoomDetail();
        }

        private void DisplayMeetingRoomDetail()
        {
            if (selectedRoom != null)
            {
                // Show room info in fields
                textBoxRoomName.Text = selectedRoom.RoomName;
                textBoxRoomLocation.Text = selectedRoom.Location;
                textBoxNumberOfSeats.Text = selectedRoom.NumberOfSeats.ToString();
                radioButtonHasPhoneYes.Checked = selectedRoom.HasPhone;
                radioButtonHasPhoneNo.Checked = !selectedRoom.HasPhone;
                radioButtonHasProjectorYes.Checked = selectedRoom.HasProjector;
                radioButtonHasProjectorNo.Checked = !selectedRoom.HasProjector;
                radioButtonDisabledYes.Checked = selectedRoom.Disabled;
                radioButtonDisabledNo.Checked = !selectedRoom.Disabled;

                // Show upcomming meetings in selected room
                context.Meetings.Load();
                var meetings = from meeting in context.Meetings
                               where meeting.MeetingRoomId == selectedRoom.Id
                               where meeting.From >= DateTime.Today
                               orderby meeting.From ascending
                               select meeting;
                dataGridViewUpcomingMeetings.Rows.Clear();
                meetings.ToList().ForEach(m => dataGridViewUpcomingMeetings.Rows.Add(
                        m.Title,
                        m.From,
                        m.To
                    ));

                // Enable update button
                buttonUpdateRoom.Enabled = true;
            }
            else
            {
                buttonUpdateRoom.Enabled = false;
            }
        }

        private void UpdateMeetingRoom(object sender, EventArgs e)
        {
            string roomName = textBoxRoomName.Text.Trim();
            string location = textBoxRoomLocation.Text.Trim();
            string numberOfSeats = textBoxNumberOfSeats.Text.Trim();

            context.MeetingRooms.Load();
            var roomToUpdate = context.MeetingRooms.Single(r => r.Id == selectedRoom.Id);

            if (roomToUpdate != null)
            {
                // Update room info
                roomToUpdate.RoomName = roomName;
                roomToUpdate.Location = location;
                roomToUpdate.NumberOfSeats = int.Parse(numberOfSeats);
                roomToUpdate.HasPhone = radioButtonHasPhoneYes.Checked;
                roomToUpdate.HasProjector = radioButtonHasProjectorYes.Checked;
                roomToUpdate.Disabled = radioButtonDisabledYes.Checked;

                // Sync database and datagridview
                context.SaveChanges();
                context.MeetingRooms.Load();
                LoadMeetingRooms();

                // Default select the updated room
                for (int i = 0; i < dataGridViewMeetingRooms.Rows.Count; i++)
                {
                    if (selectedRoom.Id.ToString() == dataGridViewMeetingRooms.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridViewMeetingRooms.Rows[i].Selected = true;
                        selectedRoom = displayRooms[i];
                        DisplayMeetingRoomDetail();
                    }
                    else
                    {
                        dataGridViewMeetingRooms.Rows[i].Selected = false;
                    }
                }
            }
        }
    }
}
