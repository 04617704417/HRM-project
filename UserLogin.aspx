<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserLogin.aspx.cs" MasterPageFile="~/HRM.master"
    Inherits="UserLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content">
        <div class="row1">
            <h1 class="title">
                <b><span>Welcome to online recruitment portal</span></b></h1>
            <table cellpadding="8" cellspacing="8" bgcolor="white">
                <tr>
                    <td colspan="2">
                        <h1>
                            User login
                        </h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text=" Refrence ID"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_User_Id" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Test_Password" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Login as"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Applicant</asp:ListItem>
                            <asp:ListItem>HR Admin</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr align="center">
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Sing in" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
