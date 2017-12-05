<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CapaPresentacion.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 750px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



  



    <table style="width: 100%;">
        <tr>
            <td class="auto-style1">
    <asp:Button ID="btnLoginAdministrativo" runat="server" Text="Login Administrativo" OnClick="btnLoginAdministrativo_Click" />
    



            </td>
        </tr>
        <tr>
            <td class="auto-style1">



  



    <asp:Button ID="btnLoginUsuario" runat="server" Text="Login Cliente" OnClick="btnLoginUsuario_Click" />
            </td>
        </tr>
        </table>





</asp:Content>
