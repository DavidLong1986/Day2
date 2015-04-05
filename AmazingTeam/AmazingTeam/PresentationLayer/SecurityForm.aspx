<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="SecurityForm.aspx.cs" Inherits="AmazingTeam.PresentationLayer.SecurityForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

<div class="container" style="margin-top:30px">
<div class="col-md-offset-3 col-md-6 col-md-offset-3">
<div class="panel panel-default">
      <div class="panel-heading"><h3 class="panel-title"><strong>Security respond is required to access admin pages </strong></h3></div>
  <div class="panel-body">
   <form role="form" runat="server">
  <div class="form-group">
        <br />
        <br />
    
    <p style="margin-left: 80px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; who was your favourite teacher in High 
        School ?</p>
    <p style="margin-left: 80px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:TextBox ID="Respond" runat="server" Width="247px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="MessageLine1" runat="server" ForeColor="Red" ></asp:Label>
    </p>
    <p>
        <asp:Label ID="MessageLine2" runat="server" ForeColor="Red" ></asp:Label>
    </p>
    <p>
        <asp:Label ID="MessageLine3" runat="server" ForeColor="Red"></asp:Label>
    </p>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;<asp:Button ID="BtnSumit" runat="server" Text="Submit" class="btn btn-sm btn-info"
            onclick="BtnSumit_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    


    </div>
    </form>

</div>
    </div>
    </div>
    </div>
</asp:Content>
