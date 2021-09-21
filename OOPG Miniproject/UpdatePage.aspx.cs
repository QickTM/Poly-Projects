using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class UpdatePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    SqlDataReader dR;
    DataBase dB = new DataBase();

    private void ClearItems()
    {
        //Clear text boxes
        usernameTextBox.Text = "";
        passwordTextBox.Text = "";
        msgLabel.Text = "";
    }

    protected void updateButton_Click(object sender, EventArgs e)
    {
        string strNewPassword = passwordTextBox.Text;
        string strUsername = usernameTextBox.Text;

        //Check for blank text boxes
        if (usernameTextBox.Text == "")
        {
            msgLabel.Text = "*Please enter User ID!";
            usernameTextBox.Focus();
        }
        else if (passwordTextBox.Text == "")
        {
            msgLabel.Text = "*Please enter new Password!";
            passwordTextBox.Focus();
        }
        else
        {
            string updStr = "UPDATE UserTable SET Password = '" + strNewPassword + "' WHERE Username = '" + strUsername + "'";
            dB.ExecuteNonQuery(updStr);
            msgLabel.Text = "Password updated.";
            ClearItems();
        }
    }

    protected void backButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("LoginPage.aspx");
    }
}