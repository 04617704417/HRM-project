<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master"AutoEventWireup="true"
    CodeFile="UpdateYourDetails.aspx.cs" Inherits="UpdateYourDetails" %>

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
                            Update Your Profile
                        </h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_Name" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please insert your name"
                            ControlToValidate="Text_Name"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text=" contact No"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_Contact" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Email Id"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_Email_ID" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please insert your Correct email Id"
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="Text_Email_ID"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="D.O.B"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_DOB" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="RadioButton_Gender" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Add"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_Add" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <div class="content-right">
            <div class="mainmenu">
                <h2 class="sidebar1">
                    Main Menu</h2>
                <asp:Panel ID="Panel1" runat="server" Visible="true">
                    <ul>
                        <li><a href="EducationalDetails.aspx">Educational Details </a></li>
                        <li><a href="UploadResume.aspx">Upload Resume And Photo</a></li>
                        <li><a href="JobDetals.aspx">View Jobs</a></li>
                        <li><a href="Interview_status.aspx">Interview status</a></li>
                        <li><a href="ViewYourProfile.aspx">View Your Profile</a></li>
                        <li><a href="UpdateYourDetails.aspx">Update Your Profile</a></li>
                        <li><a href="SelectedORRejcted.aspx">Result</a></li>
                        <li><a href="JoiningProcess.aspx">Joining Process</a></li>
                        <li><a href="ChangePassword.aspx">Change Password</a></li>
                        <li>
                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Log out</asp:LinkButton></li>
                    </ul>
                </asp:Panel>
            </div>
            <div class="contact">
                <h2 class="sidebar2">
                    Feedback</h2>
                <div class="contact-detail">
                    <p class="green">
                        <strong>We will like to know your feedback kindly mail your suggestion to the given
                            Email-id.</strong></p>
                    <p>
                        <strong>E-mail : </strong>Abhib842@gmail.com</p>
                    <p>
                        <strong>Phone : </strong>919289821281<br />
                    </p>
                    <p>
                        <strong></strong>Please share your reviews with us.<br />
                    </p>
                </div>
            </div>
        </div>
</asp:Content>
