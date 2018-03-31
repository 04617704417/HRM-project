<%@ Page Title="" Language="C#" MasterPageFile="~/HRM.master"AutoEventWireup="true"
    CodeFile="Report.aspx.cs" Inherits="Report" %>

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
                    <asp:Menu ID="Menu1" runat="server" Font-Size="X-Large" Font-Bold="True" Font-Italic="True">
                        <Items>
                            <asp:MenuItem Text="Reports" Value="Reports">
                                <asp:MenuItem Text="Candidate Details" Value="Candidate Details" NavigateUrl="~/Report/DetailsOfCandidate .aspx">
                                </asp:MenuItem>
                                <asp:MenuItem Text="HR Details" Value="HR Details" NavigateUrl="~/Report/Details_Of_HR.aspx">
                                </asp:MenuItem>
                                <asp:MenuItem Text="Interview Schedules" Value="Interview Schedules" NavigateUrl="~/Report/List_of_Interview Schedules .aspx">
                                </asp:MenuItem>
                                <asp:MenuItem Text="Search Candidate Result" Value="Search Candidate Result" NavigateUrl="~/Report/Candidate_Search_Result.aspx">
                                </asp:MenuItem>
                                <asp:MenuItem Text="Selcted Or Rejected" Value="Selcted Or Rejected">
                                    <asp:MenuItem Text="Selected Candidat" Value="Selected Candidat" NavigateUrl="~/Report/List_of_Job_wise_Selected_Candidates.aspx">
                                    </asp:MenuItem>
                                    <asp:MenuItem Text="Rejected Candidat" Value="Rejected Candidat" NavigateUrl="~/Report/List_Of_Job_wise_Rejected_Candidates .aspx">
                                    </asp:MenuItem>
                                </asp:MenuItem>
                                <asp:MenuItem Text="Job Details" Value="New Item" NavigateUrl="~/Report/ListOfJobs.aspx">
                                </asp:MenuItem>
                                <asp:MenuItem Text="Email Alerts" Value="Email Alerts" NavigateUrl="~/Report/Status_Of_EmailAlerts.aspx">
                                </asp:MenuItem>
                                <asp:MenuItem Text="Trends Report" Value="Trends Report" NavigateUrl="~/Report/Trends_Reports.aspx">
                                </asp:MenuItem>
                                <asp:MenuItem NavigateUrl="~/Report/ListofEducationalDetails.aspx" Text="List of  Educational Details"
                                    Value="List of  Educational Details"></asp:MenuItem>
                            </asp:MenuItem>
                        </Items>
                    </asp:Menu>
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
