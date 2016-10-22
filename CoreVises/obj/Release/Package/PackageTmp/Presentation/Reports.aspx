<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/base.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="CoreVises.Presentation.Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPage" runat="server">
 <div id="page-wrapper">
        <div id="page-inner">
            <div class="row">
                <div class="col-md-12">
                    <h2>REPORTS</h2>
                </div>
            </div>
            <div class="row text-center pad-top">
                <form id="reports" runat="server">
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <br />
                                <asp:Button ID="btnClients" runat="server" OnClick="btnClients_Click" Text="Best Clients" Visible="true" Width="400px" Height="50" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <br />
                                <asp:Button ID="btnPhones" runat="server" OnClick="btnPhones_Click" Text="Top 5 Phones" Visible="true" Width="400px" Height="50"  />
                            </td>

                        </tr>
                    </table>
                </form>
            </div>
        </div>

    </div>
</asp:Content>


