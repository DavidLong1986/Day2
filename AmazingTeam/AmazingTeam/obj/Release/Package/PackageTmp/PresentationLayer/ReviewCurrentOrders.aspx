﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="ReviewCurrentOrders.aspx.cs" Inherits="AmazingTeam.PresentationLayer.ReviewCurrentOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">


           <!--My Jumbotron -->
    <div class="container">
  <div class="jumbotron"; style="background-image:url(https://scontent-sea.xx.fbcdn.net/hphotos-xta1/t31.0-8/10557075_1063234720357937_5189930813970337817_o.jpg); height:350px; background-repeat:no-repeat; background-size:cover; align:center;">
    <h1 style="text-align:center; font-family:sans-serif; font-size:500%; font-weight:300; color:#FFF002">Review Current Orders!</h1>      
  </div> 
</div>
    <!--End of Jumbotron -->

<!--Tabs for other Admin Pages -->
<div class="container">
	<ul class="nav nav-tabs">
        <li><a href="AddFindUpdateDeleteMenu.aspx"><span class="glyphicon glyphicon-apple"></span> Inventory</a></li>
        <li><a href="ApproveTestimonial.aspx"><span class="glyphicon glyphicon-book"></span> Review Testimonial</a></li>
        <li><a href="HistoryofAllOrder.aspx"><span class="glyphicon glyphicon-header"></span> History Of All Orders</a></li>
        <li><a href="ReviewCustomerEnquiries.aspx"><span class="glyphicon glyphicon-user"></span> Review Customer Enquiries</a></li>
        <li><a href="ReviewCurrentOrders.aspx"><span class="glyphicon glyphicon-scale"></span> Review Current Orders</a></li>
    </ul>
    <hr>
</div>
<!--End of Tabs for other Admin Pages  -->

<form role="form" runat="server" method="post" >
<div class="container">

<div class="row">
    <center>
        <asp:Label ID="lbMsg" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
    </center>
         <br />    
         <asp:GridView ID="gvAllActiveOrders" runat="server" CellPadding="3" Width="100%"
            onselectedindexchanged="gvAllActiveOrders_SelectedIndexChanged" HeaderStyle-BackColor="#CCCCCC" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
             <AlternatingRowStyle BackColor="#F4F4F4" />
         <Columns>
                <asp:CommandField SelectText="De-Activate" ShowSelectButton="True" />
            </Columns>
             <FooterStyle BackColor="#CCCCCC" />

<HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White"></HeaderStyle>
             <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
             <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
             <SortedAscendingCellStyle BackColor="#F1F1F1" />
             <SortedAscendingHeaderStyle BackColor="#808080" />
             <SortedDescendingCellStyle BackColor="#CAC9C9" />
             <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>


</div>


    </div>
  </form>

  
</asp:Content>
