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
    public partial class MyScheduleTabControl : UserControl
    {
        public MyScheduleTabControl()
        {
            InitializeComponent();

            SetupScheduleDataGridView();
        }

        private void SetupScheduleDataGridView()
        {
            dataGridViewMyMeetings.ReadOnly = true;
            dataGridViewMyMeetings.AllowUserToAddRows = false;
            dataGridViewMyMeetings.AllowUserToDeleteRows = false;
            dataGridViewMyMeetings.RowHeadersVisible = false;
            dataGridViewMyMeetings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMyMeetings.Columns.Clear();

            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Title" },
                new DataGridViewTextBoxColumn() { Name = "Date" },
                new DataGridViewTextBoxColumn() { Name = "From" },
                new DataGridViewTextBoxColumn() { Name = "To" },
                new DataGridViewTextBoxColumn() { Name = "MeetingRoom" }
            };

            dataGridViewMyMeetings.Columns.AddRange(columns);
        }
    }
}
