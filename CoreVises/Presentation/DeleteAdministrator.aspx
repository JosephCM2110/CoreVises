<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/base.Master" AutoEventWireup="true" CodeBehind="DeleteAdministrator.aspx.cs" Inherits="CoreVises.Presentation.DeleteAdministrator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPage" runat="server">
     <div id="page-wrapper">
        <div id="page-inner">
            <div class="row">
                <div class="col-md-12">
                    <h2>Delete Administrator</h2>
                </div>
            </div>
            <hr />
            <div class="row text-center pad-top">
                <form id="delete_Admin" runat="server">
                    <table style="width: 100%;">
                        
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="Name:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtName" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <br />
                            </td>
                            <td>
                                <asp:Label runat="server" Text="Name:"></asp:Label>
                                <br />
                                <asp:TextBox ID="TextBox1" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <br />
                            </td>

                        </tr>
                    </table>
                </form>
            </div>
        </div>

    </div>



</asp:Content>
