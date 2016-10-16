<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/base.Master" AutoEventWireup="true" CodeBehind="InsertPhone.aspx.cs" Inherits="CoreVises.Presentation.InsertPhone" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPage" runat="server">
     <div id="page-wrapper">
        <div id="page-inner">
            <div class="row">
                <div class="col-md-12">
                    <h2>Create Phone</h2>
                </div>
            </div>
            <div class="row text-center pad-top">
                <form id="create_Phone" runat="server">
                       <table style="width: 100%;">
                        <tr>
                            <td>
                                <br />
                                <asp:Label ForeColor="Red"  ID="lblMessage" runat="server" Text=""></asp:Label><br />
                            </td>
                        </tr>
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
                                <asp:RequiredFieldValidator ID="emptyModel" runat="server" 
                                    ControlToValidate="txtModel" Display="Dynamic" Text="*empty field" ForeColor="Red">
                                </asp:RequiredFieldValidator>
                                <br />
                            </td>
                        </tr>
                        <tr>
                             <td>
                                <asp:Label runat="server" Text="OS:"></asp:Label>
                                <br />
                                 <asp:DropDownList ID="ddlOs" runat="server">
                                    <asp:ListItem Value="IOS">IOS</asp:ListItem>
                                    <asp:ListItem Value="Android">Android</asp:ListItem>
                                    <asp:ListItem Value="Windows">Windows</asp:ListItem>
                                 </asp:DropDownList>
                                <br />
                            </td>
                        </tr>
                        <tr>
                             <td>
                                <asp:Label runat="server" Text="Netwok Mode:"></asp:Label>
                                <br />
                                 <asp:DropDownList ID="ddlNet" runat="server">
                                     <asp:ListItem Value="3G">3G</asp:ListItem>
                                    <asp:ListItem Value="4G">4G</asp:ListItem>
                                 </asp:DropDownList>
                                 
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="Internal Memory:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtInternalMemory" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <asp:RequiredFieldValidator ID="emptyInternalMemory" runat="server" 
                                    ControlToValidate="txtInternalMemory" Display="Dynamic" Text="*empty field" ForeColor="Red">
                                </asp:RequiredFieldValidator>
                                <br />
                            </td>
                        </tr>
                         <tr>
                            <td>
                                <asp:Label runat="server" Text="External Memory"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtExternalMemory" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <asp:RequiredFieldValidator ID="emptyExternalMemory" runat="server" 
                                    ControlToValidate="txtExternalMemory" Display="Dynamic" Text="*empty field" ForeColor="Red">
                                </asp:RequiredFieldValidator>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="Pixels(Camera):"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtPixels" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <asp:RequiredFieldValidator ID="emptyPixels" runat="server" 
                                    ControlToValidate="txtPixels" Display="Dynamic" Text="*empty field" ForeColor="Red">
                                </asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="txtP" runat="server" ErrorMessage="You can only type numbers"
                                    ControlToValidate="txtPixels" ValidationExpression="^\d+$" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
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
                                <asp:RequiredFieldValidator ID="emptyResolution" runat="server" 
                                    ControlToValidate="txtResolution" Display="Dynamic" Text="*empty field" ForeColor="Red">
                                </asp:RequiredFieldValidator>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="Price:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtPrice" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <asp:RequiredFieldValidator ID="emptyPrice" runat="server" 
                                    ControlToValidate="txtPrice" Display="Dynamic" Text="*empty field" ForeColor="Red">
                                </asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="txtPr" runat="server" ErrorMessage="You can only type numbers"
                                    ControlToValidate="txtPrice" ValidationExpression="^^\d+$" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                                <br />
                            </td>
                        </tr>
                         <tr>
                            <td>
                                <asp:Label runat="server" Text="Quantity:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtQuantity" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <asp:RequiredFieldValidator ID="emptyQuantity" runat="server" 
                                    ControlToValidate="txtQuantity" Display="Dynamic" Text="*empty field" ForeColor="Red">
                                </asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="txtQ" runat="server" ErrorMessage="You can only type numbers"
                                    ControlToValidate="txtQuantity" ValidationExpression="^\d+$" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="Image:"></asp:Label>
                                <br/>
                                <asp:FileUpload ID="fileImage" runat="server" /><br />
                                 <asp:RequiredFieldValidator ID="emptyImage" runat="server" 
                                    ControlToValidate="fileImage" Display="Dynamic" Text="*empty field" ForeColor="Red">
                                </asp:RequiredFieldValidator>
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
