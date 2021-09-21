<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GamePage.aspx.cs" Inherits="GamePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			height: 777px;
		}
		.auto-style2 {
			width: 100%;
		}
		.auto-style3 {
			width: 281px;
		}
		.auto-style4 {
			width: 34px;
		}
		.auto-style7 {
			width: 17px;
		}
		.auto-style10 {
			width: 70px;
		}
		.auto-style11 {
			width: 150px;
		}
		.auto-style13 {
			width: 93px;
		}
		.auto-style14 {
			width: 85px;
		}
		.auto-style15 {
			margin-left: 0px;
		}
		.auto-style16 {
			width: 139px;
		}
		.auto-style17 {
			width: 188px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        &nbsp;<asp:Label ID="Label9" runat="server" Font-Size="15pt" Text="User:"></asp:Label>
&nbsp;
			<asp:Label ID="usernameLabel" runat="server" BorderColor="White" BorderStyle="Inset" Font-Size="15pt" ForeColor="Black" Width="133px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<br />
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="30pt" Text="Number Guesser (0 - 5)"></asp:Label>
			<br />
			<asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="20pt" Text="RULES:"></asp:Label>
			<br />
&nbsp;&nbsp;&nbsp; - Each player starts with 300 points<br />
&nbsp;&nbsp;&nbsp; - 1 wrong guess =&gt; minus 15 points&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<br />
&nbsp;&nbsp;&nbsp; - 1 correct guess =&gt; plus 20 points<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="startButton" runat="server" BackColor="#99CCFF" Font-Size="15pt" Height="47px" OnClick="startButton_Click" Text="Start" Width="118px" />
&nbsp;<asp:Image ID="hangmanImage" runat="server" Height="205px" ImageUrl="~/Image/questionmark.gif" Width="205px" />
			<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Label ID="msgLabel" runat="server" Font-Bold="True" Font-Size="20pt" ForeColor="Red"></asp:Label>
			<br />
			<br />
			<table class="auto-style2">
				<tr>
					<td class="auto-style7">&nbsp;</td>
					<td class="auto-style17">&nbsp;</td>
					<td class="auto-style11">&nbsp;</td>
					<td class="auto-style3">
						<asp:Label ID="Label2" runat="server" Font-Size="20pt" Text="Enter Number To Guess:"></asp:Label>
					</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style16">&nbsp;</td>
					<td class="auto-style14">&nbsp;</td>
					<td class="auto-style13">&nbsp;</td>
					<td class="auto-style10">&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style7">&nbsp;</td>
					<td class="auto-style17">&nbsp;</td>
					<td class="auto-style11">&nbsp;</td>
					<td class="auto-style3">
						<asp:TextBox ID="guessTextBox" runat="server" Font-Size="15pt" Width="118px" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;
						<asp:Button ID="submitButton" runat="server" BackColor="#99FFCC" Font-Size="15pt" Height="32px" OnClick="submitButton_Click" Text="Submit" Width="84px" Enabled="False" />
					</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style16">
						<asp:Label ID="Label5" runat="server" Font-Size="15pt" Text="Games Played:"></asp:Label>
					</td>
					<td class="auto-style14">
						<asp:Label ID="gamesLabel" runat="server" BackColor="#CC66FF" BorderStyle="Inset" ClientIDMode="Static" Font-Size="30pt" Height="43px" Text="0" Width="61px"></asp:Label>
					</td>
					<td class="auto-style13">&nbsp;</td>
					<td class="auto-style10">
						&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style7">&nbsp;</td>
					<td class="auto-style17">&nbsp;</td>
					<td class="auto-style11">&nbsp;</td>
					<td class="auto-style3">
						<asp:Label ID="Label11" runat="server" Font-Size="20pt" Text="Points:"></asp:Label>
					</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style16">&nbsp;</td>
					<td class="auto-style14">&nbsp;</td>
					<td class="auto-style13">&nbsp;</td>
					<td class="auto-style10">&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style7">&nbsp;</td>
					<td class="auto-style17">&nbsp;</td>
					<td class="auto-style11">&nbsp;</td>
					<td class="auto-style3">
						<asp:Label ID="pointsLabel" runat="server" Font-Size="15pt"></asp:Label>
					</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style16">
						<asp:Label ID="Label8" runat="server" Text="Wins:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:Label ID="Label7" runat="server" Text="Losses:"></asp:Label>
					</td>
					<td class="auto-style14">&nbsp;</td>
					<td class="auto-style13">&nbsp;</td>
					<td class="auto-style10">&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style7">&nbsp;</td>
					<td class="auto-style17">&nbsp;</td>
					<td class="auto-style11">&nbsp;</td>
					<td class="auto-style3">
						&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style16">
						<asp:Label ID="winLabel" runat="server" BackColor="#33CC33" BorderStyle="Inset" CssClass="auto-style15" Font-Size="25pt" Text="0"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:Label ID="lossLabel" runat="server" BackColor="Red" BorderStyle="Inset" Font-Size="25pt" Text="0"></asp:Label>
					</td>
					<td class="auto-style14">&nbsp;</td>
					<td class="auto-style13">
						<asp:Button ID="logoutButton" runat="server" BackColor="#FF6666" Font-Bold="True" Font-Size="20pt" Height="49px" OnClick="logoutButton_Click" Text="Logout" Width="115px" />
					</td>
					<td class="auto-style10">&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style7">&nbsp;</td>
					<td class="auto-style17">&nbsp;</td>
					<td class="auto-style11">&nbsp;</td>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style16">&nbsp;</td>
					<td class="auto-style14">&nbsp;</td>
					<td class="auto-style13">&nbsp;</td>
					<td class="auto-style10">&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style7">&nbsp;</td>
					<td class="auto-style17">&nbsp;</td>
					<td class="auto-style11">&nbsp;</td>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style16">&nbsp;</td>
					<td class="auto-style14">&nbsp;</td>
					<td class="auto-style13">&nbsp;</td>
					<td class="auto-style10">&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style7">&nbsp;</td>
					<td class="auto-style17">&nbsp;</td>
					<td class="auto-style11">&nbsp;</td>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style16">&nbsp;</td>
					<td class="auto-style14">&nbsp;</td>
					<td class="auto-style13">&nbsp;</td>
					<td class="auto-style10">&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style7">&nbsp;</td>
					<td class="auto-style17">&nbsp;</td>
					<td class="auto-style11">&nbsp;</td>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style16">&nbsp;</td>
					<td class="auto-style14">&nbsp;</td>
					<td class="auto-style13">&nbsp;</td>
					<td class="auto-style10">&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style7">&nbsp;</td>
					<td class="auto-style17">&nbsp;</td>
					<td class="auto-style11">&nbsp;</td>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style16">&nbsp;</td>
					<td class="auto-style14">&nbsp;</td>
					<td class="auto-style13">&nbsp;</td>
					<td class="auto-style10">&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
			</table>
        </div>
    </form>
</body>
</html>
