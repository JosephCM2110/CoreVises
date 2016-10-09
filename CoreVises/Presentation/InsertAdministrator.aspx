<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/base.Master" AutoEventWireup="true" CodeBehind="InsertAdministrator.aspx.cs" Inherits="CoreVises.Presentation.InsertAdministrator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPage" runat="server">
 <div id="page-wrapper">
        <div id="page-inner">
            <div class="row">
                <div class="col-md-12">
                    <h2>Create Administrator</h2>
                </div>
            </div>
            <hr />
            <div class="row text-center pad-top">
                <form id="create_Admin" runat="server">
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="Name:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtName" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <br />
                            </td>

                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="First Last Name:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtLastName_1" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <br />
                            </td>
                        </tr>
                         <tr>
                            <td>
                                <asp:Label runat="server" Text="Second Last Name:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtLastName_2" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="User Name:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtUserName" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="Password:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtPassword" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="Email:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtEmail" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnAccept" runat="server" Text="Accept" OnClick="btnAccept_Click" Height="49px" Width="485px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <br />
                                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label><br />
                            </td>
                        </tr>
                    </table>

                </form>
            </div>
        </div>

    </div>
</asp:Content>
