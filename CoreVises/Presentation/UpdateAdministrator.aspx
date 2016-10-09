<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/base.Master" AutoEventWireup="true" CodeBehind="UpdateAdministrator.aspx.cs" Inherits="CoreVises.Presentation.UpdateAdministrator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPage" runat="server">
     <div id="page-wrapper">
        <div id="page-inner">
            <div class="row">
                <div class="col-md-12">
                    <h2>Manage Administrator</h2>
                </div>
            </div>
           
            <div class="row text-center pad-top">
            <form id="manage_Administrator" runat="server">
                <asp:GridView ID="gvAdministrator" CssClass="grids" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="idAdministrator" DataSourceID="sdsAdminin">
                    <Columns>
                        <asp:CommandField HeaderText="Actions" DeleteText="Delete" EditText="Edit" UpdateText="Update" CancelText="Cancel" ShowDeleteButton="True" ShowEditButton="True" />
                        <asp:BoundField DataField="idAdministrator" HeaderText="idAdministrator" InsertVisible="False" ReadOnly="True" SortExpression="idAdministrator" Visible="False" />
                        <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                        <asp:BoundField DataField="lastName_1" HeaderText="First Last Name" SortExpression="lastName_1" />
                        <asp:BoundField DataField="lastName_2" HeaderText="Second Last name" SortExpression="lastName_2" />
                        <asp:BoundField DataField="nameUser" HeaderText="User Name" SortExpression="nameUser" />
                        <asp:BoundField DataField="passwordUser" HeaderText="Password" SortExpression="passwordUser" />
                        <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
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
                <asp:SqlDataSource ID="sdsAdminin" runat="server" ConnectionString="<%$ ConnectionStrings:KeggPhonesConnectionString %>" DeleteCommand="DELETE FROM [TAdministrator] WHERE [idAdministrator] = @idAdministrator" InsertCommand="INSERT INTO [TAdministrator] ([name], [lastName_1], [lastName_2], [nameUser], [passwordUser], [email]) VALUES (@name, @lastName_1, @lastName_2, @nameUser, @passwordUser, @email)" SelectCommand="SELECT * FROM [TAdministrator]" UpdateCommand="UPDATE [TAdministrator] SET [name] = @name, [lastName_1] = @lastName_1, [lastName_2] = @lastName_2, [nameUser] = @nameUser, [passwordUser] = @passwordUser, [email] = @email WHERE [idAdministrator] = @idAdministrator">
                    <DeleteParameters>
                        <asp:Parameter Name="idAdministrator" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="name" Type="String" />
                        <asp:Parameter Name="lastName_1" Type="String" />
                        <asp:Parameter Name="lastName_2" Type="String" />
                        <asp:Parameter Name="nameUser" Type="String" />
                        <asp:Parameter Name="passwordUser" Type="String" />
                        <asp:Parameter Name="email" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="name" Type="String" />
                        <asp:Parameter Name="lastName_1" Type="String" />
                        <asp:Parameter Name="lastName_2" Type="String" />
                        <asp:Parameter Name="nameUser" Type="String" />
                        <asp:Parameter Name="passwordUser" Type="String" />
                        <asp:Parameter Name="email" Type="String" />
                        <asp:Parameter Name="idAdministrator" Type="Int32" />
                    </UpdateParameters>

                </asp:SqlDataSource>
            </form>           
             </div>
        </div>

    </div>
</asp:Content>
