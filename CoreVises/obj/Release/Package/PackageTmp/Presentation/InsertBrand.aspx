<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/base.Master" AutoEventWireup="true" CodeBehind="InsertBrand.aspx.cs" Inherits="CoreVises.Presentation.InsertBrand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPage" runat="server">
     <div id="page-wrapper">
        <div id="page-inner">
            <div class="row">
                <div class="col-md-12">
                    <h2>Create Brand</h2>
                </div>
            </div>
            <div class="row text-center pad-top">
                <form id="create_Brand" runat="server">
                     <table style="width: 100%;">
                       <tr>
                            <td>
                                <br />
                                <asp:Label ForeColor="Red"  ID="lblMessage" runat="server" Text=""></asp:Label><br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="Name:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtName" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <asp:RequiredFieldValidator ID="emptyName" runat="server" 
                                    ControlToValidate="txtName" Display="Dynamic" Text="*empty field" ForeColor="Red">
                                </asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="txtNameEx" runat="server" ErrorMessage="You can only write letters"
                                    ControlToValidate="txtName" ValidationExpression="^[a-zA-Z\s]*$" ForeColor="Red" Display="Dynamic">
                                </asp:RegularExpressionValidator>
                                <br />
                            </td>

                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnAccept" runat="server" Text="Accept" OnClick="btnAccept_Click" Height="49px" Width="485px" />
                            </td>
                        </tr>

                    </table>

                </form>
            </div>
        </div>

    </div>


</asp:Content>
