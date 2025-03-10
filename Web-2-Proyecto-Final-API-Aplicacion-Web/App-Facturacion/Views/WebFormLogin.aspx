<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormLogin.aspx.cs" Inherits="App_Facturacion.Views.WebFormLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
       <div class="vh-100 mx-auto col-12 col-lg-4" >
           <div class="align-self-center" style="height:500px">
                <div class="m-2">
                    <asp:Label for="txtUser" ID="Label1" runat="server" Text="Usuario" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtUser" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="m-2">
                    <asp:Label for="txtPassword" ID="Label2" runat="server" Text="Contraseña" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="m-2">
                    <asp:Button ID="btnJoin" runat="server" Text="Iniciar Sección" CssClass="btn btn-primary form-control" OnClick="btnJoin_Click"/>
                </div>
            </div>
       </div>
   </div>
</asp:Content>
