<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/base.Master" AutoEventWireup="true" CodeBehind="UpdateBrand.aspx.cs" Inherits="CoreVises.Presentation.UpdateBrand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPage" runat="server">
     <div id="page-wrapper">
        <div id="page-inner">
            <div class="row">
                <div class="col-md-12">
                    <h2>Manage Brand</h2>
                </div>
            </div>
           
            <div class="row text-center pad-top">
            <form id="manage_Brand" runat="server">
                <asp:GridView CssClass="grids" ID="gvBrand" runat="server"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="idBrand" DataSourceID="sdsBrand" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" DeleteText="Delete" UpdateText="Update" EditText="Edit" CancelText="Cancel" ShowEditButton="True" HeaderText="Actions" />
                        <asp:BoundField  DataField="idBrand" HeaderText="idBrand" InsertVisible="False" ReadOnly="True" SortExpression="idBrand" Visible="False" />
                        <asp:BoundField  DataField="name" HeaderText="Name" SortExpression="name" />
                    </Columns>
                </asp:GridView>
                <hr />
                <asp:SqlDataSource ID="sdsBrand" runat="server" OnSelecting="SqlDataSource1_Selecting" ConnectionString="<%$ ConnectionStrings:KeggPhonesConnectionString %>" SelectCommand="SELECT * FROM [TBrand]" DeleteCommand="DELETE FROM [TBrand] WHERE [idBrand] = @idBrand" InsertCommand="INSERT INTO [TBrand] ([name]) VALUES (@name)" UpdateCommand="UPDATE [TBrand] SET [name] = @name WHERE [idBrand] = @idBrand">
                    <DeleteParameters>
                        <asp:Parameter Name="idBrand" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="name" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="name" Type="String" />
                        <asp:Parameter Name="idBrand" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </form>           
             </div>
        </div>

    </div>
</asp:Content>
