<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdatePage.aspx.cs" Inherits="UpdatePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			height: 639px;
		}
		.auto-style2 {
			width: 100%;
		}
		.auto-style3 {
			width: 294px;
		}
		.auto-style4 {
			width: 123px;
		}
		.auto-style5 {
			width: 66px;
		}
		.auto-style6 {
			margin-left: 43px;
		}
		.auto-style7 {
			margin-left: 11px;
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
					<td>&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style3">
						<asp:Label ID="Label1" runat="server" ClientIDMode="Static" Font-Bold="True" Font-Size="30pt" Text="Forgot Password"></asp:Label>
					</td>
					<td class="auto-style5">&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style5">&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style4">
						<asp:Label ID="Label2" runat="server" Text="Username:"></asp:Label>
					</td>
					<td class="auto-style3">
						<asp:TextBox ID="usernameTextBox" runat="server" Width="280px" Font-Size="15pt"></asp:TextBox>
					</td>
					<td class="auto-style5">&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style4">
						<asp:Label ID="Label3" runat="server" Text="New Password:"></asp:Label>
					</td>
					<td class="auto-style3">
						<asp:TextBox ID="passwordTextBox" runat="server" Width="280px" Font-Size="15pt"></asp:TextBox>
					</td>
					<td class="auto-style5">
						<asp:Button ID="updateButton" runat="server" CssClass="auto-style7" Font-Size="15pt" OnClick="updateButton_Click" Text="Update Password" Width="204px" />
					</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style5">&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style3">
						<asp:Label ID="msgLabel" runat="server" BackColor="White" BorderColor="White" BorderStyle="Inset" ForeColor="Red" Height="20px" Width="280px"></asp:Label>
					</td>
					<td class="auto-style5">&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style5">&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style3">
						<asp:Button ID="backButton" runat="server" CssClass="auto-style6" Font-Size="15pt" Text="Back To Login" Width="211px" OnClick="backButton_Click" />
					</td>
					<td class="auto-style5">&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style5">&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td class="auto-style4">&nbsp;</td>
					<td class="auto-style3">&nbsp;</td>
					<td class="auto-style5">&nbsp;</td>
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
