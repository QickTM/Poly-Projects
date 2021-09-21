using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    SqlDataReader dataReader;
    DataBase userDb = new DataBase();
    UserClass user;

    protected void submitButton_Click(object sender, EventArgs e)
    {

        //Check for blank TextBox.Text
        if (nameTextBox.Text == "")
        {
            msgLabel.Text = "*Please enter \"User ID\"";
            nameTextBox.Focus();
        }
        else if (passwordTextBox.Text == "")
        {
            msgLabel.Text = "*Please enter \"Password\"";
            passwordTextBox.Focus();
        }
        else
        {
            //Create new object to be added into database
            user = new UserClass(nameTextBox.Text, passwordTextBox.Text);

            string insertStr = "INSERT INTO UserTable ([Username], [Password], [GamesPlayed], [Points]) "
                + "VALUES ('" + user.Username.ToString() + "', '" + user.Password.ToString() + "', 0, 300)";
            msgLabel.Text = "User created.";

            userDb.ExecuteNonQuery(insertStr);

            //Clear textboxes
            nameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }

    protected void returnButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("LoginPage.aspx");
    }
}