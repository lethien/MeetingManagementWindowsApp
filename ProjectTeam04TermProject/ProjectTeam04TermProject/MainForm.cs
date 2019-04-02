using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MeetingManagementClassLibrary;

namespace ProjectTeam04TermProject
{
    public partial class MainForm : Form
    {
        // Database context
        public static MeetingManagementEntities context;

        // Store Logged in User
        public static User loggedinUser;

        public MainForm()
        {
            InitializeComponent();

            // Initialize database context
            context = new MeetingManagementEntities();

            // set up database log to write to output window in VS
            context.Database.Log = s => Debug.Write(s);
            context.SaveChanges();

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
                Show();
                RenderMainForm();
            }
        }

        private void RenderMainForm()
        {
            // Remove Tab Pages based on User's Role
            switch (loggedinUser.Role)
            {
                case Constants.USER_ROLE_USER: // Only show My Schedule Tab
                    tabPageManageMeetings.Controls.Add(new MeetingManageTabControl());
                    tabControlMainForm.TabPages.Remove(tabPageManageMeetingRooms);
                    tabControlMainForm.TabPages.Remove(tabPageManageGroups);
                    tabControlMainForm.TabPages.Remove(tabPageXML);
                    break;
                case Constants.USER_ROLE_MANAGER: // Remove Manage Groups and XML Tab
                    tabPageManageMeetings.Controls.Add(new MeetingManageTabControl());
                    tabPageManageMeetingRooms.Controls.Add(new ManageMeetingRoomTabControl());
                    tabControlMainForm.TabPages.Remove(tabPageManageGroups);
                    tabControlMainForm.TabPages.Remove(tabPageXML);
                    break;
                case Constants.USER_ROLE_ADMIN: // Full rights
                    tabPageManageMeetings.Controls.Add(new MeetingManageTabControl());
                    tabPageManageMeetingRooms.Controls.Add(new ManageMeetingRoomTabControl());
                    tabPageManageGroups.Controls.Add(new ManageGroupTabControl());
                    break;
                default: // Unknown role, no access to all
                    tabControlMainForm.TabPages.Remove(tabPageManageMeetings);
                    tabControlMainForm.TabPages.Remove(tabPageManageMeetingRooms);
                    tabControlMainForm.TabPages.Remove(tabPageManageGroups);
                    tabControlMainForm.TabPages.Remove(tabPageXML);
                    break;
            }            
        }        
    }
}
