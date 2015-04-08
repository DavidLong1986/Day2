<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="SuccessTranscation.aspx.cs" Inherits="AmazingTeam.PresentationLayer.SuccessTranscation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <!--My Jumbotron -->
    <div class="container">
  <div class="jumbotron"; style="background-image:url(https://scontent-sea.xx.fbcdn.net/hphotos-xap1/l/t31.0-8/11130470_1063234717024604_4920137944528023657_o.jpg); height:350px; background-repeat:no-repeat; background-size:cover; align:center;">
    <h1 style="text-align:center; font-family:sans-serif; font-size:500%; font-weight:300; color:#FFF002">Thank you for your purchase!</h1>      
  </div> 
</div>
    <!--End of Jumbotron -->


<asp:label id="debuggy" runat="server"/>
<asp:label id="MessageLine" runat="server"/>
</asp:Content>
