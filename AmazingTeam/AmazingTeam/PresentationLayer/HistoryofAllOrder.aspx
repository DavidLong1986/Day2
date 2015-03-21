<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="HistoryofAllOrder.aspx.cs" Inherits="AmazingTeam.PresentationLayer.HistoryofAllOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
<!--My Jumbotron -->
<div class="container">
  <div class="jumbotron">
    <h1 style="text-align:center;">History of All Orders!</h1>      
  </div>
</div>
<!--End of Jumbotron -->


<form role="form" runat="server" method="post" >
<div class="container col-md-offset-3 col-md-6 col-md-offset-3">
<div class="row">
      <div class="well well-sm"><strong><i class="glyphicon glyphicon-ok form-control-feedback"></i> Required Field</strong></div>
        
        <div class="input-group col-md-12">
          <asp:Label runat="server" id="MessageLine"></asp:Label>
          <asp:GridView ID="HistoryOfAllOrderGrid" runat="server" weight="100%"  CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="200">
              <AlternatingRowStyle BackColor="White" />
              <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
              <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
              <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
              <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
              <SortedAscendingCellStyle BackColor="#FDF5AC" />
              <SortedAscendingHeaderStyle BackColor="#4D0000" />
              <SortedDescendingCellStyle BackColor="#FCF6C0" />
              <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
        </div>
      <br />
      <div class="form-group">
        <label>Order From Date</label>
          <div class="input-group col-md-12">
              <asp:TextBox class="form-control" ID="OrderFromDate" placeholder="From Date" runat="server" />
              <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
          </div>

      <div class="form-group">
        <label>Order To Date</label>
        <div class="input-group col-md-12">
          <asp:TextBox class="form-control" ID="OrderToDate" placeholder="To Date" runat="server" />
          <span class="input-group-addon"><i class="glyphicon glyphicon-ok form-control-feedback"></i></span></div>
      </div>
    <hr />
    </div>
    </div>
      <div class="container">
      <asp:Button id="SubmitDates" Text="Submit Dates" class="btn btn-default" runat="server" OnClick="SubmitDates_Click" />            
      </div>
  </form>

</asp:Content>
