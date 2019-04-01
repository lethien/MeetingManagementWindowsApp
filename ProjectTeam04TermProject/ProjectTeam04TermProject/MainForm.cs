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
    public partial class MainForm : Form
    {
        // Store Logged in User
        public User User { private get; set; }

        public MainForm()
        {
            InitializeComponent();

            // Show login form
            this.Load += (s, e) => ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            // Show Login Form Dialog
            LoginForm loginForm = new LoginForm();
            Hide();
            DialogResult result = loginForm.ShowDialog(this);

            // Render content of Main form based on logged in user
            if (result == DialogResult.OK)
            {
                RenderMainForm();
            }
        }

        private void RenderMainForm()
        {
            // Remove Tab Pages based on User's Role
            switch (User.Role)
            {
                case Constants.USER_ROLE_USER: // Only show My Schedule Tab
                    tabPageMySchedule.Controls.Add(new MyScheduleTabControl());
                    tabControlMainForm.TabPages.Remove(tabPageManageMeetings);
                    tabControlMainForm.TabPages.Remove(tabPageManageMeetingRooms);
                    tabControlMainForm.TabPages.Remove(tabPageManageGroups);
                    break;
                case Constants.USER_ROLE_MANAGER: // Remove Manage Groups Tab
                    tabPageMySchedule.Controls.Add(new MyScheduleTabControl());
                    tabPageManageMeetings.Controls.Add(new ManageMeetingTabControl());
                    tabPageManageMeetingRooms.Controls.Add(new ManageMeetingRoomTabControl());
                    tabControlMainForm.TabPages.Remove(tabPageManageGroups);
                    break;
                case Constants.USER_ROLE_ADMIN: // Full rights
                    tabPageMySchedule.Controls.Add(new MyScheduleTabControl());
                    tabPageManageMeetings.Controls.Add(new ManageMeetingTabControl());
                    tabPageManageMeetingRooms.Controls.Add(new ManageMeetingRoomTabControl());
                    tabPageManageGroups.Controls.Add(new ManageGroupTabControl());
                    break;
                default: // Unknown role, default as Normal User
                    tabPageMySchedule.Controls.Add(new MyScheduleTabControl());
                    tabControlMainForm.TabPages.Remove(tabPageManageMeetings);
                    tabControlMainForm.TabPages.Remove(tabPageManageMeetingRooms);
                    tabControlMainForm.TabPages.Remove(tabPageManageGroups);
                    break;
            }            
        }        
    }
}
