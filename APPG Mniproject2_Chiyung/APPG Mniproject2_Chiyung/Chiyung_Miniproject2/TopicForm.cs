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
using System.Net.Configuration;

namespace Chiyung_Miniproject2
{
    public partial class TopicForm : Form
    {
        public static TopicForm objTopic = new TopicForm();

        public TopicForm()
        {
            InitializeComponent();
        }

        public static string strTopic;
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

        private void dishButton_Click(object sender, EventArgs e)
        {
            //Set topic as Food
            strTopic = "Food";
            objTopic.Hide();
            HangmanForm.objHangman.Show();            
        }

        private void countrybutton_Click(object sender, EventArgs e)
        {
            //Set topic as Country
            strTopic = "Country";
            objTopic.Hide();
            HangmanForm.objHangman.Show();
        }

        private void furnitureButton_Click(object sender, EventArgs e)
        {
            //Set topic as Furniture
            strTopic = "Furniture";
            objTopic.Hide();
            HangmanForm.objHangman.Show();
        }

        private void colourButton_Click(object sender, EventArgs e)
        {
            //Set topic as Colours
            strTopic = "Colours";
            objTopic.Hide();
            HangmanForm.objHangman.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Add play status
            StreamWriter swPlay = new StreamWriter(LoginForm.strName + ".txt", true);
            swPlay.WriteLine("Did not choose topic to play, and exited.");
            swPlay.Close();

            //Add logout time to user
            StreamWriter swTime = new StreamWriter(LoginForm.strName + ".txt", true);
            DateTime dtNow = DateTime.Now;
            swTime.WriteLine("Logout time: " + dtNow.ToString() 
                + "\n================================================");
            swTime.Close();

            //Hide topic form and show login form
            this.Hide();
            LoginForm.objLogin.Show();
        }
    }
}