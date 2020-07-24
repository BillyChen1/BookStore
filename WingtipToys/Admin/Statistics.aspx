<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="WingtipToys.Admin.Statistics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>统计</h1>
    <p></p>
    <h3 style="padding-left: 33px">顾客购买记录</h3>
    <asp:GridView ID="PurchaseList" runat="server" AutoGenerateColumns="False" CellPadding="10" Width="500px" BorderColor="#EFEEEF" BorderWidth="33px">
        <Columns>
            <asp:BoundField DataField="Username" HeaderText="用户名" />
            <asp:BoundField DataField="ProductId" HeaderText="书籍ID" />
            <asp:BoundField DataField="Product.ProductName" HeaderText="书名" />
            <asp:BoundField DataField="Quantity" HeaderText="数量" />
            <asp:BoundField DataField="UnitPrice" HeaderText="单价" />
        </Columns>
    </asp:GridView>

    <hr />

    <h3 style="padding-left: 33px">书本销售统计</h3>
        <asp:GridView ID="ProductsList" runat="server" AutoGenerateColumns="False" GridLines="Both" CellPadding="10" Width="500" BorderColor="#efeeef" BorderWidth="33">              
        <Columns>
            <asp:BoundField DataField="ProductId" HeaderText="书本ID" />        
            <asp:BoundField DataField="ProductName" HeaderText="书名" />        
            <asp:BoundField DataField="UnitPrice" HeaderText="单价" DataFormatString="{0:c}"/>     
            <asp:BoundField DataField="Sold" HeaderText="已售数量" />   
        </Columns>    
       </asp:GridView>

    <asp:Label ID="SumNumber" runat="server" Text=""></asp:Label>
    <asp:Label ID="SumMoney" runat="server" Text=""></asp:Label>

</asp:Content>
