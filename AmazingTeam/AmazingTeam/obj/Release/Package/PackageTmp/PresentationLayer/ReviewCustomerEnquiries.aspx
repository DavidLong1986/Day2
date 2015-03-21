<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="ReviewCustomerEnquiries.aspx.cs" Inherits="AmazingTeam.PresentationLayer.ReviewCustomerEnquiries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <form id="form1" runat="server">
    <div align="center">
    
     
        <br />
        <asp:Label ID="lbMsg" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
    
        <br />
        <br />
        <br />    
        
        <asp:Button ID="btnLoadActiveEnquires" runat="server" Font-Bold="True" Font-Size="Large" 
             Text="Load All Active Enquiries" onclick="btnLoadActiveEnquires_Click" />
        
        <br />
        <br />
        <br />

        <asp:GridView ID="gvAllActive" runat="server" CellPadding="4"
            onselectedindexchanged="gvAllActive_SelectedIndexChanged" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField SelectText="De-Activate" ShowSelectButton="True" />
            </Columns>
            
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
        
        <br />

    
    </div>
    </form>



</asp:Content>
