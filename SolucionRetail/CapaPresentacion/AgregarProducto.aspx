<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="AgregarProducto.aspx.cs" Inherits="CapaPresentacion.AgregarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table style="width:100%;">
        <tr>
            <td>Id Producto</td>
            <td>
                <asp:TextBox ID="txtidproducto" runat="server"></asp:TextBox>

            </td>
            <td>
                
                
            </td>
        </tr>
        <tr>
            <td>Nombre Producto</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>Marca Producto</td>
            <td>
                <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>Precio Producto</td>
            <td>
                <asp:TextBox ID="txtPrecioProducto" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Stock Producto</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td>Fecha Termino</td>
            <td>
                <asp:Calendar ID="Calendario" runat="server"></asp:Calendar>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar Producto" OnClick="btnAgregar_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>


</asp:Content>
