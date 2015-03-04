<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="CustomerEnquire.aspx.cs" Inherits="AmazingTeam.PresentationLayer.CustomerEnquire" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">




<!--My Jumbotron -->
<div class="container">
  <div class="jumbotron">
    <h1 style="text-align:center;">your question!</h1>      
  </div>
</div>
<!--End of Jumbotron -->

<div class="container col-md-offset-3 col-md-6 col-md-offset-3">

<div class="row">
  <form role="form" runat="server">   
    <div>
      <div class="well well-sm"><strong><i class="glyphicon glyphicon-ok form-control-feedback"></i> Required Field</strong></div>
        <div class="form-group">
        <label for="InputEmail">Your Type of Question</label>
        
            <asp:DropDownList ID="TypeOfQuestion" runat="server" class="form-control" required>
            <asp:ListItem Value="" Selected="True"></asp:ListItem>
            <asp:ListItem Value="Discount Question" >Discount Question</asp:ListItem>
            <asp:ListItem Value="Special Order Questions">Special Order Questions</asp:ListItem>
            
            
            <asp:ListItem Value="I don't have PayPal Account">I don't have PayPal Account</asp:ListItem>
            <asp:ListItem Value="4">4</asp:ListItem>
            <asp:ListItem Value="5">5</asp:ListItem>
            <asp:ListItem Value="6">6</asp:ListItem>
            <asp:ListItem Value="7">7</asp:ListItem>
            </asp:DropDownList>
          </div>
        <div class="form-group">
        <label for="InputName">Your Name</label>
        <div class="input-group">
          <asp:TextBox class="form-control" id="InputName" placeholder="Enter Name" runat="server" required />
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
      </div>
      <div class="form-group">
        <label for="InputEmail">Your Email</label>
        <div class="input-group">
          <asp:TextBox class="form-control" id="InputEmail" placeholder="Enter Email" runat="server" required />
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
      </div>
     
      <div class="form-group">
        <label for="InputMessage">Message</label>
        <div class="input-group">
          <asp:TextBox class="form-control" id="InputMessage" TextMode="multiline" runat="server" rows="5" required />
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
      </div>
        <asp:Label runat="server" id="MessageLabel"></asp:Label>
         <asp:Button id="submit" Text="submit" class="btn btn-info pull-right" runat="server" OnClick="submit_Click"  />
    </div>
  </form>
</div>
</div>
</asp:Content>
