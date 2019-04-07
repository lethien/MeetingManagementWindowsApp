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

            // Setup Meeting Room view
            SetupDataGridViews();
            DefaultFields();
            BindEventsForControllers();
            LoadMeetingRooms();

            // Default select first row
            if (dataGridViewMeetingRooms.Rows.Count > 0)
            {
                dataGridViewMeetingRooms.Rows[0].Selected = true;
                selectedRoom = displayRooms[0];                
            }
            DisplayMeetingRoomDetail();
        }

        private void SetupDataGridViews()
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
            // If Not Admin - Disable update fields
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

                buttonAddMeetingRoom.Visible = false;
                buttonUpdateRoom.Visible = false;
                buttonCancelUpdateRoom.Visible = false;
            }
        }

        private void BindEventsForControllers()
        {
            // Event click on Cell/Row of datagridview
            dataGridViewMeetingRooms.CellClick += DataGridViewCellClick;

            // Click on + button to show add form for new meeting room
            buttonAddMeetingRoom.Click += ChangeToAddMeetingRoomForm;

            // Click on add/update form buttons
            buttonUpdateRoom.Click += UpdateMeetingRoom;
            buttonCancelUpdateRoom.Click += CancelUpdateMeetingRoom;
        }

        private void LoadMeetingRooms()
        {
            // Reset display data
            dataGridViewMeetingRooms.Rows.Clear();
            selectedRoom = null;
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

            // Hilight the selected row
            for (int i = 0; i < dataGridViewMeetingRooms.Rows.Count; i++)
            {
                if (i == e.RowIndex)
                {
                    dataGridViewMeetingRooms.Rows[i].Selected = true;
                    selectedRoom = displayRooms.Where(r => r.Id == int.Parse(dataGridViewMeetingRooms.Rows[i].Cells[0].Value.ToString())).ToList()[0];
                }
                else dataGridViewMeetingRooms.Rows[i].Selected = false;
            }

            // Display the selected meeting room
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
                buttonUpdateRoom.Enabled = true;
            }
            else
            {
                // No meeting room selected, clear and disable form
                textBoxRoomName.Text = "";
                textBoxRoomLocation.Text = "";
                textBoxNumberOfSeats.Text = "";
                radioButtonHasPhoneYes.Checked = false;
                radioButtonHasPhoneNo.Checked = false;
                radioButtonHasProjectorYes.Checked = false;
                radioButtonHasProjectorNo.Checked = false;
                radioButtonDisabledYes.Checked = false;
                radioButtonDisabledNo.Checked = false;
                buttonUpdateRoom.Enabled = false;
                buttonCancelUpdateRoom.Enabled = false;
            }
        }

        private void ChangeToAddMeetingRoomForm(object sender, EventArgs e)
        {
            // Initialize a new room
            MeetingRoom newRoom = new MeetingRoom();
            newRoom.RoomName = "";
            newRoom.Location = "";
            newRoom.HasPhone = false;
            newRoom.HasProjector = false;
            newRoom.NumberOfSeats = 0;
            newRoom.Disabled = false;

            // Change labels
            labelMeetingRoomDetail.Text = "Add Meeting Room Detail";
            buttonUpdateRoom.Text = "Add Meeting Room";

            // Un-select all rows
            for (int i = 0; i < dataGridViewMeetingRooms.Rows.Count; i++)
            {
                dataGridViewMeetingRooms.Rows[i].Selected = false;
            }

            // Enable Add Form
            selectedRoom = newRoom;
            DisplayMeetingRoomDetail();

            // Shift focus to form
            textBoxRoomName.Focus();
        }

        private void UpdateMeetingRoom(object sender, EventArgs e)
        {
            // Get input from fields
            string roomName = textBoxRoomName.Text.Trim();
            string location = textBoxRoomLocation.Text.Trim();
            string numberOfSeats = textBoxNumberOfSeats.Text.Trim();

            // Validate fields
            if (roomName == "")
            {
                MessageBox.Show("Room Name is required");
                return;
            }
            else if (location == "")
            {
                MessageBox.Show("Location is required");
                return;
            }
            else if (numberOfSeats == "" || !int.TryParse(numberOfSeats, out int result) || result < 1)
            {
                MessageBox.Show("Number of Seats is not valid");
                return;
            }
            

            // Get room to update
            context.MeetingRooms.Load();
            MeetingRoom roomToUpdate;
            if (selectedRoom.Id > 0)
            {
                // It's an existed room to update
                // Check if changed room name has been taken
                if (context.MeetingRooms.Any(r => r.RoomName == roomName && r.Id != selectedRoom.Id))
                {
                    MessageBox.Show("Meeting Room name " + roomName + " is already existed. Pleas choose another name.");
                    return;
                }

                roomToUpdate = context.MeetingRooms.Single(r => r.Id == selectedRoom.Id);
            }
            else
            {
                // It's a new room to add
                // Check if room name has been taken
                if (context.MeetingRooms.Any(r => r.RoomName == roomName))
                {
                    MessageBox.Show("Meeting Room name " + roomName + " is already existed. Pleas choose another name.");
                    return;
                }

                // Create new meeting room
                roomToUpdate = new MeetingRoom();
                context.MeetingRooms.Add(roomToUpdate);
            }

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
                MainForm.SaveChangesToDatabase();
                LoadMeetingRooms();

                // Revert back to update form
                labelMeetingRoomDetail.Text = "Meeting Room Detail";
                buttonUpdateRoom.Text = "Update Meeting Room";
                selectedRoom = context.MeetingRooms.Single(r => r.Id == roomToUpdate.Id);

                // Default select the updated room
                for (int i = 0; i < dataGridViewMeetingRooms.Rows.Count; i++)
                {
                    if (selectedRoom.Id.ToString() == dataGridViewMeetingRooms.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridViewMeetingRooms.Rows[i].Selected = true;
                        selectedRoom = displayRooms[i];                        
                    }
                    else
                    {
                        dataGridViewMeetingRooms.Rows[i].Selected = false;
                    }
                    DisplayMeetingRoomDetail();
                }
            }
        }

        private void CancelUpdateMeetingRoom(object sender, EventArgs e)
        {
            if (selectedRoom.Id > 0) // Currently update an existed room
            {
                // Re-display meeting room info
                DisplayMeetingRoomDetail();
            }
            else // Currently add a new meeting room
            {
                // Default select first row
                if (dataGridViewMeetingRooms.Rows.Count > 0)
                {
                    dataGridViewMeetingRooms.Rows[0].Selected = true;
                    selectedRoom = displayRooms[0];
                }
                DisplayMeetingRoomDetail();
            }
        }
    }
}
