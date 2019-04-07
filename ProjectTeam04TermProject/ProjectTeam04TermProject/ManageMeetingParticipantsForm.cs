using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeetingManagementClassLibrary;

namespace ProjectTeam04TermProject
{
    public partial class ManageMeetingParticipantsForm : Form
    {
        // Information from Main Form
        private MeetingManagementEntities context;
        private User loggedinUser;

        // Current meeting
        Meeting currentMeeting;

        public ManageMeetingParticipantsForm(Meeting currentMeeting)
        {
            InitializeComponent();

            // Get context and user info from MainForm
            context = MainForm.context;
            loggedinUser = MainForm.loggedinUser;

            // Set current meeting
            this.currentMeeting = currentMeeting;

            // Setup Group View
            DefaultFields();
            BindEventsForControls();
            LoadUsersListbox();
            LoadGroupsListbox();
            DisplayParticipants();
        }

        private void DefaultFields()
        {
            // Show Meeting detail
            labelDisplayMeetingTitle.Text = currentMeeting.Title;
            labelDisplayRoom.Text = currentMeeting.MeetingRoom.RoomName;
            labelDisplayLocation.Text = currentMeeting.MeetingRoom.Location;
            labelDisplayFrom.Text = currentMeeting.From.ToString();
            labelDisplayTo.Text = currentMeeting.To.ToString();            
        }

        private void BindEventsForControls()
        {
            // Bind event on add remove participants buttons
            buttonInviteUser.Click += (s, e) => MoveItemBetweenParticipantsListboxes(listBoxOtherUsers, listBoxInvitedUsers);
            buttonRemoveUser.Click += (s, e) => MoveItemBetweenParticipantsListboxes(listBoxInvitedUsers, listBoxOtherUsers);
            buttonInviteGroup.Click += (s, e) => MoveItemBetweenParticipantsListboxes(listBoxOtherGroups, listBoxInvitedGroups);
            buttonRemoveGroup.Click += (s, e) => MoveItemBetweenParticipantsListboxes(listBoxInvitedGroups, listBoxOtherGroups);

            // On Click Cancel button
            buttonCancel.Click += (s, e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };

            // On Click update participants
            buttonUpdateParticipants.Click += UpdateParticipants;
        }

        private void LoadUsersListbox()
        {
            // Load invited users
            var invitedUsers = currentMeeting.Users;
            // Add invited users to listbox
            listBoxInvitedUsers.Items.Clear();
            listBoxInvitedUsers.Items.AddRange(invitedUsers.ToArray());

            // Load users that are not invited yet
            var others = from user in context.Users
                         where user.Meetings.All(m => m.Id != currentMeeting.Id)
                         where user.Id != currentMeeting.CreatedBy
                         where user.Disabled == false
                         orderby user.Username ascending
                         select user;
            // Load others to listbox
            listBoxOtherUsers.Items.Clear();
            listBoxOtherUsers.Items.AddRange(others.ToArray());
        }

        private void LoadGroupsListbox()
        {
            // Load invited groups
            var invitedGroups = currentMeeting.Groups;
            // Add invited groups to listbox
            listBoxInvitedGroups.Items.Clear();
            listBoxInvitedGroups.Items.AddRange(invitedGroups.ToArray());

            // Load groups that are not invited yet
            var others = from g in context.Groups
                         where g.Meetings.All(m => m.Id != currentMeeting.Id)
                         where g.Disabled == false
                         orderby g.GroupName ascending
                         select g;
            // Load others to listbox
            listBoxOtherGroups.Items.Clear();
            listBoxOtherGroups.Items.AddRange(others.ToArray());
        }

        private void DisplayParticipants()
        {
            // Concat a string of all participate users and groups
            string displayParticipants = "(Users: " + (listBoxInvitedUsers.Items.Count + 1) + "; Groups: " + listBoxInvitedGroups.Items.Count + ")\n";
            displayParticipants += currentMeeting.User.Username + " (Initiator)";
            listBoxInvitedUsers.Items.Cast<User>().ToList().ForEach(u => displayParticipants += "; " + u.Username);
            listBoxInvitedGroups.Items.Cast<Group>().ToList().ForEach(g => displayParticipants += "; " + g.GroupName);

            // Display on label
            labelDisplayParticipants.Text = displayParticipants;
        }        

        private void MoveItemBetweenParticipantsListboxes(ListBox from, ListBox to)
        {
            if (from.SelectedItem != null)
            {
                object selectedItem = from.SelectedItem;
                to.Items.Add(selectedItem); // Add item to destination
                from.Items.Remove(selectedItem); // Remove item from origin
                DisplayParticipants();
            }
        }

        private void UpdateParticipants(object sender, EventArgs e)
        {
            // Update Invited Users list
            currentMeeting.Users.Clear();
            listBoxInvitedUsers.Items.Cast<User>().ToList().ForEach(user => currentMeeting.Users.Add(user));

            // Update Invited Groups list
            currentMeeting.Groups.Clear();
            listBoxInvitedGroups.Items.Cast<Group>().ToList().ForEach(group => currentMeeting.Groups.Add(group));

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
