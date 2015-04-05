<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="Testimonial.aspx.cs" Inherits="AmazingTeam.PresentationLayer.Testimonial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">


    <!--My Jumbotron -->
    <div class="container">
  <div class="jumbotron"; style="background-image:url(https://scontent-sea.xx.fbcdn.net/hphotos-xat1/t31.0-8/11134062_10155325983095618_4122151366096095791_o.jpg); height:350px; background-repeat:no-repeat; background-size:cover; align:center;">
    <h1 style="text-align:center; font-family:sans-serif; font-size:500%; font-weight:300; color:#FFF002 ">What our customers say about us!</h1>      
  </div> 
</div>
    <!--End of Jumbotron -->

<div class="container">
    <form role="form" runat="server">
    <div class="input-group col-md-12">
          
        <center><asp:Label runat="server" Font-Bold="True" Font-Size="Medium" id="MessageLabel"></asp:Label></center> 
        <br />

        <asp:GridView ID="gvAllActive" runat="server" CellPadding="3" Width="100%" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
            <AlternatingRowStyle BackColor="#F4F4F4" />
            
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
            
        </asp:GridView>
    </div>
        <br />
<div class="panel">
    <div role="tab" id="ShowHide1-heading2">
          <button type="button" class="col-md-offset-3 col-md-6 col-md-offset-3 btn btn-info" data-toggle="collapse" data-parent="#ShowHide1" href="#ShowHide1-collapse2" aria-expanded="true" aria-controls="ShowHide1-collapse2">Click to add Testimonials</button>
    </div>
    <br />
    <hr />
   
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
