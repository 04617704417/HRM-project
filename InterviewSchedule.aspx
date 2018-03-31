<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master"AutoEventWireup="true"
    CodeFile="InterviewSchedule.aspx.cs" Inherits="InterviewSchedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content">
        <div class="row1">
            <h1 class="title">
                <b><span>Welcome to online recruitment portal</span></b></h1>
            <table cellpadding="8" cellspacing="8" bgcolor="white">
                <tr>
                    <td align="center">
                        <h1>
                            Interview Schedule
                        </h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="User ID"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddluser" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="HR ID"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_HRId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Date Time :-"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_Date" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr align="center">
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
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
                        <li><a href="Report.aspx">Reports</a></li>
                        <li><a href="Search_Candidates_Process.aspx">Search Candidates</a></li>
                        <li><a href="InterviewSchedule.aspx">Interview Schedule </a></li>
                        <li><a href="Jobhiringdetails.aspx">Jobhiring details</a></li>
                        <li><a href="jobtable.aspx">job table</a></li>
                        <li><a href="MailAlert.aspx">Mail Alert</a></li>
                        <li><a href="RejactedCandidat.aspx">Rejacted Candidat</a></li>
                        <li><a href="SelactedCandidat.aspx">Selacted Candidat</a></li>
                        <li><a href="JobOfferLetter/job_offer_letter.doc" target="_blank">Download Offer Letter</a></li>
                        <li><a href="ChangePassword.aspx">Change Password</a></li>
                        <li><a href="Home.aspx">Log Out</a></li>
                    </ul>
                </asp:Panel>
            </div>
        </div>
    </div>
</asp:Content>
