<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master"AutoEventWireup="true"
    CodeFile="CommonRegistration.aspx.cs" Inherits="CommonRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content">
        <div class="row1">
            <h1 class="title">
                <b><span>Welcome to online recruitment portal</span></b></h1>
            <h2 class="subtitle">
                <span>Registration by </span>
            </h2>
            <table width="100%" align="center" cellpadding="8" cellspacing="8" bgcolor="white">
                <tr>
                    <td>
                        <h3>
                            USER REGISTRATION
                        </h3>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button_UserRegistration" runat="server" Text="User Registration"
                            OnClick="Button_UserRegistration_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <h3>
                            HR REGISTRATION
                        </h3>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button_HrRegistration" runat="server" Text="HR Registration" OnClick="Button_HrRegistration_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
