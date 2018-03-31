<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HRM.master" CodeFile="SelactedCandidat.aspx.cs"
    Inherits="SelactedCandidat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div class="content">
            <div class="row1">
                <h1 class="title">
                    <b><span>Welcome to online recruitment portal</span></b></h1>
                <table cellpadding="8" cellspacing="8" bgcolor="white">
                    <tr>
                        <td colspan="2">
                            <h1>
                                Selacted Candidate
                            </h1>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Conversion ID"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="Text_Conversion_ID" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Job ID"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="Text_Job_ID" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="HR Name"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList_HRName" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Candidate ID"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="Text_Candidate_ID" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Date of Joining"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="Text_Date_of_Joining" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Reporting Hanger"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="Text_Reporting_Hanger" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" Text="Nature of Hiring"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="Text_Nature_of_Hiring" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label9" runat="server" Text="Offer Letter issue"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="Text_Offer_Letter_issue" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text="Joining Status"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="Text_Joining_Status" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" Style="height: 26px" />
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
