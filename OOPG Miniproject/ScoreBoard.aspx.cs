using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class ScoreBoard : System.Web.UI.Page
{
    DataBase dB = new DataBase();
    SqlDataReader dR;

    string selStr = "SELECT Username, GamesPlayed, Points FROM UserTable ORDER BY Points desc";

    protected void Page_Load(object sender, EventArgs e)
    {
        dR = dB.ExecuteReader(selStr);
        leaderboardGridView.DataSource = dR;
        leaderboardGridView.DataBind();
        dR.Close();
    }

    protected void refreshButton_Click(object sender, EventArgs e)
    {
        dR = dB.ExecuteReader(selStr);
        leaderboardGridView.DataSource = dR;
        leaderboardGridView.DataBind();
        dR.Close();
    }

    protected void backButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("MenuPage.aspx");
    }
}