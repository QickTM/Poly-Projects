using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Chiyung_Miniproject2
{
    public partial class LoginForm : Form
    {
        public static string strName;
        public static LoginForm objLogin = new LoginForm();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ClearLabels() 
        {
            //clear labels
            msgLabel.Text = "";
            nameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Check for correct User ID, if not then notify user of wrong User ID
                string strpassword;

                if (nameTextBox.Text == "")
                {
                    msgLabel.Text = "*Please enter \"User ID\"!";
                    nameTextBox.Focus();
                }
                else if (passwordTextBox.Text == "")
                {
                    msgLabel.Text = "*Please enter \"Password\"!";
                    passwordTextBox.Focus();
                }
                else
                {
                    //Search for .txt file with the same User ID entered
                    StreamReader newUserReader = new StreamReader(nameTextBox.Text + ".txt", true);
                    newUserReader.ReadLine();
                    strName = newUserReader.ReadLine();
                    newUserReader.ReadLine();
                    strpassword = newUserReader.ReadLine();
                    newUserReader.Close();

                    if (strpassword == passwordTextBox.Text)
                    {
                        //Clear labels
                        msgLabel.Text = "";
                        nameTextBox.Text = "";
                        passwordTextBox.Text = "";

                        //Delay execution of next line of code to simulate processing
                        Thread.Sleep(500);

                        //Add login time to .txt file
                        StreamWriter swTime = new StreamWriter(LoginForm.strName + ".txt", true);
                        DateTime dtNow = DateTime.Now;
                        swTime.WriteLine("Login time: " + dtNow.ToString());
                        swTime.Close();

                        //Show game form and hide the login form
                        objLogin = this;
                        this.Hide();
                        TopicForm.objTopic.Show();
                    }
                    else
                    {
                        msgLabel.Text = "*Login fail, wrong \"Password\"";
                        passwordTextBox.Focus();
                    }
                }
            }
            catch
            {
                msgLabel.Text = "*User does not exist";
                nameTextBox.Focus();
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            ClearLabels();

            //Hide LoginForm and show RegistrationForm
            objLogin = this;
            this.Hide();
            RegistrationForm.objRegForm.Show();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            HistoryForm.objHistory.Show();
        }

        private void forgotButton_Click(object sender, EventArgs e)
        {
            ClearLabels();

            //Hide login and show change password form
            this.Hide();
            ChangePasswordForm.objChange.Show();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}