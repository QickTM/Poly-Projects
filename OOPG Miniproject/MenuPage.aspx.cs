using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Menu_Page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void loginButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("LoginPage.aspx");
    }

    protected void scoreButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("ScoreBoard.aspx");
    }

    protected void mainButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("MainPage.aspx");
    }
}