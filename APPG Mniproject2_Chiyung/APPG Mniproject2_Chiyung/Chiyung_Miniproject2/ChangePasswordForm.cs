using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chiyung_Miniproject2
{
    public partial class ChangePasswordForm : Form
    {
        public static ChangePasswordForm objChange = new ChangePasswordForm();

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private const int CloseButton = 0x200;
        protected override CreateParams CreateParams
        {
            //To disable the close button in the windows form
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CloseButton;
                return myCp;
            }
        }

        private void ClearItems()
        {
            //Clear text boxes
            userTextBox.Text = "";
            newpasswordTextBox.Text = "";
            confirmTextBox.Text = "";
            msgLabel.Text = "";
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            string strNewPassword = newpasswordTextBox.Text;
            string strConfirmPassword = confirmTextBox.Text; 

            //Check for blank text boxes
            if (userTextBox.Text == "")
            {
                msgLabel.Text = "*Please enter User ID!";
                userTextBox.Focus();
            }
            else if (newpasswordTextBox.Text == "")
            {
                msgLabel.Text = "*Please enter new Password!";
                newpasswordTextBox.Focus();
            }
            else if (confirmTextBox.Text == "")
            {
                msgLabel.Text = "*Please confirm Password";
                confirmTextBox.Focus();
            }
            else
            {
                //See if the file does exist
                if (File.Exists(userTextBox.Text + ".txt"))
                {
                    //Change password for user if file exsits
                    if (strNewPassword == strConfirmPassword)
                    {
                        //Replace contents of selected .txt file
                        string[] strLogs = File.ReadAllLines(userTextBox.Text + ".txt");
                        strLogs[3] = confirmTextBox.Text;
                        File.WriteAllLines(userTextBox.Text + ".txt", strLogs);

                        ClearItems();

                        MessageBox.Show("Password was changed successfully",
                            "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        msgLabel.Text = "*Passwords do not match!";
                        return;
                    }
                }
                else
                {
                    msgLabel.Text = "*User does not exist";
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Return to login page
            ClearItems();
            this.Hide();
            LoginForm.objLogin.Show();
        }
    }
}