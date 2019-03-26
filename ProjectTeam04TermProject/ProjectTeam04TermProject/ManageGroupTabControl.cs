using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeetingManagementClassLibrary;

namespace ProjectTeam04TermProject
{
    public partial class ManageGroupTabControl : UserControl
    {
        public ManageGroupTabControl()
        {
            InitializeComponent();

            SetupGroupDataGridView();

            BindEventsForControls();
        }

        private void SetupGroupDataGridView()
        {
            dataGridViewGroups.AllowUserToAddRows = true;
            dataGridViewGroups.AllowUserToDeleteRows = false;            
            dataGridViewGroups.RowHeadersVisible = false;
            dataGridViewGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGroups.Columns.Clear();

            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[] {
                new DataGridViewTextBoxColumn() { Name = "Id" },
                new DataGridViewTextBoxColumn() { Name = "Group Name" },
                new DataGridViewTextBoxColumn() { Name = "Disabled" }
            };

            dataGridViewGroups.Columns.AddRange(columns);
        }

        private void LoadDataForUserListBoxes()
        {
            // Load members of the selected group
            List<User> members = new List<User>();
            // Load members to listbox
            listBoxGroupMembers.Items.Clear();
            listBoxGroupMembers.Items.AddRange(members.ToArray());

            // Load users that is not in the selected group
            List<User> others = new List<User>();
            // Load others to listbox
            listBoxOtherUsers.Items.Clear();
            listBoxOtherUsers.Items.AddRange(others.ToArray());
        }

        private void BindEventsForControls()
        {

        }
    }
}
