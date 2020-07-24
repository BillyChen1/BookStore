<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckoutComplete.aspx.cs" Inherits="WingtipToys.Checkout.CheckoutComplete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>支付成功</h1>
    <p></p>
    <h3>支付业务ID:</h3> <asp:Label ID="TransactionId" runat="server"></asp:Label>
    <p></p>
    <h3>感谢您的支持!</h3>
    <p></p>
    <hr />
    <asp:Button ID="Continue" runat="server" Text="继续购物" OnClick="Continue_Click" />
</asp:Content>