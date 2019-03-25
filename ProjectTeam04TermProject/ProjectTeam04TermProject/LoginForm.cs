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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

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
                MainForm mainForm = (MainForm) this.Owner;
                mainForm.User = user;
                mainForm.Show();
            }
            else
            {
                // Show error message
                labelLoginResult.Text = "Username is invalid";
            }
        }

        private User Authenticate()
        {            
            string username = textBoxUserName.Text;

            // TODO: authenticate user
            bool authenticationSuccess = true;
            User user = new User()
            {
                Id = 1,
                Username = "admin",
                Role = User.UserRoles.ADMIN,
                IsDisabled = false
            };

            // Return the result
            if (authenticationSuccess)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
