<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormInventario.aspx.cs" Inherits="App_Facturacion.Views.WebFormInventario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Nueva categoría</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <asp:Label CssClass="form-label" ID="Label1" runat="server" Text="Nueva categoría"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtNuevaCategoria" runat="server"></asp:TextBox>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                        <button type="button" class="btn btn-primary" runat="server">Guardar</button>
                    </div>
                </div>
            </div>
        </div>
        <div class="card ">
            <div class="card-header"> 
                <ul class="nav nav-tabs card-header-tabs pull-right"  id="myTab" role="tablist">
                    <li class="nav-item">
                        <a class="nav-link active" id="inventario-tab" data-toggle="tab" href="#inventario" role="tab" aria-controls="inventario" aria-selected="true">Inventario</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" id="articulo-tab" data-toggle="tab" href="#articulo" role="tab" aria-controls="articulo" aria-selected="false">Artículo</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" id="bodega-tab" data-toggle="tab" href="#bodega" role="tab" aria-controls="bodega" aria-selected="false">Bodega</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" id="seccion-tab" data-toggle="tab" href="#seccion" role="tab" aria-controls="seccion" aria-selected="false">Sección</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" id="estante-tab" data-toggle="tab" href="#estante" role="tab" aria-controls="estante" aria-selected="false">Estante</a>
                    </li>
                </ul>
            </div>
            <div class="card-body">
                <div class="tab-content" id="myTabContent">
                    <div class="tab-pane fade show active" id="inventario" role="tabpanel" aria-labelledby="inventario-tab">
                        <div class="col-12">
                            <h4 class="text-center">Inventario</h4>
                            <div class="row">
                                <div class="col-10">
                                    <div class="row">
                                        <div class="col-4">
                                            <asp:Label CssClass="form-label" ID="LDBSurcursal" runat="server" Text="Sucursal"></asp:Label>
                                            <asp:DropDownList CssClass="form-control" ID="DBSurcursal" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="col-4">
                                            <asp:Label CssClass="form-label" ID="LtxtCantidad" runat="server" Text="Cantidad"></asp:Label>
                                            <asp:TextBox CssClass="form-control" ID="txtCantidad" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-4">
                                            <asp:Label CssClass="form-label" ID="LtxtMinimo" runat="server" Text="Cantidad mínima"></asp:Label>
                                             <asp:TextBox CssClass="form-control" ID="txtMinimo" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-4">
                                            <asp:Label CssClass="form-label" ID="LtxtMaximo" runat="server" Text="Cantidad máxima"></asp:Label>
                                            <asp:TextBox CssClass="form-control" ID="txtMaximo" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-4">
                                            <asp:Label CssClass="form-label" ID="LtxtPrecio" runat="server" Text="Precio"></asp:Label>
                                            <asp:TextBox CssClass="form-control" ID="txtPrecio" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-4">
                                            <asp:Label CssClass="form-label" ID="LtxtDate" runat="server" Text="Fecha de caducidad"></asp:Label>
                                            <input class="form-control" runat="server" id="txtDate" type="date" />
                                        </div>
                                    </div>

                                </div>    

                                <div class="col-2">
                                     <asp:Label CssClass="form-label" ID="Label2" runat="server" Text="Acciones"></asp:Label>
                                    <div class="btn-group-vertical">
                                        <asp:Button CssClass="btn btn-primary" ID="btnAgregarInventario" runat="server" Text="Agregar" />
                                        <asp:Button CssClass="btn btn-info" ID="btnModificarInventario" runat="server" Text="Modificar" />
                                        <asp:Button CssClass="btn btn-danger" ID="btnEliminarInventario" runat="server" Text="Eliminar" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-12">
                            <asp:GridView ID="GVInventario" runat="server" CssClass="table table-hover"  >
                                <Columns>
                                    <asp:ButtonField Text="Eliminar" />
                                </Columns>
                                <HeaderStyle CssClass="thead-dark" />
                            </asp:GridView>
                        </div>
                    </div>
                    <div class="tab-pane fade" id="articulo" role="tabpanel" aria-labelledby="articulo-tab">
                        <div class="col-12">
                            <h4 class="text-center">Artículo</h4>
                            <div class="row">
                                <div class="col-10">
                                    <div class="row">
                                        <div class="col-4">
                                            <asp:Label CssClass="form-label" ID="LCBProveedor" runat="server" Text="Proveedor"></asp:Label>
                                            <asp:DropDownList CssClass="form-control" ID="CBProveedor" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="col-4">
                                            <asp:Label CssClass="form-label" ID="LCBCategoria" runat="server" Text="Categoría"></asp:Label>
                                            <div class="input-group">
                                                <asp:DropDownList CssClass="form-control" ID="CBCategoria" runat="server"></asp:DropDownList>
                                                <div class="input-group-append">
                                                    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
                                                      Nueva categoría
                                                    </button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-4">
                                            <asp:Label CssClass="form-label" ID="LtxtDescripcion" runat="server" Text="Descripción"></asp:Label>
                                            <asp:TextBox CssClass="form-control" ID="txtDescripcion" runat="server"></asp:TextBox>
                                        </div>
                                    </div>  
                                </div>
                                <div class="col-2">
                                    <asp:Label CssClass="form-label" ID="Label3" runat="server" Text="Acciones"></asp:Label>
                                    <div class="btn-group-vertical">
                                        <asp:Button CssClass="btn btn-primary" ID="btnAgregarArticulo" runat="server" Text="Agregar" />
                                        <asp:Button CssClass="btn btn-info" ID="btnModificarArticulo" runat="server" Text="Modificar" />
                                        <asp:Button CssClass="btn btn-danger" ID="btnEliminarArticulo" runat="server" Text="Eliminar" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-12">
                            <asp:GridView ID="GVArticulo" runat="server" CssClass="table table-hover"  >
                                <Columns>
                                    <asp:ButtonField Text="Eliminar" />
                                </Columns>
                                <HeaderStyle CssClass="thead-dark" />
                            </asp:GridView>
                        </div>
                    </div>
                    <div class="tab-pane fade" id="bodega" role="tabpanel" aria-labelledby="bodega-tab">
                        <div class="col-12">
                            <h4 class="text-center">Bodega</h4>
                            <div class="row">
                                <div class="col-10">
                                    <div class="row">
                                        <div class="col-4">
                                            <asp:Label CssClass="form-label" ID="LtxtNomBodega" runat="server" Text="Nombre"></asp:Label>
                                            <asp:TextBox CssClass="form-control" ID="txtNomBodega" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-4">
                                            <asp:Label CssClass="form-label" ID="LtxtUbicacionBodega" runat="server" Text="Ubicación"></asp:Label>
                                            <asp:TextBox CssClass="form-control" ID="txtUbicacionBodega" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-2">
                                    <asp:Label CssClass="form-label" ID="Label4" runat="server" Text="Acciones"></asp:Label>
                                    <div class="btn-group-vertical">
                                        <asp:Button CssClass="btn btn-primary" ID="btnAgregarBodega" runat="server" Text="Agregar" />
                                        <asp:Button CssClass="btn btn-info" ID="btnModificarBodega" runat="server" Text="Modificar" />
                                        <asp:Button CssClass="btn btn-danger" ID="btnEliminarBodega" runat="server" Text="Eliminar" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-12">
                            <asp:GridView ID="GVBodega" runat="server" CssClass="table table-hover"  >
                                <Columns>
                                    <asp:ButtonField Text="Eliminar" />
                                </Columns>
                                <HeaderStyle CssClass="thead-dark" />
                            </asp:GridView>
                        </div>
                    </div>
                    <div class="tab-pane fade" id="estante" role="tabpanel" aria-labelledby="estante-tab">
                        <div class="col-12">
                            <h4 class="text-center">Estante</h4>
                            <div class="row">
                                <div class="col-10">
                                    <div class="row">
                                        <div class="col-4">
                                            <asp:Label CssClass="form-label" ID="LCBBodega" runat="server" Text="Bodega"></asp:Label>
                                            <asp:DropDownList CssClass="form-control" ID="CBBodega" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="col-4">
                                            <asp:Label CssClass="form-label" ID="LtxtDescripcionEstante" runat="server" Text="Descripción"></asp:Label>
                                            <asp:TextBox CssClass="form-control" ID="txtDescripcionEstante" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-2">
                                    <asp:Label CssClass="form-label" ID="Label5" runat="server" Text="Acciones"></asp:Label>
                                    <div class="btn-group-vertical">
                                        <asp:Button CssClass="btn btn-primary" ID="btnAgregarEstante" runat="server" Text="Agregar" />
                                        <asp:Button CssClass="btn btn-info" ID="btnModificarEstante" runat="server" Text="Modificar" />
                                        <asp:Button CssClass="btn btn-danger" ID="btnEliminarEstante" runat="server" Text="Eliminar" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-12">
                            <asp:GridView ID="GVEstante" runat="server" CssClass="table table-hover"  >
                                <Columns>
                                    <asp:ButtonField Text="Eliminar" />
                                </Columns>
                                <HeaderStyle CssClass="thead-dark" />
                            </asp:GridView>
                        </div>
                    </div>
                    <div class="tab-pane fade" id="seccion" role="tabpanel" aria-labelledby="seccion-tab">
                        <div class="col-12">
                            <h4 class="text-center">Sección</h4>
                            <div class="row">
                                <div class="col-10">
                                    <div class="row">
                                        <div class="col-4">
                                            <asp:Label CssClass="form-label" ID="LCBSeccion" runat="server" Text="Sección"></asp:Label>
                                            <asp:DropDownList CssClass="form-control" ID="CBSeccion" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="col-4">
                                            <asp:Label CssClass="form-label" ID="LtxtDescripcionSeccion" runat="server" Text="Descripción"></asp:Label>
                                            <asp:TextBox CssClass="form-control" ID="txtDescripcionSeccion" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-2">
                                    <asp:Label CssClass="form-label" ID="Label6" runat="server" Text="Acciones"></asp:Label>
                                    <div class="btn-group-vertical">
                                        <asp:Button CssClass="btn btn-primary" ID="btnAgregarSeccion" runat="server" Text="Agregar" />
                                        <asp:Button CssClass="btn btn-info" ID="btnModificarSeccion" runat="server" Text="Modificar" />
                                        <asp:Button CssClass="btn btn-danger" ID="btnEliminarSeccion" runat="server" Text="Eliminar" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-12">
                            <asp:GridView ID="GVSeccion" runat="server" CssClass="table table-hover"  >
                                <Columns>
                                    <asp:ButtonField Text="Eliminar" />
                                </Columns>
                                <HeaderStyle CssClass="thead-dark" />
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
