<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="snvDeneme.aspx.cs" Inherits="ProjeEtkinlik.Views.User.snvDeneme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form action="/" method="post" runat="server">
        <asp:GridView runat="server" id="gridView"></asp:GridView>
    </form>
</asp:Content>
