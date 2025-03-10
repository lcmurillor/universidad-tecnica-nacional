<%@ Page Title="Facturacion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormFacturacion.aspx.cs" Inherits="App_Facturacion.Views.WebFormFacturacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">

        <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Agregar un nuevo cliente</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="my-1">
                            <asp:Label CssClass="form-label" ID="Label3" runat="server" Text="Persona"></asp:Label>
                            <asp:DropDownList CssClass="form-control" ID="CBPersona" runat="server"></asp:DropDownList>
                        </div>
                        <div class="my-1">
                            <asp:Label CssClass="form-label" ID="Label1" runat="server" Text="Correo electronico"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="txtCorreo" runat="server"></asp:TextBox>
                        </div>
                        <div class="my-1">
                            <asp:Label CssClass="form-label" ID="Label2" runat="server" Text="Número de teléfono"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="txtTelefono" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                        <button type="button" class="btn btn-primary">Guardar</button>
                    </div>
                </div>
            </div>
        </div>

        <div class="card ">
            <div class="card-header">
                <ul class="nav nav-tabs card-header-tabs pull-right" id="myTab" role="tablist">
                    <li class="nav-item">
                        <a class="nav-link active" id="facturar-tab" data-toggle="tab" href="#facturar" role="tab" aria-controls="facturar" aria-selected="true">Facturación</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" id="anular-tab" data-toggle="tab" href="#anular" role="tab" aria-controls="anular" aria-selected="false">Anular factura</a>
                    </li>
                </ul>
            </div>
            <div class="card-body">
                <div class="tab-content" id="myTabContent">
                    <div class="tab-pane fade show active" id="facturar" role="tabpanel" aria-labelledby="facturar-tab">
                        <div class="row">
                            <div class="col-8">
                                <asp:Label CssClass="form-label" ID="LCliente" runat="server" Text="Cliente"></asp:Label>
                                <div class="input-group">
                                    <asp:DropDownList CssClass="form-control h-5" ID="cboCliente" runat="server"></asp:DropDownList>
                                    <div class="input-group-append">
                                        <button type="button" class="btn btn-secondary form-control" data-toggle="modal" data-target="#exampleModal">
                                            Nuevo cliente</button>
                                    </div>
                                </div>

                            </div>
                            <div class="col-4 ">
                                <div class="d-flex">
                                    <div class="form-group">
                                        <asp:Label CssClass="form-label" ID="Label5" runat="server" Text="Fecha"></asp:Label>
                                        <asp:TextBox CssClass="form-control" ID="txtFecha" runat="server" Enabled="false"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label CssClass="form-label" ID="Label4" runat="server" Text="# Factura"></asp:Label>
                                        <asp:TextBox CssClass="form-control" ID="txtNumeroFactura" runat="server" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Label CssClass="form-label" for="TipoFactura" ID="lTipo" runat="server" Text="Tipo de factura"></asp:Label>
                                    <div>
                                        <div class="form-check form-check-inline">
                                            <input class="form-check-input" type="radio" name="inlineRadioOptions" id="inlineRadioContado" value="D" checked />
                                            <label class="form-check-label" for="inlineRadioContado">Contado</label>
                                        </div>
                                        <div class="form-check form-check-inline">
                                            <input class="form-check-input" type="radio" name="inlineRadioOptions" id="inlineRadioCredito" value="C" />
                                            <label class="form-check-label" for="inlineRadioCredito">Credito</label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-12">
                                <div class=" input-group">
                                    <asp:DropDownList CssClass="form-control" ID="cboProducto" runat="server"></asp:DropDownList>
                                    <div class="input-group-append">
                                        <asp:TextBox CssClass="btn btn-outline-success form-control" ID="txtCantidad" runat="server" ToolTip="Cantidad"></asp:TextBox>
                                        <asp:TextBox CssClass="form-control" ID="txtDescuento" runat="server" Text="0" ToolTip="Descuento"></asp:TextBox>
                                        <asp:Button CssClass="btn btn-outline-success" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" Style="width: 82px" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-12">
                            <asp:GridView ID="tablaDetalleFactura" runat="server" CssClass="table table-hover" OnSelectedIndexChanged="tablaDetalleFactura_SelectedIndexChanged" AutoGenerateColumns="False" AutoGenerateDeleteButton="True">
                                <Columns>
                                    <asp:BoundField HeaderText="#Linea" />
                                    <asp:BoundField HeaderText="Código" />
                                    <asp:BoundField HeaderText="Producto" />
                                    <asp:BoundField HeaderText="Cant." />
                                    <asp:BoundField HeaderText="Precio" />
                                    <asp:BoundField HeaderText="Descuento" />
                                    <asp:BoundField HeaderText="Impuesto" />
                                    <asp:BoundField HeaderText="Total" />
                                </Columns>
                                <HeaderStyle CssClass="thead-dark" />
                            </asp:GridView>
                        </div>
                        <div class="col-6">
                            <div class="d-flex justify-content-end p-2 border">
                                <div class="row row-cols-1">
                                    <div class="col form-inline">
                                        <label for="txtSubtotal" class="form-label mx-2">Subtotal:</label>
                                        <asp:TextBox ReadOnly="true" CssClass="form-control-plaintext" ID="txtSubtotal" runat="server" Text="0"></asp:TextBox>
                                    </div>
                                    <div class="col form-inline">
                                        <label for="txtIvaFactura" class="form-label mx-2">IVA:</label>
                                        <asp:TextBox ReadOnly="true" CssClass="form-control-plaintext" ID="txtIvaFactura" runat="server" Text="13"></asp:TextBox>
                                    </div>
                                    <div class="col form-inline">
                                        <label for="txtDescuentoFactura" class="form-label mx-2">Descuento:</label>
                                        <asp:TextBox ReadOnly="true" CssClass="form-control-plaintext" ID="txtDescuentoFactura" runat="server" Text="0"></asp:TextBox>
                                    </div>
                                    <div class="col form-inline">
                                        <label for="txtTotalFactura" class="form-label mx-2">Total:</label>
                                        <asp:TextBox ReadOnly="true" CssClass="form-control-plaintext" ID="txtTotalFactura" runat="server" Text="0"></asp:TextBox>
                                    </div>
                                    <div class="col mx-2">
                                        <asp:Button CssClass="btn btn-success form-control" ID="btnFinalizar" runat="server" Text="Finalizar factura" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="tab-pane fade" id="anular" role="tabpanel" aria-labelledby="anular-tab">
                        <div class="row">
                            <div class="col-12 my-2">
                                <div class="input-group">
                                    <asp:TextBox CssClass="form-control" ID="txtAnularFactura" runat="server"></asp:TextBox>
                                    <div class="input-group-append">
                                        <asp:Button CssClass="btn btn-outline-secondary form-control" ID="btnBuscar" runat="server" Text="Buscar factura" />
                                        <asp:Button CssClass="btn btn-outline-secondary form-control" ID="btnAnular" runat="server" Text="Anular factura" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-12">
                                <table class="table table-hover">
                                    <thead>
                                        <tr>
                                            <th scope="col">#</th>
                                            <th scope="col">Artículo</th>
                                            <th scope="col">Cantidad</th>
                                            <th scope="col">Precio</th>
                                        </tr>
                                    </thead>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
