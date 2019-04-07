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

            // Setup Group View
            SetupGroupDataGridView();
            DefaultFields();
            BindEventsForControls();
            LoadGroups();

            // Default select first row
            if (dataGridViewGroups.Rows.Count > 0)
            {
                dataGridViewGroups.Rows[0].Selected = true;
                selectedGroup = displayGroups[0];                
            }
            DisplayGroupDetail();
        }

        private void SetupGroupDataGridView()
        {
            // Disable edit on datagridview
            dataGridViewGroups.ReadOnly = true;
            dataGridViewGroups.AllowUserToAddRows = false;
            dataGridViewGroups.AllowUserToDeleteRows = false;            
            dataGridViewGroups.RowHeadersVisible = false;
            dataGridViewGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGroups.Columns.Clear();

            // Add columns
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
            // Default Filter form fields
            textBoxSearchGroupName.Text = "";
            checkBoxShowDisabledGroups.Checked = true;
            checkBoxGroupNoMember.Checked = false;
        }

        private void BindEventsForControls()
        {
            // On Click a Cell/Row in datagridview
            dataGridViewGroups.CellClick += DataGridViewCellClick;

            // On Click Filter form button
            buttonFilterGroups.Click += (s, e) =>
            {
                // Reload datagridview
                LoadGroups();

                // Default select first row
                if (dataGridViewGroups.Rows.Count > 0)
                {
                    dataGridViewGroups.Rows[0].Selected = true;
                    selectedGroup = displayGroups[0];                    
                }
                DisplayGroupDetail();
            };
            
            // On Click + button to show add group form
            buttonAddGroup.Click += (s, e) => ChangeToAddGroupForm();

            // On Click confirm Add/Update selected group
            buttonUpdateGroup.Click += (s, e) => AddUpdateGroup();

            // On Click button to discard Add/Update on selected group
            buttonCancelUpdateGroup.Click += (s, e) => CancelAddUpdateGroup();

            // On Click buttons to Add/Remove users from listboxes
            buttonAddToGroup.Click += (s, e) => AddUserToGroup();
            buttonRemoveFromGroup.Click += (s, e) => RemoveUserFromGroup();
        }

        private void LoadGroups()
        {
            // Reset display data
            dataGridViewGroups.Rows.Clear();
            selectedGroup = null;
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
            if (checkBoxGroupNoMember.Checked)
            {
                displayGroups = displayGroups.Where(g => g.Users.Count == 0).ToList();
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

            // Hilight the selected row
            for (int i = 0; i < dataGridViewGroups.Rows.Count; i++)
            {
                if (i == e.RowIndex)
                {
                    dataGridViewGroups.Rows[i].Selected = true;
                    selectedGroup = displayGroups.Where(g => g.Id == int.Parse(dataGridViewGroups.Rows[i].Cells[0].Value.ToString())).ToList()[0];
                }
                else dataGridViewGroups.Rows[i].Selected = false;
            }

            // Display selected group info
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

                // Enable form controls
                buttonUpdateGroup.Enabled = true;
                buttonCancelUpdateGroup.Enabled = true;
            }
            else
            {
                // There is no selected group, clear form and disable controls
                textBoxGroupName.Text = "";
                radioButtonDisabledYes.Checked = false;
                radioButtonDisabledNo.Checked = false;
                textBoxGroupName.Enabled = false;
                radioButtonDisabledYes.Enabled = false;
                radioButtonDisabledNo.Enabled = false;
                listBoxGroupMembers.Items.Clear();
                listBoxGroupMembers.Enabled = false;
                listBoxOtherUsers.Items.Clear();
                listBoxOtherUsers.Enabled = false;
                buttonUpdateGroup.Enabled = false;
                buttonCancelUpdateGroup.Enabled = false;
            }
        }

        private void LoadDataForUserListBoxes()
        {
            if (selectedGroup != null)
            {
                // Load members of the selected group
                var members = from user in context.Users
                              where user.Groups.Any(g => g.Id == selectedGroup.Id)
                              orderby user.Username ascending
                              select user;
                
                // Load members to listbox
                listBoxGroupMembers.Items.Clear();
                listBoxGroupMembers.Items.AddRange(members.ToArray());

                // Load users that is not in the selected group
                var others = from user in context.Users
                             where user.Groups.All(g => g.Id != selectedGroup.Id)
                             orderby user.Username ascending
                             select user;

                // Load others to listbox
                listBoxOtherUsers.Items.Clear();
                listBoxOtherUsers.Items.AddRange(others.ToArray());
            }            
        }

        private void AddUserToGroup()
        {
            // Remove user from others listbox and add to members listbox
            if (selectedGroup != null && listBoxOtherUsers.SelectedItem != null)
            {
                object selectedUser = listBoxOtherUsers.SelectedItem;
                listBoxGroupMembers.Items.Add(selectedUser);
                listBoxOtherUsers.Items.Remove(selectedUser);
            }
        }

        private void RemoveUserFromGroup()
        {
            // Remove user from members listbox and add to others listbox
            if (selectedGroup != null && listBoxGroupMembers.SelectedItem != null)
            {
                object selectedUser = listBoxGroupMembers.SelectedItem;
                listBoxOtherUsers.Items.Add(selectedUser);
                listBoxGroupMembers.Items.Remove(selectedUser);
            }
        }

        private void ChangeToAddGroupForm()
        {
            // Initialize a new group
            Group newGroup = new Group();
            newGroup.GroupName = "";
            newGroup.Disabled = false;

            // Change labels
            labelGroupDetail.Text = "Add Group Detail";
            buttonUpdateGroup.Text = "Add Group";

            // Un-select all rows
            for (int i = 0; i < dataGridViewGroups.Rows.Count; i++)
            {
                dataGridViewGroups.Rows[i].Selected = false;
            }

            // Enable Add Form
            selectedGroup = newGroup;
            DisplayGroupDetail();

            // Shift focus to form
            textBoxGroupName.Focus();
        }

        private void AddUpdateGroup()
        {
            // Get input group name
            string groupName = textBoxGroupName.Text.Trim();

            if (groupName == "") // Only proceed if group name is filled
            {
                MessageBox.Show("Group Name is required");
                return;
            }

            // Get group to update
            context.Groups.Load();
            Group groupToUpdate;
            if (selectedGroup.Id > 0)
            {
                // It's an existed group to update
                // Check if changed group name has been taken
                if (context.Groups.Any(g => g.GroupName == groupName && g.Id != selectedGroup.Id))
                {
                    MessageBox.Show("Group name " + groupName + " is already existed. Pleas choose another name.");
                    return;
                }

                groupToUpdate = context.Groups.Single(g => g.Id == selectedGroup.Id);
            }
            else
            {
                // It's a new group to add
                // Check if group name has been taken
                if (context.Groups.Any(g => g.GroupName == groupName))
                {
                    MessageBox.Show("Group name " + groupName + " is already existed. Pleas choose another name.");
                    return;
                }

                // Create a new group
                groupToUpdate = new Group();
                context.Groups.Add(groupToUpdate);
            }

            if (groupToUpdate != null)
            {
                // Update group info
                groupToUpdate.GroupName = groupName;
                groupToUpdate.Disabled = radioButtonDisabledYes.Checked;

                // Update members list
                groupToUpdate.Users.Clear();
                listBoxGroupMembers.Items.Cast<User>().ToList().ForEach(member => groupToUpdate.Users.Add(member));

                // Sync database and datagridview
                MainForm.SaveChangesToDatabase();
                LoadGroups();

                // Revert back to update form
                labelGroupDetail.Text = "Group Detail";
                buttonUpdateGroup.Text = "Update Group";
                selectedGroup = context.Groups.Single(g => g.Id == groupToUpdate.Id);

                // Default select the updated group
                for (int i = 0; i < dataGridViewGroups.Rows.Count; i++)
                {
                    if (selectedGroup.Id.ToString() == dataGridViewGroups.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridViewGroups.Rows[i].Selected = true;
                        selectedGroup = displayGroups[i];                        
                    }
                    else
                    {
                        dataGridViewGroups.Rows[i].Selected = false;
                    }
                    DisplayGroupDetail();
                }
            }
        }

        private void CancelAddUpdateGroup()
        {
            if (selectedGroup.Id > 0) // Currently update an existed group
            {
                // Re-display the selected group info
                DisplayGroupDetail();
            }
            else // Currently add a new group
            {
                // Discard the new group and select the first group in list
                if (dataGridViewGroups.Rows.Count > 0)
                {
                    dataGridViewGroups.Rows[0].Selected = true;
                    selectedGroup = displayGroups[0];                    
                }
                DisplayGroupDetail();
            }
        }
    }
}
