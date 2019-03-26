using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam04TermProject
{
    public partial class ManageMeetingRoomTabControl : UserControl
    {
        public ManageMeetingRoomTabControl()
        {
            InitializeComponent();

            SetupDataGridViews();
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
                new DataGridViewTextBoxColumn() { Name = "Date" },
                new DataGridViewTextBoxColumn() { Name = "From" },
                new DataGridViewTextBoxColumn() { Name = "To" }
            };

            dataGridViewUpcomingMeetings.Columns.AddRange(upcomingMeetingColumns);
        }
    }
}
