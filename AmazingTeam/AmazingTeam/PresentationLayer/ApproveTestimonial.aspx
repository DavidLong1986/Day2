<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="ApproveTestimonial.aspx.cs" Inherits="AmazingTeam.PresentationLayer.ApproveTestimonial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

<form role="form" runat="server" method="post" >
<div class="container col-md-offset-3 col-md-6 col-md-offset-3">
<div class="row">

        <div class="input-group col-md-12">
          <asp:Table runat = "server" ID ="DynamicTable" class="table table-striped" />
        </div>
        <br />
        <hr />
        <br />
        <label>Testimonial ID</label>
        <div class="input-group col-md-12">
          <asp:TextBox ID="TestimonialNumber" class="form-control "  runat="server" placeholder="Product ID" />
        </div>
      <asp:Label runat="server" id="MessageLabel"></asp:Label>
      <br />
      <asp:Button id="Like" Text="Like" class="btn btn-primary" runat="server" OnClick="Like_Click"  /> 
      <asp:Button id="Dislike" Text="Delete" class="btn btn-danger" runat="server" OnClick="Dislike_Click" /> 

</div>
</div>
</form>
</asp:Content>
