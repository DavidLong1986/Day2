<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="ApproveTestimonial.aspx.cs" Inherits="AmazingTeam.PresentationLayer.ApproveTestimonial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">


       <!--My Jumbotron -->
    <div class="container">
  <div class="jumbotron"; style="background-image:url(https://scontent-sea.xx.fbcdn.net/hphotos-xtf1/t31.0-8/11082221_1063234697024606_118511243090931069_o.jpg); height:350px; background-repeat:no-repeat; background-size:cover; align:center;">
    <h1 style="text-align:center; font-family:sans-serif; font-size:500%; font-weight:300; color:#FFF002">Review Testimonial!</h1>      
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
    
<div class="container col-md-offset-3 col-md-6 col-md-offset-3">
    <center>
    <asp:Label runat="server" id="MessageLabel" Font-Bold="True" Font-Size="Medium"></asp:Label>

        <br />
        <br />
<div class="row">

        <div class="input-group">
            
             <asp:GridView ID="DynamicTable" runat="server" weight="100%" Width="100%"  CellPadding="3" ForeColor="Black" GridLines="Vertical" PageSize="200" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
              <AlternatingRowStyle BackColor="#F4F4F4" />
              <FooterStyle BackColor="#CCCCCC" />
              <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
              <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
              <SortedAscendingCellStyle BackColor="#F1F1F1" />
              <SortedAscendingHeaderStyle BackColor="#808080" />
              <SortedDescendingCellStyle BackColor="#CAC9C9" />
              <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
              
        </div>
    </center>
        <br />
        <hr />
        <br />
        <label>Testimonial ID</label>
        <div class="input-group col-md-12">
          <asp:TextBox ID="TestimonialNumber" class="form-control "  runat="server" placeholder="Product ID" />
        </div>
      <br />
      <asp:Button id="Like" Text="Like" class="btn btn-info" runat="server" OnClick="Like_Click"  /> 
      <asp:Button id="Dislike" Text="Dislike" class="btn btn-danger" runat="server" OnClick="Dislike_Click" /> 

</div>
</div>
        
</form>
</asp:Content>
