<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Administrativo.aspx.cs" Inherits="CapaPresentacion.Administrativo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnAgregarPro" runat="server" Text="Agregar Producto" OnClick="btnAgregarPro_Click" /><br />
    <asp:Button ID="btnEliminaroEditarProducto" runat="server" Text="Editar o Eliminar Producto" OnClick="btnEliminaroEditarProducto_Click" />
</asp:Content>
