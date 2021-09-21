<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUpPage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			height: 632px;
		}
		.auto-style2 {
			width: 100%;
		}
		.auto-style4 {
			width: 347px;
		}
		.auto-style5 {
			width: 74px;
		}
		.auto-style6 {
			height: 23px;
		}
		.auto-style7 {
			width: 74px;
			height: 23px;
		}
		.auto-style8 {
			width: 347px;
			height: 23px;
		}
		.auto-style9 {
			width: 260px;
		}
		.auto-style10 {
			width: 260px;
			height: 23px;
		}
		.auto-style11 {
			margin-left: 11px;
		}
		.auto-style12 {
			margin-left: 53px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        	<table class="auto-style2">
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style9">&nbsp;</td>
					<td class="auto-style5">&nbsp;</td>
					<td class="auto-style4">
						<asp:Label ID="Label1" runat="server" ClientIDMode="Static" Font-Bold="True" Font-Size="30pt" Text="Create An Account"></asp:Label>
					</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style9">&nbsp;</td>
					<td class="auto-style5">&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style6"></td>
					<td class="auto-style6"></td>
					<td class="auto-style10"></td>
					<td class="auto-style7">Username:</td>
					<td class="auto-style8">
						<asp:TextBox ID="nameTextBox" runat="server" ClientIDMode="Static" Font-Size="15pt" Width="330px"></asp:TextBox>
					</td>
					<td class="auto-style6"></td>
					<td class="auto-style6"></td>
					<td class="auto-style6"></td>
					<td class="auto-style6"></td>
					<td class="auto-style6"></td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style9">&nbsp;</td>
					<td class="auto-style5">Password:</td>
					<td class="auto-style4">
						<asp:TextBox ID="passwordTextBox" runat="server" ClientIDMode="Static" Font-Size="15pt" Width="330px"></asp:TextBox>
					</td>
					<td>
						<asp:Button ID="submitButton" runat="server" ClientIDMode="Static" CssClass="auto-style11" Font-Size="15pt" Height="37px" OnClick="submitButton_Click" Text="Submit" Width="89px" />
					</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style9">&nbsp;</td>
					<td class="auto-style5">&nbsp;</td>
					<td class="auto-style4">
						<asp:Label ID="msgLabel" runat="server" BorderStyle="Ridge" ClientIDMode="Static" Font-Size="15pt" Width="330px" BorderColor="White" ForeColor="Red"></asp:Label>
					</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style9">&nbsp;</td>
					<td class="auto-style5">&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style9">&nbsp;</td>
					<td class="auto-style5">&nbsp;</td>
					<td class="auto-style4">
						<asp:Button ID="returnButton" runat="server" ClientIDMode="Static" CssClass="auto-style12" Font-Size="15pt" Height="40px" Text="Return to Login Page" Width="224px" OnClick="returnButton_Click" />
					</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style9">&nbsp;</td>
					<td class="auto-style5">&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style9">&nbsp;</td>
					<td class="auto-style5">&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style9">&nbsp;</td>
					<td class="auto-style5">&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
			</table>
        </div>
    </form>
</body>
</html>
