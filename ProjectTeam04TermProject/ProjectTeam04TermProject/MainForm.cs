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
using System.Data.Entity;
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

            // Bind on close event for main form
            this.FormClosed += OnMainForm_Close;
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
            else
            {
                Close();
            }
        }

        public void RenderMainForm()
        {
            // Remove Tab Pages based on User's Role
            switch (loggedinUser.Role)
            {
                case Constants.USER_ROLE_USER: // Only show My Schedule Tab
                    tabPageManageMeetings.Controls.Add(new ManageMeetingTabControl());
                    tabControlMainForm.TabPages.Remove(tabPageManageMeetingRooms);
                    tabControlMainForm.TabPages.Remove(tabPageManageGroups);
                    tabControlMainForm.TabPages.Remove(tabPageXML);
                    break;
                case Constants.USER_ROLE_MANAGER: // Remove Manage Groups and XML Tab
                    tabPageManageMeetings.Controls.Add(new ManageMeetingTabControl());
                    tabPageManageMeetingRooms.Controls.Add(new ManageMeetingRoomTabControl());
                    tabControlMainForm.TabPages.Remove(tabPageManageGroups);
                    tabControlMainForm.TabPages.Remove(tabPageXML);
                    break;
                case Constants.USER_ROLE_ADMIN: // Full rights
                    tabPageManageMeetings.Controls.Add(new ManageMeetingTabControl());
                    tabPageManageMeetingRooms.Controls.Add(new ManageMeetingRoomTabControl());
                    tabPageManageGroups.Controls.Add(new ManageGroupTabControl());
                    tabPageXML.Controls.Add(new XMLTabControl());
                    break;
                default: // Unknown role, no access to all
                    tabControlMainForm.TabPages.Remove(tabPageManageMeetings);
                    tabControlMainForm.TabPages.Remove(tabPageManageMeetingRooms);
                    tabControlMainForm.TabPages.Remove(tabPageManageGroups);
                    tabControlMainForm.TabPages.Remove(tabPageXML);
                    break;
            }            
        }

        public static void SaveChangesToDatabase()
        {
            try
            {
                context.SaveChanges();
                context.Users.Load();
                context.Groups.Load();
                context.MeetingRooms.Load();
                context.Meetings.Load();
            }
            catch
            {
                MessageBox.Show("Error in updating database");
            }
        }

        public void ReloadTabsContent()
        {
            // Initialize database context
            context = new MeetingManagementEntities();

            // set up database log to write to output window in VS
            context.Database.Log = s => Debug.Write(s);
            context.SaveChanges();

            // Clear tabs content
            tabPageManageMeetings.Controls.Clear();
            tabPageManageMeetingRooms.Controls.Clear();
            tabPageManageGroups.Controls.Clear();
            tabPageXML.Controls.Clear();

            // Ask for re-login
            ShowLoginForm();
        }

        private void OnMainForm_Close(object sender, EventArgs e)
        {
            // Close db connection
            context.Database.Connection.Close();
            context.Dispose();
        }
    }
}
