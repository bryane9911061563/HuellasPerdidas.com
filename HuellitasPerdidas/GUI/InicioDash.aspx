<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/DashBoard.Master" AutoEventWireup="true" CodeBehind="InicioDash.aspx.cs" Inherits="HuellitasPerdidas.GUI.InicioDash" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="row" style="margin-left:5px;margin-right:5px">
                    <div class="col-lg-3 col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <div class="text-center">
                                    <img src="../Recursos/RecursosDASHBOARD/BRYAN%20EDILBERTO%20POOL%20MERCADO.jpg" style="width:50%" class="rounded-circle" alt=""/>
                                    <h5 class="mt-3 mb-1">Usuarios</h5>
                                    <p class="m-0">Administra los usuarios registrados</p>
                                    <a href="adminUsuarios_DASH.aspx" class="btn mb-1 btn-warning">Administrar</a>

                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3 col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <div class="text-center">
                                    <img src="../Recursos/RecursosDASHBOARD/mapa_estados_mexico.png"style="width:117px;height:117px" class="rounded-circle" alt=""/>
                                    <h5 class="mt-3 mb-1">Estados</h5>
                                    <p class="m-0">Administra los estados disponibles</p>
                                    <a href="administracionEstados_DASH.aspx" class="btn mb-1 btn-warning">Administrar</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3 col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <div class="text-center">
                                    <img src="../Recursos/RecursosDASHBOARD/Mulberry_Street.jpg" style="width:117px;height:117px" class="rounded-circle" alt=""/>
                                    <h5 class="mt-3 mb-1">Ciudades</h5>
                                    <p class="m-0">Gestiona las ciudades por estados</p>
                                    <button type="button" class="btn mb-1 btn-warning">Administrar</button>                                
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3 col-sm-6">
                        <div class="card">
                            <div class="card-body">
                                <div class="text-center">
                                    <img src="../Recursos/RecursosDASHBOARD/map-locations.jpg" style="width:117px;height:117px" class="rounded-circle" alt=""/>
                                    <h5 class="mt-3 mb-1">Zonas</h5>
                                    <p class="m-0">Administra las zonas por cada ciudad</p>
                                    <button type="button" class="btn mb-1 btn-warning">Administrar</button>                                
                                </div>
                            </div>
                        </div>
                    </div>

                </div>


</asp:Content>
