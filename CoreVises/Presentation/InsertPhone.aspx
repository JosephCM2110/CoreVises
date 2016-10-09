<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/base.Master" AutoEventWireup="true" CodeBehind="InsertPhone.aspx.cs" Inherits="CoreVises.Presentation.InsertPhone" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPage" runat="server">
     <div id="page-wrapper">
        <div id="page-inner">
            <div class="row">
                <div class="col-md-12">
                    <h2>Create Phone</h2>
                </div>
            </div>
            <hr />
            <div class="row text-center pad-top">
                <form id="create_Phone" runat="server">
                    <table style="width: 100%;">
                         <tr>
                            <td>
                                <asp:Label runat="server" Text="Brand:"></asp:Label>
                                <br />
                                <asp:DropDownList ID="ddlBrand" runat="server" Height="27px" Width="485px">
                                </asp:DropDownList>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="Model:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtModel" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <br />
                            </td>

                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="Internal Memory:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtInternalMemory" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <br />
                            </td>
                        </tr>
                         <tr>
                            <td>
                                <asp:Label runat="server" Text="External Memory"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtExternalMemory" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="Pixels(Camera):"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtPixels" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <br />
                            </td>
                        </tr>
                         <tr>
                            <td>
                                <asp:Label runat="server" Text="Flash:"></asp:Label>
                                <br />
                                <asp:DropDownList ID="ddlFlash" runat="server" Height="27px" Width="485px">
                                    <asp:ListItem Value="1">Yes</asp:ListItem>
                                    <asp:ListItem Value="0">No</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="Resolution:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtResolution" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="Price:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtPrice" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <br />
                            </td>
                        </tr>
                         <tr>
                            <td>
                                <asp:Label runat="server" Text="Quantity:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtQuantity" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
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
