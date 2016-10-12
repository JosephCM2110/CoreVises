<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/base.Master" AutoEventWireup="true" CodeBehind="AdminMenu.aspx.cs" Inherits="CoreVises.Presentation.AdminMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPage" runat="server">
         <div id="page-wrapper" >
            <div id="page-inner">
                <div class="row">
                    <div class="col-lg-12">
                     <h2>ADMIN MENU</h2>   
                    </div>
                </div>              
                 <!-- /. ROW  -->
                  <hr />
                  <!-- /. ROW  --> 
                  <div class="row text-center pad-top">
                  <div class="col-lg-2 col-md-2 col-sm-2 col-xs-6">
                      <div class="div-square">
                           <a href="InsertAdministrator.aspx" >
                <i class="fa fa-users fa-5x"></i>
                      <h4>Insert Administrator</h4>
                      </a>
                      </div>
                     
                     
                  </div> 
                 
                  <div class="col-lg-2 col-md-2 col-sm-2 col-xs-6">
                      <div class="div-square">
                           <a href="UpdateAdministrator.aspx" >
                    <i class="fa fa-gear fa-5x"></i>
                      <h4>Manage Administrators</h4>
                      </a>
                      </div>
                     
                     
                  </div>
                 
              </div>
             <!-- /. PAGE INNER  -->
            </div>
         <!-- /. PAGE WRAPPER  -->
</asp:Content>