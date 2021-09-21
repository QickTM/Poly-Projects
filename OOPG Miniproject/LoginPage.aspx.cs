using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Login_Page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    SqlDataReader dataReader;
    DataBase userDb = new DataBase();

    protected void loginButton_Click(object sender, EventArgs e)
    {
        //Check for correct User ID, if not then notify user of wrong Username
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
            //Find user in data base wit hsame "Username"
            string selStr = "SELECT Password FROM UserTable WHERE Username = '" + nameTextBox.Text + "'";
            dataReader = userDb.ExecuteReader(selStr);
            if (dataReader.Read())
            {
                //Check to see if the "Password" is correct
                string strPassword = dataReader["Password"].ToString();
                if (passwordTextBox.Text == strPassword)
                {
                    Session["Username"] = nameTextBox.Text;
                    nameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    Response.Redirect("GamePage.aspx");
                }
                else
                {
                    msgLabel.Text = "Wrong Password";
                }
            }
            else
            {
                msgLabel.Text = "User does not exist. \nPlease Sign-Up.";
            }
            dataReader.Close();
        }
    }

    protected void signUpButton_Click(object sender, EventArgs e)
    {
        //Bring user to SignUpPage
        Response.Redirect("SignUpPage.aspx");
    }

    protected void forgotButton_Click(object sender, EventArgs e)
    {
        //Bring user to UpdatePage
        Response.Redirect("UpdatePage.aspx");
    }

    protected void backButton_Click(object sender, EventArgs e)
    {
        //Back to MenuPage
        Response.Redirect("MenuPage.aspx");
    }
}