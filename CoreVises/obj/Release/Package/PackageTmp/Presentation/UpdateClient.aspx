<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/base.Master" AutoEventWireup="true" CodeBehind="UpdateClient.aspx.cs" Inherits="CoreVises.Presentation.UpdateClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPage" runat="server">
     <div id="page-wrapper">
        <div id="page-inner">
            <div class="row">
                <div class="col-md-12">
                    <h2>Manage Client</h2>
                </div>
            </div>
           
            <div class="row text-center pad-top">
            <form id="manage_Client" runat="server">
                <asp:GridView ID="gvClient" CssClass="grids" runat="server" AutoGenerateColumns="False" DataKeyNames="idClient" DataSourceID="sdsClient" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                    <Columns>
                        <asp:CommandField HeaderText="Actions" DeleteText="Delete" UpdateText="Update" CancelText="Cancel" EditText="Edit" ShowDeleteButton="True" ShowEditButton="True" />
                        <asp:BoundField DataField="idClient" HeaderText="idClient" ReadOnly="True" SortExpression="idClient" Visible="False" />
                        <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                        <asp:BoundField DataField="lastName_1" HeaderText="First Last Name" SortExpression="lastName_1" />
                        <asp:BoundField DataField="lastName_2" HeaderText="Second Last Name" SortExpression="lastName_2" />
                        <asp:BoundField DataField="nameUser" HeaderText="User" SortExpression="nameUser" />
                        <asp:BoundField DataField="passwordUser" HeaderText="Password" SortExpression="passwordUser" />
                        <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                        <asp:BoundField DataField="numberCard" HeaderText="Card Number" SortExpression="numberCard" />
                        <asp:BoundField DataField="addressDirection" HeaderText="Address" SortExpression="addressDirection" />
                        <asp:BoundField DataField="postalCode" HeaderText="Postal Code" SortExpression="postalCode" />
                        <asp:BoundField DataField="svcCard" HeaderText="SVC" SortExpression="svcCard" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
                <asp:SqlDataSource ID="sdsClient" runat="server" ConnectionString="<%$ ConnectionStrings:KeggPhonesConnectionString %>" DeleteCommand="DELETE FROM [TClient] WHERE [idClient] = @idClient" InsertCommand="INSERT INTO [TClient] ([idClient], [name], [lastName_1], [lastName_2], [nameUser], [passwordUser], [email], [numberCard], [addressDirection], [postalCode], [svcCard]) VALUES (@idClient, @name, @lastName_1, @lastName_2, @nameUser, @passwordUser, @email, @numberCard, @addressDirection, @postalCode, @svcCard)" SelectCommand="SELECT * FROM [TClient]" UpdateCommand="UPDATE [TClient] SET [name] = @name, [lastName_1] = @lastName_1, [lastName_2] = @lastName_2, [nameUser] = @nameUser, [passwordUser] = @passwordUser, [email] = @email, [numberCard] = @numberCard, [addressDirection] = @addressDirection, [postalCode] = @postalCode, [svcCard] = @svcCard WHERE [idClient] = @idClient">
                    <DeleteParameters>
                        <asp:Parameter Name="idClient" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="idClient" Type="Int32" />
                        <asp:Parameter Name="name" Type="String" />
                        <asp:Parameter Name="lastName_1" Type="String" />
                        <asp:Parameter Name="lastName_2" Type="String" />
                        <asp:Parameter Name="nameUser" Type="String" />
                        <asp:Parameter Name="passwordUser" Type="String" />
                        <asp:Parameter Name="email" Type="String" />
                        <asp:Parameter Name="numberCard" Type="String" />
                        <asp:Parameter Name="addressDirection" Type="String" />
                        <asp:Parameter Name="postalCode" Type="String" />
                        <asp:Parameter Name="svcCard" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="name" Type="String" />
                        <asp:Parameter Name="lastName_1" Type="String" />
                        <asp:Parameter Name="lastName_2" Type="String" />
                        <asp:Parameter Name="nameUser" Type="String" />
                        <asp:Parameter Name="passwordUser" Type="String" />
                        <asp:Parameter Name="email" Type="String" />
                        <asp:Parameter Name="numberCard" Type="String" />
                        <asp:Parameter Name="addressDirection" Type="String" />
                        <asp:Parameter Name="postalCode" Type="String" />
                        <asp:Parameter Name="svcCard" Type="String" />
                        <asp:Parameter Name="idClient" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </form>           
             </div>
        </div>

    </div>
</asp:Content>
