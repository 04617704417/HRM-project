<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HRM.master" CodeFile="Search_Candidates_Process.aspx.cs"
    Inherits="Search_Candidates_Process" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content">
        <div class="row1">
            <h1 class="title">
                <b><span>Welcome to online recruitment portal</span></b></h1>
            <table cellpadding="8" cellspacing="8">
                <tr>
                    <td colspan="2">
                        <h1>
                            Search Candidates Process
                        </h1>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Label ID="Label2" runat="server" Text="Qualification"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:CheckBox ID="CheckBox_10" Text="10th" runat="server" />
                        <asp:CheckBox ID="CheckBox_12" Text="12th" runat="server" />
                        <asp:CheckBox ID="CheckBox_grad" Text="Gruaduation" runat="server" />
                        <asp:CheckBox ID="CheckBox_Pstgrad" Text="Post Gruaduation" runat="server" />
                        <asp:CheckBox ID="CheckBox_Certificate" Text="Certificate" runat="server" />
                        <asp:CheckBox ID="CheckBox_Additional" Text="Additional(if any)" runat="server" />
                    </td>
                </tr>
                <tr align="center">
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Reset" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:GridView ID="grid1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84"
                            BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#FFF1D4" />
                            <SortedAscendingHeaderStyle BackColor="#B95C30" />
                            <SortedDescendingCellStyle BackColor="#F1E5CE" />
                            <SortedDescendingHeaderStyle BackColor="#93451F" />
                        </asp:GridView>
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
