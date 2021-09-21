using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Chiyung_Miniproject2
{
    public partial class RegistrationForm : Form
    {
        public static RegistrationForm objRegForm = new RegistrationForm();

        public RegistrationForm()
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            int intLoop = 1;
            try
            {
                //Prevent creation of blank accounts
                while (intLoop == 1)
                {
                    if (nameTextBox.Text == "")
                    {
                        msgLabel.Text = "*Please enter \"User ID\"";
                        nameTextBox.Focus();
                        intLoop = 1;
                        return;
                    }
                    else if (passwordTextBox.Text == "")
                    {
                        msgLabel.Text = "*Please enter \"Password\"";
                        passwordTextBox.Focus();
                        intLoop = 1;
                        return;
                    }
                    else
                    {
                        intLoop = 0;
                    }
                }

                if (File.Exists(nameTextBox.Text + ".txt"))
                {
                    MessageBox.Show("Name has been used by other user!!!", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Add another user to the User.txt file
                    StreamWriter srUser = new StreamWriter("User.txt", true);
                    srUser.WriteLine(nameTextBox.Text);
                    srUser.Close();

                    //Create new user .txt file
                    StreamWriter newUser = new StreamWriter(nameTextBox.Text + ".txt");
                    newUser.WriteLine("User ID:\n" + nameTextBox.Text);
                    newUser.WriteLine("Password:\n" + passwordTextBox.Text +
                        "\n================================================");
                    newUser.Close();

                    MessageBox.Show("User created successfully", "Notification"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear text boxes and go back to login page
                    nameTextBox.Clear();
                    passwordTextBox.Clear();
                    this.Hide();
                    LoginForm.objLogin.Show();

                }
            }
            catch
            {
                MessageBox.Show("Create User unsuccessful");
            }
        }       

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Clear text boxes
            nameTextBox.Text = "";
            passwordTextBox.Text = "";
            msgLabel.Text = "";

            //Go back to login form
            LoginForm.objLogin.Show();
            nameTextBox.Clear();
            passwordTextBox.Clear();
            this.Hide();
        }       
    }
}