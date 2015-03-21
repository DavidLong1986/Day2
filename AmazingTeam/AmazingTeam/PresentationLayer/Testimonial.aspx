<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="Testimonial.aspx.cs" Inherits="AmazingTeam.PresentationLayer.Testimonial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
   <!--My Jumbotron -->
    <div class="container">
  <div class="jumbotron">
    <h1 style="text-align:center;">What Our Customer say about us!</h1>      
  </div>
</div>
    <!--End of Jumbotron -->

<div class="container col-md-offset-3 col-md-6 col-md-offset-3">
    <form role="form" runat="server">
    <div class="input-group col-md-12">
          <asp:Table runat = "server" ID ="DynamicTable" class="table table-striped" />
    </div>

<div class="panel">
    <div role="tab" id="ShowHide1-heading2">
          <button type="button" class="col-md-offset-3 col-md-6 col-md-offset-3" data-toggle="collapse" data-parent="#ShowHide1" href="#ShowHide1-collapse2" aria-expanded="true" aria-controls="ShowHide1-collapse2">Click to add Testimonials</button>
    </div>
    <br />
    <hr />
   <center><asp:Label runat="server" id="MessageLabel"></asp:Label></center> 
    <div id="ShowHide1-collapse2" class="panel-collapse collapse" role="tabpanel" aria-labelledby="ShowHide1-heading2">

<div class="row">
    <div>
        <div class="form-group">
  
      <div class="form-group">
        <label for="InputName">Your Name</label>
        <div class="input-group">
          <asp:TextBox class="form-control" id="Name" placeholder="Enter Name" runat="server" required />
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
      </div>

        <label for="Rate">Rate C2 out of 5</label>
        
            <asp:DropDownList ID="RateC2" runat="server" class="form-control" required>
            <asp:ListItem Value="" Selected="True"></asp:ListItem>
            <asp:ListItem Value="1">1 out of 5</asp:ListItem>
            <asp:ListItem Value="2">2 out of 5</asp:ListItem>
            <asp:ListItem Value="3">3 out of 5</asp:ListItem>
            <asp:ListItem Value="4">4 out of 5</asp:ListItem>
            <asp:ListItem Value="5">5 out of 5</asp:ListItem>
            </asp:DropDownList>
          </div>
     
      <div class="form-group">
        <label for="InputMessage">Comments</label>
        <div class="input-group">
          <asp:TextBox class="form-control" id="InputComments" TextMode="multiline" runat="server" rows="5" required />
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
      </div>
        

         <asp:Button id="submitTestimonial" Text="submit" class="btn btn-info pull-right" runat="server" OnClick="submit_Click"  />
       
    </div>
</div>
</div>

        </div>
  </div>
        </form>
</asp:Content>
