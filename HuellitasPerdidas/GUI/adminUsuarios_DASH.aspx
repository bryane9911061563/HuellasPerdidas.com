<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/DashBoard.Master" AutoEventWireup="true" CodeBehind="adminUsuarios_DASH.aspx.cs" Inherits="HuellitasPerdidas.GUI.adminUsuarios_DASH" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- row -->

            <div class="container-fluid">
                <div class="row justify-content-center">
                    <div class="col-lg-12">
                        <div class="card">
                            <div class="card-body">
                                <div class="form-validation">
                                        
                                        <div class="form-group row">
                                            <label class="col-lg-4 col-form-label" for="val-email">Correo electronico: <span class="text-danger">*</span>
                                            </label>
                                            <div class="col-lg-6">
                                                <asp:TextBox CssClass="form-control" ID="txtEmail" placeholder="Ingresa un correo valido" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group row">
                                            <label class="col-lg-4 col-form-label" for="val-password">Contraseña <span class="text-danger">*</span>
                                            </label>
                                            <div class="col-lg-6">
                                                <asp:TextBox CssClass="form-control" ID="txt_password" placeholder="Crea una contraseña" runat="server" TextMode="Password"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="form-group row">
                                            <label class="col-lg-4 col-form-label" for="val-confirm-password">Confirmar contraseña <span class="text-danger">*</span>
                                            </label>
                                            <div class="col-lg-6">
                                                <asp:TextBox CssClass="form-control" ID="txt_passwordconfirm" placeholder="Confirma tu contraseña" runat="server" TextMode="Password"></asp:TextBox>
                                            </div>
                                        </div>
                                        
                                        <div class="form-group row">
                                            <label class="col-lg-4 col-form-label" >Nombre(s): <span class="text-danger">*</span>
                                            </label>
                                            <div class="col-lg-6">
                                                <asp:TextBox CssClass="form-control" ID="txtNombre" placeholder="Escribe tu nombre..." runat="server"></asp:TextBox>
                                            </div>
                                        </div>

                                         <div class="form-group row">
                                            <label class="col-lg-4 col-form-label" >Primer apellido: <span class="text-danger">*</span>
                                            </label>
                                            <div class="col-lg-6">
                                                <asp:TextBox CssClass="form-control" ID="txtApellidoP" placeholder="Escribe tu primer apellido..." runat="server"></asp:TextBox>
                                            </div>
                                        </div>

                                          <div class="form-group row">
                                            <label class="col-lg-4 col-form-label" >Segundo apellido: <span class="text-danger">*</span>
                                            </label>
                                            <div class="col-lg-6">
                                                <asp:TextBox CssClass="form-control" ID="txtApellidoM" placeholder="Escribe tu segundo apellido..." runat="server"></asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="form-group row">
                                            <label class="col-lg-4 col-form-label" >Fecha de nacimiento: <span class="text-danger">*</span>
                                            </label>
                                            <div class="col-lg-6">
                                                <asp:TextBox ID="txt_fechanac" runat="server" TextMode="Date" CssClass="form form-control"></asp:TextBox>
                                            </div>
                                        </div>


                                       <div class="form-group row">
                                            <label class="col-lg-4 col-form-label" >Estado: <span class="text-danger">*</span>
                                            </label>
                                            <div class="col-lg-6">
                                                <asp:DropDownList ID="ddl_estado" runat="server" CssClass="form-control"></asp:DropDownList>
                                            </div>
                                        </div>

                                        <div class="form-group row">
                                            <label class="col-lg-4 col-form-label" >Ciudad: <span class="text-danger">*</span>
                                            </label>
                                            <div class="col-lg-6">
                                                <asp:DropDownList ID="ddl_ciudad" runat="server" CssClass="form-control"></asp:DropDownList>
                                            </div>
                                        </div>

                                          <div class="form-group row">
                                            <label class="col-lg-4 col-form-label" >Zona: <span class="text-danger">*</span>
                                            </label>
                                            <div class="col-lg-6">
                                                <asp:DropDownList ID="ddl_zona" runat="server" CssClass="form-control"></asp:DropDownList>
                                            </div>
                                        </div>

                                     
                                        <div class="form-group row">
                                            <label class="col-lg-4 col-form-label" for="val-currency">Direccion: <span class="text-danger">*</span>
                                            </label>
                                            <div class="col-lg-6">
                                                <asp:TextBox CssClass="form-control" ID="txtDireccion" placeholder="Ingresa la direccion donde vives..." runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                       
                                       
                                       <%-- <div class="form-group row">
                                            <label class="col-lg-4 col-form-label"><a href="#">Terms &amp; Conditions</a>  <span class="text-danger">*</span>
                                            </label>
                                            <div class="col-lg-8">
                                                <label class="css-control css-control-primary css-checkbox" for="val-terms">
                                                    <input type="checkbox" class="css-control-input" id="val-terms" name="val-terms" value="1"> <span class="css-control-indicator"></span> I agree to the terms</label>
                                            </div>
                                        </div>--%>
                                        <div class="form-group row">
                                            <div class="col-lg-8 ml-auto">
                                                <asp:Button ID="btn_guardar"  runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btn_guardar_Click"  />
                                            </div>
                                        </div>
                                    
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- #/ container -->
        <
    
    
        <!--**********************************
            Content body end
        ***********************************-->
    <script src="../Recursos/RecursosDASHBOARD/plugins/validation/jquery.validate.min.js"></script>
    <script src="../Recursos/RecursosDASHBOARD/plugins/validation/jquery.validate-init.js"></script>





</asp:Content>
