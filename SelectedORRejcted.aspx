<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true"
    CodeFile="SelectedORRejcted.aspx.cs" Inherits="SelectedORRejcted" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content">
        <div class="row1">
            <h1 class="title">
                <b><span>Welcome to online recruitment portal</span></b></h1>
            <table border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td align="center">
                        <h1>
                            Selected/Rejected
                        </h1>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <br />
                        <br />
                        <asp:Label ID="Label_Status" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="Large">For Other Query and Clarification Contact Our HR Department</asp:Label>
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
    </div>
</asp:Content>
