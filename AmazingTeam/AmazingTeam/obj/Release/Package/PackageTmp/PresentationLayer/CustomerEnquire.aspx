<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="CustomerEnquire.aspx.cs" Inherits="AmazingTeam.PresentationLayer.CustomerEnquire" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">




        <!--My Jumbotron -->
    <div class="container">
  <div class="jumbotron"; style="background-image:url(https://fbcdn-sphotos-d-a.akamaihd.net/hphotos-ak-xap1/t31.0-8/11082292_1063234687024607_2966671901688669727_o.jpg); height:350px; background-repeat:no-repeat; background-size:cover; align:center;">
    <h1 style="text-align:center; font-family:sans-serif; font-size:500%; font-weight:300; color:#FFF002">Ask your question here!</h1>      
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
            <asp:ListItem Value="Products" >Products</asp:ListItem>
            <asp:ListItem Value="Order">Order</asp:ListItem>
            <asp:ListItem Value="PayPal">PayPal</asp:ListItem>
            <asp:ListItem Value="Catering">Catering</asp:ListItem>
            <asp:ListItem Value="General Question">General Question</asp:ListItem>
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
