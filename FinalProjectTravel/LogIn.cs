using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static FinalProjectTravel.autheticate;
using User = FinalProjectTravel.autheticate.User;

namespace FinalProjectTravel
{
    public partial class LogIn : Form
    {


        public LogIn()
        {
            InitializeComponent();
        }
        private void name_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (name.Text.Length <= 5)
            {
                MessageBox.Show("Username should be at least 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                name.Focus();
                e.Cancel = true;
            }
        }

        private void loginpassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(loginpassword.Text.Length > 8 && loginpassword.Text.Any(char.IsUpper) && loginpassword.Text.Any(char.IsLower) && loginpassword.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("One or more password criteria(s) hasn't been met", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginpassword.SelectAll();
                e.Cancel = true;
            }
        }
        private void Si_Click(object sender, EventArgs e)
        {
            string user = name.Text;
            string pass = loginpassword.Text;

            if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass))
            {
                User authenticatedUser = DatabaseManager.AuthenticateUser(user, pass);

                if (authenticatedUser != null)
                {
                    Menu welcome = new Menu();
                    welcome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }


    }
}
