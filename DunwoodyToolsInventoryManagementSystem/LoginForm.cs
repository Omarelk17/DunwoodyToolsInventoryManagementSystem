using DunwoodyToolsInventoryManagementSystem.Models;
using DunwoodyToolsInventoryManagementSystem.Repository;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DunwoodyToolsInventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtUsername.Focus();
            txtUsername.Text = "admin";
            txtPassword.Text = "admin123";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            LoginRepository loginRepo = new LoginRepository();
            var isAuthenticated = loginRepo.AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                // You can create different main forms based on the role
                DashboardForm mainForm = new DashboardForm();
                // Hide the login form
                this.Hide();

                // Show the main form
                mainForm.Show();

                // Close the login form when the main form is closed
                mainForm.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
