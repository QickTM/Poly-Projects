using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Management.Instrumentation;

namespace Chiyung_Miniproject2
{
    public partial class HistoryForm : Form
    {
        public static HistoryForm objHistory = new HistoryForm();

        public HistoryForm()
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

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            LoadLeaderboard();
        }

        private void Logout()
        {
            //Make the other things invisible
            userComboBox.Visible = false;
            userLabel.Visible = false;
            readButton.Visible = false;
            exitButton.Visible = false;
            displayListBox.Visible = false;
            logoutButton.Visible = false;
            adminpasswordTextBox.Focus();
            userComboBox.Items.Clear();
            displayListBox.Items.Clear();
            userComboBox.Text = "Select User";

            //Make login interface appear
            msgLabel.Text = "";
            adminpasswordTextBox.Text = "";
            adminLabel.Visible = true;
            adminpasswordTextBox.Visible = true;
            msgLabel.Visible = true;
            loginButton.Visible = true;
        }

        private void Login()
        {
            //Make the other thing visible
            userComboBox.Visible = true;
            userLabel.Visible = true;
            readButton.Visible = true;
            exitButton.Visible = true;
            displayListBox.Visible = true;
            logoutButton.Visible = true;

            //Make login interface disappear
            msgLabel.Text = "";
            adminpasswordTextBox.Text = "";
            adminLabel.Visible = false;
            adminpasswordTextBox.Visible = false;
            msgLabel.Visible = false;
            loginButton.Visible = false;
        }

        private void LoadHistory()
        {
            int intLine;
            displayListBox.Items.Clear();

            //Make it seem like its loading
            Thread.Sleep(50);

            StreamReader srHistory = new StreamReader(userComboBox.Text + ".txt", true);

            //Skip first 4 lines in .txt file
            for (intLine = 0; intLine < 4; intLine++)
            {
                srHistory.ReadLine();
            }

            //Add all items in .txt file into list box
            while (srHistory.Peek() != -1)
            {
                displayListBox.Items.Add(srHistory.ReadLine());
            }
            srHistory.Close();
        }

        private void LoadLeaderboard()
        {
            scoreListView.Clear();

            //Make it seem like its loading
            Thread.Sleep(50);

            //Create column design and write lines form .txt file
            ColumnHeader columnHeader;
            ListViewItem listViewItem;
            scoreListView.View = View.Details;
            int intNumUsers = File.ReadAllLines("Score.txt").Length / 5;

            string[] lines = File.ReadAllLines("Score.txt");

            for (int i = 0; i < intNumUsers; i++)
            {
                //Write out each line into table
                listViewItem = new ListViewItem(lines[5 * i]);
                listViewItem.SubItems.Add(lines[(5 * i) + 1]);
                listViewItem.SubItems.Add(lines[(5 * i) + 2]);
                listViewItem.SubItems.Add(lines[(5 * i) + 3]);
                listViewItem.SubItems.Add(lines[(5 * i) + 4]);

                this.scoreListView.Items.Add(listViewItem);
            }

            //Create a column for each specific variable
            columnHeader = new ColumnHeader();
            columnHeader.Text = "Name: ";
            this.scoreListView.Columns.Add(columnHeader);

            columnHeader = new ColumnHeader();
            columnHeader.Text = "Total Games: ";
            this.scoreListView.Columns.Add(columnHeader);            

            columnHeader = new ColumnHeader();
            columnHeader.Text = "Win: ";
            this.scoreListView.Columns.Add(columnHeader);

            columnHeader = new ColumnHeader();
            columnHeader.Text = "Loss: ";
            this.scoreListView.Columns.Add(columnHeader);

            columnHeader = new ColumnHeader();
            columnHeader.Text = "Win Percentage: ";
            this.scoreListView.Columns.Add(columnHeader);

            foreach (ColumnHeader column in this.scoreListView.Columns)
            {
                //Have proper spacing
                column.Width = -2;
            }
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            string strUser;

            StreamReader srUser = new StreamReader("User.txt", true);

            //Loop User.txt file till a user is selected in the userComboBox
            while (srUser.Peek() != -1)
            {
                //Check for correct selection of user to view history 
                strUser = srUser.ReadLine().ToString();
                if (userComboBox.Text == strUser)
                {
                    //Show history of user selected and break from loop
                    LoadHistory();
                    break;
                }
                else
                {
                    //Give a notification then continue loop
                    if (userComboBox.Text == "Select User")
                    {
                        MessageBox.Show("Please select a user before refreshing.",
                            "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadLeaderboard();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string strAdminPass = "Troll420";

            //Check for correct, blank, or wrong password and execute coressponding code
            if(adminpasswordTextBox.Text == "")
            {
                msgLabel.Text = "*Please enter password to login";
                adminpasswordTextBox.Focus();
            }
            else if (adminpasswordTextBox.Text != strAdminPass)
            {
                msgLabel.Text = "*Wrong \"Password\" entered, please try agian!";
            }
            else
            {
                StreamReader srUser = new StreamReader("User.txt", true);

                //Add all items in the User.txt file as items in the ComboBox
                while (srUser.Peek() != -1)
                {
                    userComboBox.Items.Add(srUser.ReadLine());
                }

                Login();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Clear list box items and hide HistoryForm
            Logout();
            this.Hide();
        }

        private void exitButton2_Click(object sender, EventArgs e)
        {
            //Clear list box items and hide HistoryForm
            Logout();
            this.Hide();
        }
    }
}