<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/HuellasPerdidas_admin.Master" AutoEventWireup="true" enableEventValidation="false" CodeBehind="AdminClientes.aspx.cs" Inherits="HuellitasPerdidas.GUI.AdminClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function cambia_nombre() {

            var fileName = $("#<%=fu_perfil.ClientID%>").val();

            $("#<%=fu_perfil.ClientID%>").next('.custom-file-label').html(fileName);

        }

    </script>


    <!--referecnias-->
    <link href="../Recursos/css/formulariosstyle.css" rel="stylesheet" />
    <link href="../Recursos/css/argon.css" rel="stylesheet" />
    <link href="../Recursos/css/argon.min.css" rel="stylesheet" />
    <link href="../Recursos/css/cirularbutton.css" rel="stylesheet" />
    <!---------------->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!------------------------------------------------------------------------------------------------------->
    <div class="row">
        <div class="col-md-12">
         <div >
        <br />
        <br />
        <br />
        <br />
           <br />
        <div style="padding-left:400px; width:1700px !important" class="container-fluid mt--7">
      <div class="row">
        

        <div class="col-xl-8 order-xl-1" >
          <div class="card bg-secondary shadow">
            <div class="card-header bg-white border-0">
              <div class="row align-items-center">
                <div class="col-8">

                  <a href="PanelAdministrativo.aspx" class="btn btn-default btn-circle">
                            <img class="fas"src="../Recursos/img2/Back_22px.png" style="text-align:center;width:50%;margin-bottom:3px" />
                      </a>&nbsp;&nbsp;&nbsp;&nbsp;<h3 class="mb-0">Administracion de usuarios</h3>
                </div>

                      
              </div>
            </div>
            <div class="card-body">
                <asp:TextBox ID="idCliente" runat="server" Visible="False"></asp:TextBox>
                <asp:TextBox ID="txtfotousuario" runat="server" Visible="False"></asp:TextBox>

                <asp:Image ID="foto_perfil" runat="server" />
            <br />
            <br />
            <div class="custom-file">

                <asp:FileUpload ID="fu_perfil" runat="server" CssClass="custom-file-input"/>
                <asp:Label ID="lblBuscar" runat="server" Text="Buscar foto" CssClass="custom-file-label" for="customFile" data-browse="Examinar"></asp:Label>         

                <br />
                <br />
            </div>
                    <asp:Label ID="Label1" runat="server" Text="Nombre(s):"></asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form form-control" ></asp:TextBox>
                
                 <asp:Label ID="Label2" runat="server" Text="Apellido paterno:"></asp:Label>
                <asp:TextBox ID="txtApellidoP" runat="server" CssClass="form form-control"></asp:TextBox>

                <asp:Label ID="Label3" runat="server" Text="Apellido materno:"></asp:Label>
                <asp:TextBox ID="txtApellidoM" runat="server" CssClass="form form-control"></asp:TextBox>
                
                <asp:Label ID="Label4" runat="server" Text="Fecha de nacimiento:"></asp:Label>
                <asp:TextBox ID="txtFechaNac" runat="server" TextMode="Date" CssClass="form form-control"></asp:TextBox>

                <asp:Label ID="Label10" runat="server" Text="Direccion:"></asp:Label>
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form form-control"></asp:TextBox>

                <br />
                <asp:Label ID="Label5" runat="server" Text="Correo electronico:"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form form-control"></asp:TextBox>
                <asp:Label ID="Label6" runat="server" Text="Contraseña:"></asp:Label>
                <asp:TextBox ID="txtPasw" runat="server" CssClass="form form-control"></asp:TextBox>
                <br />
                <div class="form-group">
                    <asp:Label ID="Label7" runat="server" Text="Estado:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="ddlestados" runat="server" CssClass="btn btn-secondary dropdown-toggle"></asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label8" runat="server" Text="Ciudad:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="ddlciudad" runat="server" CssClass="btn btn-secondary dropdown-toggle"></asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label9" runat="server" Text="Zona:"></asp:Label>&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="ddlzona" runat="server" CssClass="btn btn-secondary dropdown-toggle"></asp:DropDownList>                  
                </div>
                
                <br />
                <div style="text-align:center">
                <asp:Button ID="btnAgregar" runat="server" Text="Guardar" CssClass="btn btn-info" OnClick="btnAgregar_Click" />
                <asp:Button ID="btnModificar" runat="server" Text="Guardar cambios" CssClass="btn btn-info"/>
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger"/>
                </div>
                

            </div>
          </div>
        </div>
          
      </div>
            
           </div>
     
    </div>

        
    </div>
        </div>
    <br />
    <div class="formulariopadding row" style="margin-left:3px;margin-right:3px;">
        <div class="col-md-12">
                    <asp:GridView ID="gv_usuarios" CssClass="table table-hover" runat="server" OnRowDataBound="gv_usuarios_RowDataBound" OnSelectedIndexChanged="gv_usuarios_SelectedIndexChanged"></asp:GridView>

        </div>



    </div>





       

    
    <!------------------------------------------------------------------------------------------------------->
</asp:Content>
