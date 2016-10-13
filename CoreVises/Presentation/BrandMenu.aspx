<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation/base.Master" AutoEventWireup="true" CodeBehind="BrandMenu.aspx.cs" Inherits="CoreVises.Presentation.BrandMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPage" runat="server">
     <div id="page-wrapper" >
            <div id="page-inner">
                <div class="row">
                    <div class="col-lg-12">
                     <h2>BRAND MENU</h2>   
                    </div>
                </div>              
                 <!-- /. ROW  -->

                  <!-- /. ROW  --> 
                  <div class="row text-center pad-top">
                  <div class="col-lg-2 col-md-2 col-sm-2 col-xs-6">
                      <div class="div-square">
                           <a href="InsertBrand.aspx" >
                <i class="fa fa-circle-o-notch fa-5x"></i>
                      <h4>Insert Brand</h4>
                      </a>
                      </div>
                     
                     
                  </div> 
                 
                  <div class="col-lg-2 col-md-2 col-sm-2 col-xs-6">
                      <div class="div-square">
                           <a href="UpdateBrand.aspx" >
                    <i class="fa fa-gear fa-5x"></i>
                      <h4>Manage Brand</h4>
                      </a>
                      </div>
                     
                     
                  </div>
                 
              </div>
             <!-- /. PAGE INNER  -->
            </div>
         <!-- /. PAGE WRAPPER  -->
</asp:Content>
