<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="AddUpdateDelete.aspx.cs" Inherits="AmazingTeam.PresentationLayer.AddUpdateDelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
               <!--My Jumbotron -->
    <div class="container">
  <div class="jumbotron">
    <h1 style="text-align:center;">Administration Page!</h1>      
  </div>
</div>
    <!--End of Jumbotron -->

<div class="container col-md-offset-3 col-md-6 col-md-offset-3">
<div class="row">
  <form role="form" action="" method="post" >
    <div>
      <div class="well well-sm"><strong><i class="glyphicon glyphicon-ok form-control-feedback"></i> Required Field</strong></div>
        <div class="form-group">
        <label for="InputName">Item ID</label>
        <div class="input-group">
          <input type="text" class="form-control" name="InputName" id="InputName" placeholder="Enter Name" required>
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
      </div>
        <div class="form-group">
        <label for="InputMessage">Item Description</label>
        <div class="input-group"
>
          <textarea name="InputMessage" id="InputMessage" class="form-control" rows="5" required></textarea>
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
      </div>
                <div class="form-group">
        <label for="InputName">Price</label>
        <div class="input-group">
          <input type="text" class="form-control" name="InputName" id="InputName" placeholder="Enter Name" required>
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
      </div>
      <div class="form-group">
        <label for="InputEmail">Image</label>
        <div class="input-group">
          <input type="email" class="form-control" id="InputEmail" name="InputEmail" placeholder="Enter Email" required  >
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
      </div>
    </div>
      <div class="container">
      <input type="button"  id="Add" value="Add" class="btn btn-default">
      <input type="button"  id="submit" value="Update" class="btn btn-primary">
      <input type="button"  id="Delete" value="Delete" class="btn btn-danger">
    </div>
  </form>
    
  

</div>

</div>
</asp:Content>
