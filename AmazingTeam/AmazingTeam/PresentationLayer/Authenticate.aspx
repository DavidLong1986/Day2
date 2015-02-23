﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="Authenticate.aspx.cs" Inherits="AmazingTeam.PresentationLayer.Authenticate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="container" style="margin-top:30px">
<div class="col-md-offset-3 col-md-6 col-md-offset-3">
    <div class="panel panel-default">
  <div class="panel-heading"><h3 class="panel-title"><strong>Sign In </strong></h3></div>
  <div class="panel-body">
   <form role="form" runat="server">
  <div class="form-group">
    <label for="exampleInputEmail1">Username</label>
    <asp:TextBox class="form-control" id="UserName" placeholder="User Name" runat="server" />
  </div>
  <div class="form-group">
    <label for="Password">Password </label>
    <asp:TextBox TextMode="Password" class="form-control" id="Password" placeholder="Password" runat="server" />
  </div>
  <div class="form-group">
    <label for="SecretQuestion">Question:<label id ="DatabaseQuestion">BirthDay</label></label>
    <asp:TextBox TextMode="Password" class="form-control" id="SecretAnswer" placeholder="Answer" runat="server" />
  </div>
     <asp:Label runat="server" id="MessageLine"></asp:Label>
      <hr />
     <asp:Button id="LoginIn" Text="Sign in" class="btn btn-sm btn-default" runat="server" OnClick="LoginIn_Click1" />
  </form>
  </div>
</div>
</div>
</div>
































</asp:Content>
