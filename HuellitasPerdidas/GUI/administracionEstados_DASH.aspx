<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/DashBoard.Master" enableEventValidation="false" AutoEventWireup="true" CodeBehind="administracionEstados_DASH.aspx.cs" Inherits="HuellitasPerdidas.GUI.administracionEstados_DASH" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<%--    <script>

        function validar_form() {

            validado = false;
            if ($("#<%=txtNombreEstado.ClientID%>").val().length <= 0) {
                $.alert({
                    title: 'Campos imcompletos',
                    type: 'orange',
                    content: 'El nombre del estado no puede estar vacio',
                });

            }

            else {
                validado = true;
            }

            return validado;
        }

    </script>--%>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!--**********************************
            Content body start
        ***********************************-->
        <div class="content-body">

           

            <!-- row -->

            <div class="container-fluid">
                <div class="row justify-content-center">
                    <div class="col-lg-12">
                        <div class="card">
                            <div class="card-body">
                                <h4 class="card-title">Estados</h4>
                                <div class="form-validation">


                                        <div class="form-group row">
                                            <label class="col-lg-4 col-form-label" for="val-username">Nombre del estado <span class="text-danger">*</span>
                                            </label>
                                            <div class="col-lg-6">
                                                <asp:TextBox ID="txtId_Estado" runat="server" Visible="False"></asp:TextBox>
                                                <asp:TextBox ID="txtNombreEstado"  runat="server" CssClass="form-control" ></asp:TextBox>

                                            </div>
                                        </div>
                                        
                                       
                                        <div class="form-group row">
                                            <div class="col-lg-8 ml-auto">
                                                <asp:Button ID="btn_guardar" onClientClick="return validar_form();" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btn_guardar_Click" />
                                                <asp:Button ID="btn_guardarcomo" runat="server" Text="Guardar cambios" CssClass="btn btn-primary" OnClick="btn_guardarcomo_Click" />
                                                <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btn_eliminar_Click" />
                                            </div>
                                        </div>
                                </div>
                            </div>
                         
                        </div>
                    </div>
                </div>
                 <div class="row justify-content-center">
                    <div class="col-lg-12">
                        <div class="card">
                            <div class="card-body">
                                <h4 class="card-title">Lista de registros</h4>
                                <div class="form-validation">
                                    <div class="row">
                                        <div class="col-sm-12">
                                    <asp:GridView ID="gv_estados" runat="server" CssClass="table table-striped table-bordered zero-configuration dataTable" OnRowDataBound="gv_estados_RowDataBound" OnSelectedIndexChanged="gv_estados_SelectedIndexChanged"></asp:GridView>
                                        </div>
                                    </div>

                                </div>
                            </div>
                         
                        </div>
                    </div>
                </div>
            </div>
            <!-- #/ container -->
        </div>

    <!---------------------grideview------------------------------>

           

            <!-- row -->

               
            
            <!-- #/ container -->




</asp:Content>
