<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormAdministracion.aspx.cs" Inherits="App_Facturacion.Views.WebFormAdministracion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
<div class="card ">
            <div class="card-header"> 
                <ul class="nav nav-tabs card-header-tabs pull-right"  id="myTab" role="tablist">
                    <li class="nav-item">
                        <a class="nav-link active" id="Empresa-tab" data-toggle="tab" href="#Empresa" role="tab" aria-controls="Empresa" aria-selected="true">Empresa</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" id="Sucursal-tab" data-toggle="tab" href="#Sucursal" role="tab" aria-controls="Sucursal" aria-selected="false">Sucursales</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" id="Empleados-tab" data-toggle="tab" href="#Empleados" role="tab" aria-controls="Empleados" aria-selected="false">Empleados</a>
                    </li>
                </ul>
            </div>

            <div class="card-body">
                <div class="tab-content" id="myTabContent">
                    <div class="tab-pane fade show active" id="Empresa" role="tabpanel" aria-labelledby="Empresa-tab">
                        <h4 class="text-center">Empresa</h4>
                        <div class="row">
                            <div class="col-10">
                                <div class="row">
                                    <div class="col-4">
                                        <asp:Label CssClass="form-label" ID="LtxtNombreEmpresa" runat="server" Text="Empresa"></asp:Label>
                                        <asp:TextBox CssClass="form-control" ID="txtNombreEmpresa" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-4">
                                        <asp:Label CssClass="form-label" ID="Label1" runat="server" Text="Logo"></asp:Label>
                                        <input class="form-control" runat="server" id="Logo" type="file" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-2">
                                <asp:Label CssClass="form-label" ID="Label2" runat="server" Text="Acciones"></asp:Label>
                                <div class="btn-group-vertical">
                                    <asp:Button CssClass="btn btn-primary" ID="btnAgregarEmpresa" runat="server" Text="Agregar" />
                                    <asp:Button CssClass="btn btn-info" ID="btnModificarEmpresa" runat="server" Text="Modificar" />
                                    <asp:Button CssClass="btn btn-danger" ID="btnEliminarEmpresa" runat="server" Text="Eliminar" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="tab-pane fade" id="Sucursal" role="tabpanel" aria-labelledby="Sucursal-tab">
                        <h4 class="text-center">Sucursales</h4>
                        <div class="row">
                            <div class="col-10">
                                <div class="row">
                                    <div class="col-4">
                                        <asp:Label CssClass="form-label" ID="LtxtSucursal" runat="server" Text="Sucursal"></asp:Label>
                                        <asp:TextBox CssClass="form-control" ID="txtSucursal" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-4">
                                        <asp:Label CssClass="form-label" ID="LtxtUbicacionSucursal" runat="server" Text="Ubicación"></asp:Label>
                                        <asp:TextBox CssClass="form-control" ID="txtUbicacionSucursal" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-2">
                                <asp:Label CssClass="form-label" ID="Label3" runat="server" Text="Acciones"></asp:Label>
                                <div class="btn-group-vertical">
                                    <asp:Button CssClass="btn btn-primary" ID="btnAgregarSucursal" runat="server" Text="Agregar" />
                                    <asp:Button CssClass="btn btn-info" ID="btnModificarSucursal" runat="server" Text="Modificar" />
                                    <asp:Button CssClass="btn btn-danger" ID="btnEliminarSucursal" runat="server" Text="Eliminar" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="tab-pane fade" id="Empleados" role="tabpanel" aria-labelledby="Empleados-tab">
                        <h4 class="text-center">Empleados</h4>
                        <div class="row">
                            <div class="col-10">
                                <div class="row">
                                    <div class="col-4">
                                        <asp:Label CssClass="form-label" ID="Label4" runat="server" Text="Sucursal"></asp:Label>
                                        <asp:DropDownList  CssClass="form-control" ID="CBSucursal" runat="server"></asp:DropDownList>
                                    </div>
                                    <div class="col-4">
                                        <asp:Label CssClass="form-label" ID="Label5" runat="server" Text="Persona"></asp:Label>
                                        <asp:DropDownList  CssClass="form-control" ID="CBPersona" runat="server"></asp:DropDownList>
                                    </div>
                                    <div class="col-4">
                                        <asp:Label CssClass="form-label" ID="Label6" runat="server" Text="Puesto"></asp:Label>
                                        <asp:DropDownList  CssClass="form-control" ID="CBPuesto" runat="server"></asp:DropDownList>
                                    </div>
                                    <div class="col-4">
                                        <asp:Label CssClass="form-label" ID="Label8" runat="server" Text="Contraseña"></asp:Label>
                                        <input class="form-control" runat="server" id="txtcontrasena" type="password" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-2">
                                <asp:Label CssClass="form-label" ID="Label7" runat="server" Text="Acciones"></asp:Label>
                                <div class="btn-group-vertical">
                                    <asp:Button CssClass="btn btn-primary" ID="btnAgregarEmpleado" runat="server" Text="Agregar" />
                                    <asp:Button CssClass="btn btn-info" ID="btnModificarEmpleado" runat="server" Text="Modificar" />
                                    <asp:Button CssClass="btn btn-danger" ID="btnEliminarEmpleado" runat="server" Text="Eliminar" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
