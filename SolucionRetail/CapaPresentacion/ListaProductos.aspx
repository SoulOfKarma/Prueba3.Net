<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ListaProductos.aspx.cs" Inherits="CapaPresentacion.ListaProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
    <asp:GridView ID="gvLista" runat="server" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="gvLista_PageIndexChanging" DataKeyNames="Idproducto" >
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Idproducto" HeaderText="Idproducto" SortExpression="Idproducto" />
            <asp:BoundField DataField="Nombreproducto" HeaderText="Nombreproducto" SortExpression="Nombreproducto" />
            <asp:BoundField DataField="Marcaproducto" HeaderText="Marcaproducto" SortExpression="Marcaproducto" />
            <asp:BoundField DataField="Precioproducto" HeaderText="Precioproducto" SortExpression="Precioproducto" />
            <asp:BoundField DataField="Stockproducto" HeaderText="Stockproducto" SortExpression="Stockproducto" />
            <asp:BoundField DataField="Fechaterminosubasta" HeaderText="Fechaterminosubasta" SortExpression="Fechaterminosubasta" />
            <asp:BoundField DataField="Idretail" HeaderText="Idretail" SortExpression="Idretail" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    </asp:Content>
