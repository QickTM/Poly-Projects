using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class GamePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        usernameLabel.Text = Session["Username"].ToString();
        string selStr = "SELECT Points FROM UserTable WHERE Username = '" + usernameLabel.Text + "'";
        dataReader = dB.ExecuteReader(selStr);
        if (dataReader.Read())
        {
            intPoints = int.Parse(dataReader["Points"].ToString());
            pointsLabel.Text = intPoints.ToString();
        }
        dataReader.Close();
    }

    SqlDataReader dataReader;
    DataBase dB = new DataBase();
    static int intGamesPlayed, intWinCount, intLossCount, intPoints, totalGames;
    int userGames;
    static int numberToGuess;
    bool blnSuccess;

    private int GetNumber()
    {
        //Get random number
        double dbValue;
        Random ranObj = new Random();
        dbValue = ranObj.NextDouble();
        return ((int)(5 * dbValue));
    }

    private void CountGamesPlayed()
    {
        //Count number of games played, and display on gamesNumLabel
        intGamesPlayed++;
        gamesLabel.Text = intGamesPlayed.ToString();
    }    

    private bool CheckValidInput(int intInput)
    {
        if (intInput >= 0 && intInput <= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void DisableInput()
    {
        guessTextBox.Enabled = false;
        submitButton.Enabled = false;
    }

    private void EnableInput()
    {
        guessTextBox.Enabled = true;
        submitButton.Enabled = true;
    }

    private void RecordGames()
    {
        //Get previous number of games
        string selStr = "SELECT GamesPlayed FROM UserTable WHERE Username = '" + usernameLabel.Text + "'";
        dataReader = dB.ExecuteReader(selStr);
        if (dataReader.Read())
        {
            userGames = int.Parse(dataReader["GamesPlayed"].ToString());
            totalGames = userGames;
        }
        dataReader.Close();

        //Add to the older number of games
        totalGames = userGames + intGamesPlayed;

        //Record and update new numebr of games
        string upGamesStr = "UPDATE UserTable SET GamesPlayed = "
            + totalGames + " WHERE Username = '" + usernameLabel.Text + "'";
        dB.ExecuteNonQuery(upGamesStr);
    }

    private void UpdatePoints()
    {
        //Update the amount of points the player has
        string updStr = "UPDATE UserTable SET Points = " 
            + intPoints + " WHERE Username = '" + usernameLabel.Text + "'";
        dB.ExecuteNonQuery(updStr);
    }

    protected void startButton_Click(object sender, EventArgs e)
    {
        guessTextBox.Enabled = true;
        submitButton.Enabled = true;
        msgLabel.Text = "Game started. Try to guess the number.";
        numberToGuess = GetNumber();
        //numberLabel.Text = numberToGuess.ToString(); [for demonstration]

        CountGamesPlayed();
        EnableInput();

        startButton.Enabled = false;
    }

    protected void submitButton_Click(object sender, EventArgs e)
    {
        int intTemp = 0;
        try//check if input is a number or not
        {
            intTemp = int.Parse(guessTextBox.Text);
        }
        catch
        {
            msgLabel.Text = "Please enter a number!";
        }

        blnSuccess = CheckValidInput(intTemp);
        if (blnSuccess == false)//check for number and output corresponding hints
        {
            msgLabel.Text = "Invalid input";
        }
        else if (blnSuccess == true)
        {
            if (guessTextBox.Text == numberToGuess.ToString())
            {
                intPoints = intPoints + 20;
                msgLabel.Text = "You guessed correctly. Here is 20 points";
                intWinCount++;
            }
            else
            {
                intLossCount++;
                if (intPoints >= 0)
                {
                    msgLabel.Text = "You guessed wrongly. Deduct 15 points";
                    intPoints = intPoints - 15;
                }
            }

            guessTextBox.Text = "";
            startButton.Focus();

            //Display wins, losses, points
            winLabel.Text = intWinCount.ToString();
            lossLabel.Text = intLossCount.ToString();
            pointsLabel.Text = intPoints.ToString();

            DisableInput();
            UpdatePoints();

            startButton.Enabled = true;
            startButton.Text = "Play Again";
        }
    }

    protected void logoutButton_Click(object sender, EventArgs e)
    {
        RecordGames();
        intGamesPlayed = 0;
        intLossCount = 0;
        intWinCount = 0;
        totalGames = 0;
        userGames = 0;
        Response.Redirect("MenuPage.aspx");
    }
}