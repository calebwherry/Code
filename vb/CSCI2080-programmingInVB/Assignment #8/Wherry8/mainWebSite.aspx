<%@ Page Language="VB" AutoEventWireup="false" CodeFile="mainWebSite.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="#33ff99">
    <form id="form1" runat="server">
    <div>
        <br />
        <asp:Label ID="titleLabel" runat="server" BackColor="Transparent" Font-Bold="True"
            Font-Italic="True" Font-Size="40pt" ForeColor="Black" Text="New Customer Information"></asp:Label><br />
        <br />
        <br />
        <br />
        <asp:Label ID="messageLabel" runat="server"></asp:Label><br />
        <br />
        <table>
            <tr>
                <td style="width: 121px; height: 21px">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Name:</td>
                <td style="width: 144px; height: 21px">
                    <asp:TextBox ID="nameTextBox" runat="server" Width="240px"></asp:TextBox></td>
                <td style="width: 144px; height: 21px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nameTextBox"
                        ErrorMessage="Please Enter A Name!"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 121px; height: 25px">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; E-Mail:</td>
                <td style="width: 144px; height: 25px">
                    <asp:TextBox ID="emailTextBox" runat="server" Width="240px"></asp:TextBox></td>
                <td style="width: 144px; height: 25px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="emailTextBox"
                        ErrorMessage="Please Enter An E-Mail!" Width="152px"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 121px">
                </td>
                <td style="width: 144px">
                </td>
                <td style="width: 144px">
                </td>
            </tr>
            <tr>
                <td style="width: 121px; height: 26px">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Username:</td>
                <td style="width: 144px; height: 26px">
                    <asp:TextBox ID="usernameTextBox" runat="server" Width="240px"></asp:TextBox></td>
                <td style="width: 144px; height: 26px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="usernameTextBox"
                        ErrorMessage="Username required!" Width="160px"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 121px">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Password:</td>
                <td style="width: 144px">
                    <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" Width="240px"></asp:TextBox></td>
                <td style="width: 144px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="passwordTextBox"
                        ErrorMessage="Password Required!" Width="168px"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 121px; height: 26px">
                    Confirm Password:</td>
                <td style="width: 144px; height: 26px">
                    <asp:TextBox ID="confirmPasswordTextBox" runat="server" TextMode="Password" Width="240px"></asp:TextBox></td>
                <td style="width: 144px; height: 26px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="confirmPasswordTextBox"
                        ErrorMessage="Please Confirm Password!" Width="232px"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 121px; height: 21px">
                </td>
                <td style="width: 144px; height: 21px">
                </td>
                <td style="width: 144px; height: 21px">
                </td>
            </tr>
            <tr>
                <td style="width: 121px; height: 21px">
                </td>
                <td style="width: 144px; height: 21px">
                    <asp:Button ID="submitButton" runat="server" Text="Submit" /></td>
                <td style="width: 144px; height: 21px">
                </td>
            </tr>
        </table>
        &nbsp; &nbsp; &nbsp;&nbsp;<br />
        <br />
        <div style="text-align: right">
            &nbsp;</div>
    </div>
    </form>
</body>
</html>
