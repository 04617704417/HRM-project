<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master" AutoEventWireup="true"
    CodeFile="HRCompletRegistration.aspx.cs" Inherits="HRCompletRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content" />
    <div class="row1">
        <h1 class="title">
            <b><span>Welcome to online recruitment portal</span></b></h1>
        <table cellpadding="8" cellspacing="8" bgcolor="white">
            <tr>
                <td>
                    <h3>
                        successfull registeration
                    </h3>
                </td>
            </tr>
            <tr>
                <td>
                    <h4>
                        Hello Admin...! Congratulations. You have access to everything. You can add new
                        employee , delete employee and also you can make all the necessary changes that
                        would be required for maintenance or improvement of the website.
                    </h4>
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
</asp:Content>
