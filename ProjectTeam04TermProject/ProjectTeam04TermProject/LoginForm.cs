using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MeetingManagementClassLibrary;

namespace ProjectTeam04TermProject
{
    public partial class LoginForm : Form
    {
        private MeetingManagementEntities context;

        public LoginForm()
        {
            InitializeComponent();
            
            context = MainForm.context;

            // Bind click event for Login button
            buttonLogin.Click += (s, e) => Login();
        }

        private void Login()
        {
            // Authenticate user
            User user = Authenticate();

            if (user != null)
            {
                // Hide Login form
                this.DialogResult = DialogResult.OK;
                this.Close();

                // Pass login user and show Main form
                MainForm.loggedinUser = user;
            }
            else
            {
                // Show error message
                labelLoginResult.Text = "Username is invalid";
            }
        }

        private User Authenticate()
        {            
            // Get username from text box
            string username = textBoxUserName.Text;
            
            // Get user by username
            if (username != "")
            {
                var loginUser = from user in context.Users
                                 where user.Username == username
                                 select user;

                if (loginUser != null && loginUser.ToList().Count > 0)
                {
                    // Found user with input username
                    return loginUser.ToList()[0];
                }
            }

            return null;
        }
    }
}
