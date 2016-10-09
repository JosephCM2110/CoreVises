<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/base.Master" AutoEventWireup="true" CodeBehind="UpdatePhone.aspx.cs" Inherits="CoreVises.Presentation.UpdatePhone" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPage" runat="server">
     <div id="page-wrapper">
        <div id="page-inner">
            <div class="row">
                <div class="col-md-12">
                    <h2>Manage Phone</h2>
                </div>
            </div>
           
            <div class="row text-center pad-top">
            <form id="manage_Phone" runat="server">
                <asp:GridView ID="gvPhone" CssClass="grids" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="idPhone" DataSourceID="sdsPhones">
                    <Columns>
                        <asp:CommandField HeaderText="Actions" UpdateText="Update" CancelText="Cancel" EditText="Edit" DeleteText="Delete" ShowDeleteButton="True" ShowEditButton="True" />
                        <asp:BoundField DataField="idPhone" HeaderText="idPhone" InsertVisible="False" ReadOnly="True" SortExpression="idPhone" Visible="False" />
                        <asp:TemplateField HeaderText="Brand" SortExpression="idBrand">
                            <EditItemTemplate>
                                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="sdsBrands" DataTextField="name" DataValueField="idBrand">
                                </asp:DropDownList>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="model" HeaderText="Model" SortExpression="model" />
                        <asp:BoundField DataField="internalMemory" HeaderText="Internal Memory" SortExpression="internalMemory" />
                        <asp:BoundField DataField="externalMemory" HeaderText="External Memory" SortExpression="externalMemory" />
                        <asp:BoundField DataField="pixels" HeaderText="Pixels" SortExpression="pixels" />
                        <asp:CheckBoxField DataField="flash" HeaderText="Flash" SortExpression="flash" />
                        <asp:BoundField DataField="resolution" HeaderText="Resolution" SortExpression="resolution" />
                        <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price" />
                        <asp:BoundField DataField="quantity" HeaderText="Quantity" SortExpression="quantity" />
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
                <asp:SqlDataSource ID="sdsPhones" runat="server" ConnectionString="<%$ ConnectionStrings:KeggPhonesConnectionString %>" DeleteCommand="DELETE FROM [TPhone] WHERE [idPhone] = @idPhone"  SelectCommand="SELECT [idPhone],[name],[model],[internalMemory],[externalMemory],[pixels],[flash],[resolution],[price],[quantity] FROM [TPhone] INNER JOIN [TBrand] ON [TPhone].[idBrand] = [TBrand].[idBrand]" UpdateCommand="UPDATE [TPhone] SET [idBrand] = @idBrand, [model] = @model, [internalMemory] = @internalMemory, [externalMemory] = @externalMemory, [pixels] = @pixels, [flash] = @flash, [resolution] = @resolution, [price] = @price, [quantity] = @quantity WHERE [idPhone] = @idPhone">
                    <DeleteParameters>
                        <asp:Parameter Name="idPhone" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="idBrand" Type="Int32" />
                        <asp:Parameter Name="model" Type="String" />
                        <asp:Parameter Name="internalMemory" Type="String" />
                        <asp:Parameter Name="externalMemory" Type="String" />
                        <asp:Parameter Name="pixels" Type="Int32" />
                        <asp:Parameter Name="flash" Type="Boolean" />
                        <asp:Parameter Name="resolution" Type="String" />
                        <asp:Parameter Name="price" Type="Decimal" />
                        <asp:Parameter Name="quantity" Type="Int32" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="idBrand" Type="Int32" />
                        <asp:Parameter Name="model" Type="String" />
                        <asp:Parameter Name="internalMemory" Type="String" />
                        <asp:Parameter Name="externalMemory" Type="String" />
                        <asp:Parameter Name="pixels" Type="Int32" />
                        <asp:Parameter Name="flash" Type="Boolean" />
                        <asp:Parameter Name="resolution" Type="String" />
                        <asp:Parameter Name="price" Type="Decimal" />
                        <asp:Parameter Name="quantity" Type="Int32" />
                        <asp:Parameter Name="idPhone" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="sdsBrands" runat="server" ConnectionString="<%$ ConnectionStrings:KeggPhonesConnectionString %>" SelectCommand="SELECT (Select name From [TBrand] where idBrand [idBrand]) As name,[model],[internalMemory],[externalMemory],[pixels],[flash],[resolution],[price],[quantity] FROM [TBrand]"></asp:SqlDataSource>
            </form>           
             </div>
        </div>

    </div>
</asp:Content>

