<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="ForgetPassw.aspx.cs" Inherits="ProjeEtkinlik.Views.Public.ForgetPassw" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="email" runat="server"></asp:TextBox>
    <asp:TextBox ID="sifre" runat="server"></asp:TextBox>
    <asp:Button ID="Degistir" runat="server" Text="Button" />
</asp:Content>
