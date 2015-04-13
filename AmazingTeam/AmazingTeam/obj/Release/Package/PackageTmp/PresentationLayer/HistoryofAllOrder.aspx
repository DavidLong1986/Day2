<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="HistoryofAllOrder.aspx.cs" Inherits="AmazingTeam.PresentationLayer.HistoryofAllOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <script>
          $(function () {
              $("#datepicker").datepicker();
          });
  </script>

       <!--My Jumbotron -->
    <div class="container">
  <div class="jumbotron"; style="background-image:url(https://scontent-sea.xx.fbcdn.net/hphotos-xaf1/t31.0-8/11080840_1063234707024605_7922385281201566577_o.jpg); height:350px; background-repeat:no-repeat; background-size:cover; align:center;">
    <h1 style="text-align:center; font-family:sans-serif; font-size:500%; font-weight:300; color:#FFF002">History of All Orders!</h1>      
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
<div class="row">
        
    <center>
        <asp:Label ID="MessageLine" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
        <br />
        <asp:Label ID="MessageLineTwo" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
    </center>
    <br />
        <div class="input-group">
          <asp:GridView ID="HistoryOfAllOrderGrid" runat="server" weight="100%"  CellPadding="3" ForeColor="Black" GridLines="Vertical" PageSize="200" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
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
      <br />
      <div class="form-group">



        <label>Order From Date &nbsp;&nbsp;<i>(MM/DD/YYYY)</i></label>
          <div class="input-group col-md-12">
              <asp:TextBox class="form-control" ID="OrderFromDate" placeholder="MM/DD/YYYY" runat="server" />
          </div>

      <div class="form-group">
        <label>Order To Date &nbsp;&nbsp;<i>(MM/DD/YYYY)</i></label>
        <div class="input-group col-md-12">
          <asp:TextBox class="form-control" ID="OrderToDate" placeholder="MM/DD/YYYY" runat="server" />
      </div>
    <hr />
    </div>
    </div>
      <div class="container">
      <asp:Button id="SubmitDates" Text="Submit Dates" class="btn btn-info" runat="server" OnClick="SubmitDates_Click" />            
      </div>
  
  </form>

</asp:Content>
