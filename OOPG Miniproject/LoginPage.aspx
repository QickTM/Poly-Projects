<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="Login_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			height: 672px;
		}
		.auto-style2 {
			width: 100%;
		}
		.auto-style3 {
			width: 87px;
		}
		.auto-style4 {
			width: 87px;
			height: 23px;
		}
		.auto-style5 {
			height: 23px;
		}
		.auto-style6 {
			width: 326px;
		}
		.auto-style7 {
			height: 23px;
			width: 326px;
		}
		.auto-style8 {
			width: 75px;
		}
		.auto-style9 {
			width: 75px;
			height: 23px;
		}
		.auto-style10 {
			width: 351px;
		}
		.auto-style11 {
			height: 23px;
			width: 351px;
		}
		.auto-style12 {
			margin-left: 52px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        	<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="30pt" Text="Login Page"></asp:Label>
			<br />
			<table class="auto-style2">
				<tr>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style6">&nbsp;</td>
					<td class="auto-style8">&nbsp;</td>
					<td class="auto-style10">&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style7"></td>
					<td class="auto-style9">Username:</td>
					<td class="auto-style11">
						<asp:TextBox ID="nameTextBox" runat="server" Font-Size="15pt" Width="270px"></asp:TextBox>
					</td>
					<td class="auto-style5"></td>
				</tr>
				<tr>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style6">&nbsp;</td>
					<td class="auto-style8">Password:</td>
					<td class="auto-style10">
						<asp:TextBox ID="passwordTextBox" runat="server" Font-Size="15pt" Width="270px"></asp:TextBox>
					</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style6">&nbsp;</td>
					<td class="auto-style8">&nbsp;</td>
					<td class="auto-style10">
						<asp:Label ID="msgLabel" runat="server" BorderStyle="Ridge" ClientIDMode="Static" Font-Size="15pt" Width="270px" BorderColor="White" ForeColor="#CC0000"></asp:Label>
					</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style6">&nbsp;</td>
					<td class="auto-style8">&nbsp;</td>
					<td class="auto-style10">
						<asp:Button ID="loginButton" runat="server" ClientIDMode="Static" Font-Size="15pt" Height="36px" OnClick="loginButton_Click" Text="Login" Width="80px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:Button ID="signUpButton" runat="server" ClientIDMode="Static" Font-Size="15pt" Height="36px" OnClick="signUpButton_Click" Text="Sign Up" Width="86px" />
					</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style6">&nbsp;</td>
					<td class="auto-style8">&nbsp;</td>
					<td class="auto-style10">&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style6">&nbsp;</td>
					<td class="auto-style8">&nbsp;</td>
					<td class="auto-style10">
						&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:Button ID="forgotButton" runat="server" ClientIDMode="Static" Font-Size="15pt" Height="43px" Text="Forgot Password" Width="176px" OnClick="forgotButton_Click" />
					</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style6">&nbsp;</td>
					<td class="auto-style8">&nbsp;</td>
					<td class="auto-style10">
						<asp:Button ID="backButton" runat="server" CssClass="auto-style12" Font-Size="15pt" Height="43px" OnClick="backButton_Click" Text="Back To Menu" Width="176px" />
					</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style6">&nbsp;</td>
					<td class="auto-style8">&nbsp;</td>
					<td class="auto-style10">&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
			</table>
			<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
