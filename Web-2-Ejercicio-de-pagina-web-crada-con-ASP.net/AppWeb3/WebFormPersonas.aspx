<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormPersonas.aspx.cs" Inherits="AppWeb3.WebFormPersonas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="height: 153px; width: 99%;" class="nav-justified">
        <tr>
            <td style="width: 773px">Cédula</td>
            <td><asp:TextBox ID="txtCedula" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 773px">Nombre</td>
            <td><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="height: 25px; width: 773px;">Primer apellido</td>
            <td style="height: 25px"><asp:TextBox ID="txtApe1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 773px">Segundo Apellido</td>
            <td><asp:TextBox ID="txtApe2" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 773px">Correo</td>
            <td><asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 773px">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 773px">
                <asp:GridView ID="gvPersonas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="770px">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
