using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;

namespace ExpenseAutomationSystemWinForm
{
    public partial class FrmLogin : Form
    {
        UserBusiness ub = new UserBusiness();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(PreCheck())
            {
                return;
            }
            else
            {
                Staff staff = ub.StaffLogin(txtUsername.Text, txtPassword.Text);
                               
                if(staff != null)
                {
                    this.Hide();
                    FrmMain mainMenu = new FrmMain();
                    mainMenu.LoggedInStaff = staff;
                    mainMenu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password is not matching",
                        "Login Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }          
            }
        }

        private bool PreCheck()
        {
            bool result = false;

            errProvider.Clear();

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                errProvider.SetError(txtUsername, "Username Cannot Be Empty");
                result = true;
            }

            if (string.IsNullOrEmpty(password))
            {
                errProvider.SetError(txtPassword, "Password Cannot Be Empty");
                result = true;
            }

            return result;
        }

    }
}
