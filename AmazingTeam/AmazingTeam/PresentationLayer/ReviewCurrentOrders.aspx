<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="ReviewCurrentOrders.aspx.cs" Inherits="AmazingTeam.PresentationLayer.ReviewCurrentOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <form id="form1" runat="server">
    <div>
    
    </div>
     <div align="center">
    
        
         <br />
         <br />
        <asp:Label ID="lbMsg" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
    
         <br />
         <br />
         <br />
         
         <asp:Button ID="btnLoad" runat="server" Font-Bold="True" Font-Size="Large" 
             Text="Load All Active Orders" onclick="btnLoad_Click" />
    
         <br />
         <br />
         <br />    
         <br />
    
         <asp:GridView ID="gvAllActiveOrders" runat="server" CellPadding="4"
            onselectedindexchanged="gvAllActiveOrders_SelectedIndexChanged" HeaderStyle-BackColor="#CCCCCC" ForeColor="#333333" GridLines="None">
             <AlternatingRowStyle BackColor="White" />
         <Columns>
                <asp:CommandField SelectText="De-Activate" ShowSelectButton="True" />
            </Columns>
             <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />

<HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White"></HeaderStyle>
             <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
             <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
             <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
             <SortedAscendingCellStyle BackColor="#FDF5AC" />
             <SortedAscendingHeaderStyle BackColor="#4D0000" />
             <SortedDescendingCellStyle BackColor="#FCF6C0" />
             <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
         
         
         <br />
         <br />
        
    </div>
    </form>
</asp:Content>
