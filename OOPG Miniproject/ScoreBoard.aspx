<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ScoreBoard.aspx.cs" Inherits="ScoreBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			height: 671px;
		}
		.auto-style2 {
			margin-left: 0px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        	<br />
&nbsp;&nbsp;
			<br />
			<br />
			<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Label ID="Label1" runat="server" Font-Size="30pt" Text="Leaderboard (Points)"></asp:Label>
			<br />
&nbsp;<asp:GridView ID="leaderboardGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="304px" Width="675px" Font-Size="20pt">
				<AlternatingRowStyle BackColor="White" BorderColor="Black" ForeColor="#284775" />
				<EditRowStyle BackColor="#999999" />
				<FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
				<HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
				<PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
				<RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
				<SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
				<SortedAscendingCellStyle BackColor="#E9E7E2" />
				<SortedAscendingHeaderStyle BackColor="#506C8C" />
				<SortedDescendingCellStyle BackColor="#FFFDF8" />
				<SortedDescendingHeaderStyle BackColor="#6F8DAE" />
			</asp:GridView>
			<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Button ID="refreshButton" runat="server" Font-Bold="True" Font-Size="15pt" Height="49px" OnClick="refreshButton_Click" Text="Refresh" Width="167px" CssClass="auto-style2" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Button ID="backButton" runat="server" Font-Bold="True" Font-Size="15pt" Height="49px" OnClick="backButton_Click" Text="Back To Menu" Width="154px" />
        </div>
    </form>
</body>
</html>
