<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CoreVises.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
      <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>CoreVises</title>
    <!-- BOOTSTRAP STYLES-->
    <link href="./Style/bootstrap.css" rel="stylesheet" />
    <!-- FONTAWESOME STYLES-->
    <link href="./Style/font-awesome.css" rel="stylesheet" />
    <!-- CUSTOM STYLES-->
    <link href="./Style/custom.css" rel="stylesheet" />
     <!-- GOOGLE FONTS-->
   <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />
</head>
<body>
     
           
          
    <div id="wrapper">
         <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="adjust-nav">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".sidebar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">
                        <img src="./Images/logo.png" width="70" height="70" />

                    </a>
                    
                </div>
            </div>
        </div>
        <br>
        <!-- /. NAV TOP  -->

        <!-- /. NAV SIDE  -->
            <div id="page-inner" style="min-height:758px">
                <div class="row">
                    <div class="col-lg-12">
                     <h2 style="text-align:center">LOGIN</h2>   
                    </div>
                </div>              
                 <!-- /. ROW  -->
                 <div class="row text-center pad-top">
                <form id="login" runat="server">
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="User Name:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtUser" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <asp:RequiredFieldValidator ID="emptyUser" runat="server" 
                                    ControlToValidate="txtUser" Display="Dynamic" Text="*empty field" ForeColor="Red">
                                </asp:RequiredFieldValidator>
                                <br />
                            </td>

                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text="Password:"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtPassword" runat="server" Height="27px" Width="485px"></asp:TextBox><br />
                                <asp:RequiredFieldValidator ID="emptyPassword" runat="server" 
                                    ControlToValidate="txtPassword" Display="Dynamic" Text="*empty field" ForeColor="Red">
                                </asp:RequiredFieldValidator>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnAccept" runat="server" Text="Login" OnClick="btnAccept_Click" Height="49px" Width="485px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <br />
                                <asp:Label ForeColor="Red"   ID="lblMessage" runat="server" Text=""></asp:Label><br />
                            </td>
                        </tr>
                    </table>

                </form>
            </div>
               </div>

         <!-- /. PAGE WRAPPER  -->
        </div>
          

     <!-- /. WRAPPER  -->
    <!-- SCRIPTS -AT THE BOTOM TO REDUCE THE LOAD TIME-->
    <!-- JQUERY SCRIPTS -->
    <script src="./JS/jquery-1.10.2.js"></script>
    <!-- BOOTSTRAP SCRIPTS -->
    <script src="./JS/bootstrap.min.js"></script>
    <!-- CUSTOM SCRIPTS -->
    <script src="./JS/custom.js"></script>
    
   
    <div class="footer">
            <div class="row">
                <div class="col-lg-12" >  
                </div>
            </div>
        </div>
     </body>
</html>

