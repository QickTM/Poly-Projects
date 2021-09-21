using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace Chiyung_Miniproject2
{
    public partial class HangmanForm : Form
    {
        WindowsMediaPlayer music = new WindowsMediaPlayer();
        public static HangmanForm objHangman = new HangmanForm();

        public HangmanForm()
        {
            InitializeComponent();
            inputTextBox.Enabled = false;
            hangmanPictureBox.Load("Capture0.png");
        }

        //Declare global variables
        string strLetters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
        string strLetter;
        string strWord;
        string strBlank = "";
        string strUnderscore = "_ ";
        string strNewChange;
        bool blnContinue; 
        bool blnStartFlag;
        int intWordNum;
        int intGamesPlayed = 0;
        int intNumTries = 0;
        int intNumber;
        int intWinCount= 0; 
        int intLossCount = 0;
        
        //Array for topics
        string[] strFood = { "PASTA", "BURGERS", "STEAK", "SATAY", "PIZZA", 
            "CROISSANT", "TOAST", "SAUSAGE", "DURIAN", "MEATBALL"};
        string[] strFurniture = { "TABLE", "CHAIR", "BEDFRAME", "STOOL", "CUPBOARD", 
            "LAMP", "CURTAIN", "DOORFRAME", "BED", "CABINET" };
        string[] strColours = { "BLACK", "GREEN", "YELLOW", "MAGENTA", "PURPLE", 
            "ORANGE", "PINK", "LAVANDER", "GREY", "INDOGO" };
        string[] strCountry = { "SINGAPORE", "THAILAND", "ENGLAND", "AMERICA", "JAPAN", 
            "EUROPE", "CANADA", "SPAIN", "RUSSIA", "KOREA" };

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

        private bool CheckValidInput(string strInput)
        {
            //check if input is letters only
            if (strLetters.Contains(strInput))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private int TopicChoice()
        {
            //Assign choice from TopicForm
            string strChoice = TopicForm.strTopic;
            switch (strChoice)
            {
                case "Food": return 0;
                case "Furniture": return 1;
                case "Colours": return 2;
                case "Country": return 3;
                default: return 5;
            }
        }
        
        private void SwitchImage()
        {
            intNumTries++;

            //Change picture every incrase in intNumTries
            switch (intNumTries)
            {
                case 0: hangmanPictureBox.Load("Capture0.png"); break;
                case 1: hangmanPictureBox.Load("Capture1.png"); break;
                case 2: hangmanPictureBox.Load("Capture2.png"); break;
                case 3: hangmanPictureBox.Load("Capture3.png"); break;
                case 4: hangmanPictureBox.Load("Capture4.png"); break;
                case 5: hangmanPictureBox.Load("Capture5.png"); break;
                case 6: hangmanPictureBox.Load("Capture6.png"); break;
                case 7: hangmanPictureBox.Load("Capture7.png"); break;
            }
        }

        private void ReplaceToUnderscore(string strWordGet)
        {
            int intLetterCount = 0;
            strWord = strWordGet;
            char[] chWordToUnderscore = strWord.ToCharArray();

            while (intLetterCount < strWord.Length)
            {
                //Replace letters with underscore
                strBlank = strBlank + chWordToUnderscore[intLetterCount].ToString().
                    Replace(chWordToUnderscore[intLetterCount].ToString(), strUnderscore);

                intLetterCount++;
            }

            //Display modified word in wordLabel
            wordLabel.Text = strBlank;
        }

        private string ReplaceToWord(string strWordInput)
        {
            //Convert original word and strBlank into char array
            char[] charWordUnderscoreToWord = strWord.ToCharArray();
            char[] charAnswer = strBlank.ToCharArray();
            intNumber = 0;
            int intCharNum = 0;

            //Loop through word to check for letters to be changed
            while (intNumber < strWord.Length)
            {
                //Check if char is NOT an underscore 
                if (charAnswer[intCharNum] != '_')
                {
                    intCharNum = intCharNum + 2;
                    intNumber++;
                    continue;
                }

                //Check if strInput is same as any char in the word array
                if (strWordInput == charWordUnderscoreToWord[intNumber].ToString()) 
                {
                    //Replace the underscore at that position with the correctly guess letter
                    charAnswer[intCharNum] = charWordUnderscoreToWord[intNumber];
                }
                intCharNum = intCharNum + 2;
                intNumber++;
            }

            //Convert char array back to a new string, and return string
            strBlank = new string(charAnswer);
            return strBlank;
        }

        private int GetNumber()
        {
            //Get random number
            double dbValue;
            Random ranObj = new Random();
            dbValue = ranObj.NextDouble();
            return ((int)(10 * dbValue));
        }

        private void CountGamesPlayed()
        {
            //Count number of games played, and display on gamesNumLabel
            intGamesPlayed++;
            gamesNumLabel.Text = intGamesPlayed.ToString();
        }

        private void ResetComponents()
        {
            //Reset all componets
            inputTextBox.Text = "";
            hangmanPictureBox.Load("Capture0.png");
            gamesNumLabel.Text = "0";
            winLabel.Text = "0";
            lossLabel.Text = "0";
            startButton.Enabled = true;
            inputTextBox.Enabled = false;
            startButton.Text = "Start";
            wordLabel.Text = "                   ";
            topicLabel.Text = "";
            guessListBox.Items.Clear();
        }     

        private void RecordLogoutTime()
        {
            //Add logout time to user
            StreamWriter swTime = new StreamWriter(LoginForm.strName + ".txt", true);
            DateTime dtNow = DateTime.Now;
            swTime.WriteLine("Logout time: " + dtNow.ToString() +
                "\n================================================");
            swTime.Close();
        }

        private void RecordNumOfGames()
        {
            //Records down games played being 0 or more; if intGamePlayed = 0 state different message
            if (intGamesPlayed > 0)
            {
                //Games played (win / loss record) during this session
                StreamWriter swGames = new StreamWriter(LoginForm.strName + ".txt", true);
                swGames.WriteLine("Played " + intGamesPlayed.ToString() + " games during this time." + "\nWith " 
                    + intWinCount.ToString() + " win(s) and " + intLossCount.ToString() + " loss(es).");
                swGames.Close();
            }
            else
            {
                //Games played during this session, if "Start" button not clicked
                StreamWriter swGames = new StreamWriter(LoginForm.strName + ".txt", true);
                swGames.WriteLine("Did not play despite logining in.");
                swGames.Close();
            }
        }

        private void RecordScores()
        {
            //Calculate win loss %
            double dlbWin = ((float)(intWinCount) / (float)(intGamesPlayed));

            //Record all player scores in seperate .txt file
            StreamWriter srPlayerScore = new StreamWriter("Score.txt", true);

            //if a player starts a game but does not play do not record down blank win / loss
            if (intGamesPlayed > 0 && (intWinCount > 0 || intLossCount > 0))
            {
                srPlayerScore.WriteLine(LoginForm.strName);
                srPlayerScore.WriteLine(intGamesPlayed.ToString());
                srPlayerScore.WriteLine(intWinCount.ToString());
                srPlayerScore.WriteLine(intLossCount.ToString());
                srPlayerScore.WriteLine(dlbWin.ToString("P"));
                srPlayerScore.Close();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //allow game to start
            blnStartFlag = true;
            intNumTries = 0;
            strBlank = "";
            inputTextBox.Text = "";
            guessListBox.Items.Clear();

            //Record topic played everytime startButton is clicked
            StreamWriter srTopicsPlayed = new StreamWriter(LoginForm.strName + ".txt", true);
            srTopicsPlayed.WriteLine("Topic(s) played: " + TopicForm.strTopic);
            srTopicsPlayed.Close();

            //load fresh image
            hangmanPictureBox.Load("Capture0.png");

            //Get a random number and the chosen topic
            intWordNum = GetNumber();
            int intTheme = TopicChoice();
            topicLabel.Text = TopicForm.strTopic;

            //Feed random word from chosen topic array into ReplaceToUnderscore() 
            if (intTheme == 0)
            {
                ReplaceToUnderscore(strFood[intWordNum]);
            }
            else if (intTheme == 1)
            {
                ReplaceToUnderscore(strFurniture[intWordNum]);
            }
            else if (intTheme == 2)
            {
                ReplaceToUnderscore(strColours[intWordNum]);
            }
            else
            {
                ReplaceToUnderscore(strCountry[intWordNum]);
            }

            //Enable and disable specific buttons 
            inputTextBox.Enabled = true;
            inputTextBox.Focus();
            startButton.Enabled = false;
            chooseButton.Enabled = false;
            submitButton.Enabled = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string strTextInput = inputTextBox.Text.ToUpper();
            string strChange;
            strLetter = inputTextBox.Text;
            music.settings.volume = 5;

            //Check for startButton_Click
            if (blnStartFlag == false)
            {
                MessageBox.Show("Please click the start button to start!!", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                startButton.Focus();
                return;
            }
            else
            {
                //Check if its number or letter in intputTextBox
                blnContinue = CheckValidInput(strLetter);
                if (blnContinue == false)
                {
                    MessageBox.Show("1) Only allows one letter at a time!" 
                        + "\n\n2) No numbers and symbols allowed!", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (blnContinue == true)
                {
                    //Check if text box is blank
                    if (inputTextBox.Text == "")
                    {
                        MessageBox.Show("Please enter a letter to start guessing",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        inputTextBox.Focus();
                        return;
                    }

                    //Check if input letter is a character in the string
                    if (strWord.Contains(strTextInput))
                    {
                        //Replace underscore with correct letter guessed, and play sound
                        strChange = ReplaceToWord(strTextInput);
                        wordLabel.Text = strChange;
                        strNewChange = strChange;
                        music.URL = "correct sound effect.mp3";
                        music.controls.play();

                        //Check if whole word is guessed 
                        if (strNewChange.Replace(" ", "") == strWord)
                        {
                            startButton.Text = "Restart";
                            startButton.Enabled = true;
                            inputTextBox.Enabled = false;
                            chooseButton.Enabled = true;
                            blnStartFlag = false;

                            //Count numnber of wins
                            intWinCount++;
                            winLabel.Text = intWinCount.ToString();

                            CountGamesPlayed();

                            //Pop-up message telling player won
                            MessageBox.Show("Congrats, you survived! \nPress \"Restart\" to play again", 
                                "Game Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        //Output for wrong letter guess
                        music.URL = "incorrect sound effect.mp3";
                        music.controls.play();
                        SwitchImage();
                        guessListBox.Items.Add(strTextInput.ToUpper());
                    }

                    if (intNumTries == 7)
                    {
                        //Count number of losses
                        intLossCount++;
                        lossLabel.Text = intLossCount.ToString();

                        CountGamesPlayed();

                        //Pop-up message box telling player game has ended
                        startButton.Text = "Restart";
                        startButton.Enabled = true;
                        chooseButton.Enabled = true;
                        inputTextBox.Enabled = false;
                        MessageBox.Show("Oops, you died!" + "\nThe word was " + "\"" + strWord + "\"" 
                            + "\nPress \"Restart\" to play again.", 
                            "Game Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        blnStartFlag = false;
                    }                    
                }
            }
            inputTextBox.Text = "";
            inputTextBox.Focus();
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            //Reset all componets
            inputTextBox.Text = "";
            hangmanPictureBox.Load("Capture0.png");
            startButton.Text = "Start";
            wordLabel.Text = "                                 ";
            blnStartFlag = false;
            topicLabel.Text = "";
            startButton.Enabled = true;
            inputTextBox.Enabled = false;
            guessListBox.Items.Clear();

            //Go back to choosing topic form
            objHangman = this;
            this.Hide();
            TopicForm.objTopic.Show();
            return;
 
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            //Show history form
            HistoryForm.objHistory.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Ask player if they want to go back to login page or exit app
            DialogResult result = MessageBox.Show("Go back to login page?", 
                "Exit Applicaiton", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            //Do corresponding choice action
            if(result == DialogResult.Yes)
            {
                ResetComponents();
                RecordNumOfGames();
                RecordLogoutTime();
                RecordScores();

                //Reset games played, win, and loss counter
                intGamesPlayed = 0;
                intWinCount = 0;
                intLossCount = 0;

                //Go back to login form and close history form
                this.Hide();
                HistoryForm.objHistory.Hide();
                LoginForm.objLogin.Show();
                return;
            }
            else if(result == DialogResult.No)
            {
                ResetComponents();
                RecordNumOfGames();
                RecordLogoutTime();
                RecordScores();

                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}