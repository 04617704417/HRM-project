<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jobtable.aspx.cs" MasterPageFile="~/HRM.master"
    Inherits="jobtable" %>

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
                            Job Details
                        </h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Tittle"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_Tittle" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_Description" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="NO of vacancies"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_NOofvacancies" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Skill Req 1"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_Skill_Req_1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Skill Req 2"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_Skill_Req_2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Skill Req 3"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_Skill_Req_3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Last date of apply"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_Last_date_of_apply" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Date of Interview"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_Date_of_Interview" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="Location of Interview"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Text_Location_of_Interview" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Reset" OnClick="Button2_Click" />
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
