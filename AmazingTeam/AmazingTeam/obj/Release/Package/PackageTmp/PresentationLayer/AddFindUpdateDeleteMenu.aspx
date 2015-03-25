<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="AddFindUpdateDeleteMenu.aspx.cs" Inherits="AmazingTeam.PresentationLayer.AddUpdateDelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
<!--Jumbotron -->
<div class="container">
  <div class="jumbotron">
    <h1 style="text-align:center;">Administration Page!</h1>      
  </div>
</div>
    <!--End of Jumbotron -->

<!--Tabs for other Admin Pages -->
<div class="container">
  <div class="btn-group btn-group-md">
  <a href="ApproveTestimonial.aspx" class="btn btn-default">Review Testimonial</a>
  <a href="HistoryofAllOrder.aspx"  class="btn btn-default">History Of All Orders</a>
  <a href="ReviewCustomerEnquiries.aspx" class="btn btn-default">Review Customer Enquiries</a>
  <a href="ReviewCurrentOrders.aspx" class="btn btn-default">Review Current Orders</a>
  </div>
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
            <asp:ListItem Value="1" Selected="True"></asp:ListItem>
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
      <asp:Button id="Add" Text="Add" class="btn btn-default" runat="server" OnClick="Add_Click" /> 
      <asp:Button id="Update" Text="Update" class="btn btn-primary" runat="server" OnClick="Update_Click" /> 
      <asp:Button id="Delete" Text="Delete" class="btn btn-danger" runat="server" OnClick="Delete_Click"/>           
      </div>
    </div>
  </form>
</asp:Content>
