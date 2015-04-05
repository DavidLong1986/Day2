<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="AddFindUpdateDeleteMenu.aspx.cs" Inherits="AmazingTeam.PresentationLayer.AddUpdateDelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

   <!--My Jumbotron -->
    <div class="container">
  <div class="jumbotron"; style="background-image:url(https://scontent-sea.xx.fbcdn.net/hphotos-xfa1/t31.0-8/11084089_10155325983325618_3632523070359408870_o.jpg); height:350px; background-repeat:no-repeat; background-size:cover; align:center;">
    <h1 style="text-align:center; font-family:sans-serif; font-size:500%; font-weight:300; color:#FFF002">Administration Page!</h1>      
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
      <div class="well well-sm"><strong><i class="glyphicon glyphicon-ok form-control-feedback"></i> Required Field</strong></div>
        <label>Product ID</label>
        <div class="input-group col-md-12">
        <asp:TextBox ID="ProductID" class="form-control "  runat="server" placeholder="Product ID" />
        </div>
    <br />
        <asp:Label runat="server" id="FindMessage"></asp:Label>
        <br />
        <br />
        <div class="container">
        <asp:Button id="Find" Text="Find" class="btn btn-info" runat="server" OnClick="Find_Click" />
    </div>
    <hr />
        <div class="input-group col-md-12">
          <asp:Table runat = "server" ID ="DynamicTable" class="table table-striped" />
        </div>
      <div class="form-group">
        <label>Product Name</label>
          <div class="input-group col-md-12">
              <asp:TextBox class="form-control" ID="ProductName" placeholder="Product Name" runat="server" />
          </div>
      </div>
      <div class="form-group">
        <label for="InputMessage">Product Description</label>
        <div class="input-group">
          <asp:TextBox class="form-control" id="Description" TextMode="multiline" runat="server" rows="5" />
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
      </div>
      <div class="form-group">
        <label>Category ID</label>
        <div class="input-group col-md-12">

            <asp:DropDownList ID="CategoryID" runat="server" class="form-control" required>
            <asp:ListItem Value="1" Selected="True">Desserts</asp:ListItem>
            </asp:DropDownList>
         
        </div>
      </div>
      <div class="form-group">
        <label>Quantity</label>
        <div class="input-group col-md-12">
          <asp:TextBox class="form-control" id="QuantityPerUnit" placeholder="Enter Quantity" runat="server" />
        </div>
      </div>
      <div class="form-group">
        <label>Unit Price</label>
        <div class="input-group col-md-12">
          <asp:TextBox class="form-control" id="UnitPrice" placeholder="Enter Price Per Unit" runat="server" />
        </div>
      </div>
      <div class="form-group">
        <label>Unit In Stock</label>
        <div class="input-group col-md-12">
          <asp:TextBox class="form-control" id="UnitInStock" placeholder="Enter Unit In Stock" runat="server" />
        </div>
      </div>
      <div class="form-group">
        <label>Unit On Order</label>
        <div class="input-group col-md-12">
          <asp:TextBox class="form-control" id="UnitOnOrder" placeholder="Enter Unit On Order" runat="server" />
        </div>
      </div>
    </div>
    <asp:Label runat="server" id="MessageLine"></asp:Label>
    <hr />
      <div class="container">
      <asp:Button id="Add" Text="Add" class="btn btn-info" runat="server" OnClick="Add_Click" /> 
      <asp:Button id="Update" Text="Update" class="btn btn-primary" runat="server" OnClick="Update_Click" /> 
      <asp:Button id="Delete" Text="Delete" class="btn btn-danger" runat="server" OnClick="Delete_Click"/>           
      </div>
    </div>
  </form>
</asp:Content>
