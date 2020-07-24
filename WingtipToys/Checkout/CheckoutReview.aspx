<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckoutReview.aspx.cs" Inherits="WingtipToys.Checkout.CheckoutReview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>订单总览</h1>
    <p></p>
    <h3 style="padding-left: 33px">商品详情:</h3>
    <asp:GridView ID="OrderItemList" runat="server" AutoGenerateColumns="False" CellPadding="10" Width="500px" BorderColor="#EFEEEF" BorderWidth="33px">              
        <Columns>
            <asp:BoundField DataField="ProductId" HeaderText="书本ID" />        
            <asp:BoundField DataField="Product.ProductName" HeaderText=" 书名" />        
            <asp:BoundField DataField="Product.UnitPrice" HeaderText="单价" DataFormatString="{0:c}"/>     
            <asp:BoundField DataField="Quantity" HeaderText="数量" />        
        </Columns>    
    </asp:GridView>
    <asp:DetailsView ID="ShipInfo" runat="server" AutoGenerateRows="false" GridLines="None" CellPadding="10" BorderStyle="None" CommandRowStyle-BorderStyle="None">
        <Fields>
        <asp:TemplateField>
            <ItemTemplate>
                <h3>地址:</h3>
                <br />
                <asp:Label ID="FirstName" runat="server" Text='<%#: Eval("FirstName") %>'></asp:Label>  
                <asp:Label ID="LastName" runat="server" Text='<%#: Eval("LastName") %>'></asp:Label>
                <br />
                <asp:Label ID="Address" runat="server" Text='<%#: Eval("Address") %>'></asp:Label>
                <br />
                <asp:Label ID="City" runat="server" Text='<%#: Eval("City") %>'></asp:Label>
                <asp:Label ID="State" runat="server" Text='<%#: Eval("State") %>'></asp:Label>
                <asp:Label ID="PostalCode" runat="server" Text='<%#: Eval("PostalCode") %>'></asp:Label>
                <p></p>
                <h3>订单总价:</h3>
                <br />
                <asp:Label ID="Total" runat="server" Text='<%#: Eval("Total", "{0:C}") %>'></asp:Label>
            </ItemTemplate>
            <ItemStyle HorizontalAlign="Left" />
        </asp:TemplateField>
          </Fields>
    </asp:DetailsView>
    <p></p>
    <hr />
    <asp:Button ID="CheckoutConfirm" runat="server" Text="提交订单" OnClick="CheckoutConfirm_Click" />
</asp:Content>