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
    public partial class ManageGroupTabControl : UserControl
    {
        // Information from Main Form
        private MeetingManagementEntities context;
        private User loggedinUser;

        // Display Groups List
        List<Group> displayGroups;

        // Selected Group
        Group selectedGroup;

        public ManageGroupTabControl()
        {
            InitializeComponent();

            // Get context and user info from MainForm
            context = MainForm.context;
            loggedinUser = MainForm.loggedinUser;

            SetupGroupDataGridView();

            DefaultFields();

            BindEventsForControls();

            LoadGroups();

            // Default select first row
            if (dataGridViewGroups.Rows.Count > 0)
            {
                dataGridViewGroups.Rows[0].Selected = true;
                selectedGroup = displayGroups[0];
                DisplayGroupDetail();
            }
        }

        private void SetupGroupDataGridView()
        {
            dataGridViewGroups.ReadOnly = true;
            dataGridViewGroups.AllowUserToAddRows = false;
            dataGridViewGroups.AllowUserToDeleteRows = false;            
            dataGridViewGroups.RowHeadersVisible = false;
            dataGridViewGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGroups.Columns.Clear();

            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[] {
                new DataGridViewTextBoxColumn() { Name = "ID", Visible = false },
                new DataGridViewTextBoxColumn() { Name = "Group Name" },
                new DataGridViewTextBoxColumn() { Name = "Members Count" },
                new DataGridViewTextBoxColumn() { Name = "Disabled" }
            };

            dataGridViewGroups.Columns.AddRange(columns);
        }

        private void DefaultFields()
        {
            textBoxSearchGroupName.Text = "";
            checkBoxShowDisabledGroups.Checked = true;
            checkBoxGroupNoMember.Checked = true;
        }

        private void BindEventsForControls()
        {
            dataGridViewGroups.CellClick += DataGridViewCellClick;

            buttonFilterGroups.Click += (s, e) =>
            {
                LoadGroups();

                // Default select first row
                if (dataGridViewGroups.Rows.Count > 0)
                {
                    dataGridViewGroups.Rows[0].Selected = true;
                    selectedGroup = displayGroups[0];
                    DisplayGroupDetail();
                }
            };

            buttonFilterMembers.Click += (s, e) => LoadDataForUserListBoxes();
            buttonFilterOtherUsers.Click += (s, e) => LoadDataForUserListBoxes();

            buttonUpdateGroup.Click += (s, e) => UpdateGroup();

            buttonAddToGroup.Click += (s, e) => AddUserToGroup();
            buttonRemoveFromGroup.Click += (s, e) => RemoveUserFromGroup();
        }

        private void LoadGroups()
        {
            dataGridViewGroups.Rows.Clear();

            context.Groups.Load();

            // Get groups from database
            string searchGroupName = textBoxSearchGroupName.Text;
            var groups = from g in context.Groups
                         where g.GroupName.Contains(searchGroupName)
                         select g;
            displayGroups = groups.ToList();

            // Filter based on disabled group checkbox
            if (!checkBoxShowDisabledGroups.Checked)
            {
                displayGroups = displayGroups.Where(g => !g.Disabled).ToList();
            }

            // Filter based on no member group checkbox
            if (!checkBoxGroupNoMember.Checked)
            {
                displayGroups = displayGroups.Where(g => g.Users.Count > 0).ToList();
            }

            // Add groups to datagridview
            displayGroups.ForEach(g => dataGridViewGroups.Rows.Add(
                    g.Id,
                    g.GroupName,
                    g.Users.Count,
                    g.Disabled
                ));
        }

        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // When user click on column header

            for (int i = 0; i < dataGridViewGroups.Rows.Count; i++)
            {
                if (i == e.RowIndex)
                {
                    dataGridViewGroups.Rows[i].Selected = true;
                    selectedGroup = displayGroups.Where(g => g.Id == int.Parse(dataGridViewGroups.Rows[i].Cells[0].Value.ToString())).ToList()[0];
                }
                else dataGridViewGroups.Rows[i].Selected = false;
            }

            DisplayGroupDetail();
        }

        private void DisplayGroupDetail()
        {
            if (selectedGroup != null)
            {
                // Show info in fields
                if (selectedGroup != null)
                {
                    textBoxGroupName.Text = selectedGroup.GroupName;
                    radioButtonDisabledYes.Checked = selectedGroup.Disabled;
                    radioButtonDisabledNo.Checked = !selectedGroup.Disabled;
                }

                // Load members and non-members listboxes
                LoadDataForUserListBoxes();

                buttonUpdateGroup.Enabled = true;
            }
            else
            {
                buttonUpdateGroup.Enabled = false;
            }
        }

        private void LoadDataForUserListBoxes()
        {
            if (selectedGroup != null)
            {
                // Load members of the selected group
                string memberFilter = textBoxFilterMembers.Text;
                var members = from user in context.Users
                              where user.Groups.Any(g => g.Id == selectedGroup.Id)
                              where user.Username.Contains(memberFilter)
                              orderby user.Username ascending
                              select user;                
                // Load members to listbox
                listBoxGroupMembers.Items.Clear();
                listBoxGroupMembers.Items.AddRange(members.ToArray());

                // Load users that is not in the selected group
                string nonMemberFilter = textBoxFilterUsers.Text;
                var others = from user in context.Users
                             where user.Groups.All(g => g.Id != selectedGroup.Id)
                             where user.Username.Contains(nonMemberFilter)
                             orderby user.Username ascending
                             select user;
                // Load others to listbox
                listBoxOtherUsers.Items.Clear();
                listBoxOtherUsers.Items.AddRange(others.ToArray());
            }            
        }

        private void AddUserToGroup()
        {
            if (selectedGroup != null && listBoxOtherUsers.SelectedItem != null)
            {
                object selectedUser = listBoxOtherUsers.SelectedItem;
                listBoxGroupMembers.Items.Add(selectedUser);
                listBoxOtherUsers.Items.Remove(selectedUser);
            }
        }

        private void RemoveUserFromGroup()
        {
            if (selectedGroup != null && listBoxGroupMembers.SelectedItem != null)
            {
                object selectedUser = listBoxGroupMembers.SelectedItem;
                listBoxOtherUsers.Items.Add(selectedUser);
                listBoxGroupMembers.Items.Remove(selectedUser);
            }
        }

        private void UpdateGroup()
        {
            string groupName = textBoxGroupName.Text;

            context.Groups.Load();
            var groupToUpdate = context.Groups.Single(g => g.Id == selectedGroup.Id);

            if (groupToUpdate != null)
            {
                // Update group info
                groupToUpdate.GroupName = groupName;
                groupToUpdate.Disabled = radioButtonDisabledYes.Checked;

                groupToUpdate.Users.Clear();
                listBoxGroupMembers.Items.Cast<User>().ToList().ForEach(member => groupToUpdate.Users.Add(member));

                // Sync database and datagridview
                context.SaveChanges();
                context.Groups.Load();
                LoadGroups();

                // Default select the updated group
                for (int i = 0; i < dataGridViewGroups.Rows.Count; i++)
                {
                    if (selectedGroup.Id.ToString() == dataGridViewGroups.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridViewGroups.Rows[i].Selected = true;
                        selectedGroup = displayGroups[i];
                        DisplayGroupDetail();
                    }
                    else
                    {
                        dataGridViewGroups.Rows[i].Selected = false;
                    }
                }
            }
        }
    }
}
