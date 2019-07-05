<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/HuellasPerdidas_admin.Master" AutoEventWireup="true" CodeBehind="adminMascotas.aspx.cs" Inherits="HuellitasPerdidas.GUI.adminMascotas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--referecnias-->
    <link href="../Recursos/css/formulariosstyle.css" rel="stylesheet" />
    <link href="../Recursos/css/argon.css" rel="stylesheet" />
    <link href="../Recursos/css/argon.min.css" rel="stylesheet" />
    <link href="../Recursos/css/cirularbutton.css" rel="stylesheet" />
    <!---------------->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="padding-left:300px">
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <div class="container-fluid mt--7" style="width:1500px !important" >
      <div class="row">
        

        <div class="col-xl-8 order-xl-1">
          <div class="card bg-secondary shadow">
            <div class="card-header bg-white border-0">
              <div class="row align-items-center">
                <div class="col-8">
                      

                    
                    <h3 class="mb-0">
                        <a href="PanelAdministrativo.aspx" class="btn btn-default btn-circle">
                            <img class="fas"src="../Recursos/img2/Back_22px.png" style="text-align:center;width:50%;margin-bottom:3px" />

                      </a>&nbsp;&nbsp;&nbsp;&nbsp;Administracion de mascotas

                    </h3>
                </div>

                      
              </div>
            </div>
            <div class="card-body">
                <div class="row">
                    <div class="col-md-12"> 
                       <asp:Image ID="foto_mascota" runat="server" />
                    </div>

                </div>
                <div class="custom-file" style="padding-left:100px;padding-right:100px;">

                <asp:FileUpload ID="fu_mascota" runat="server" CssClass="custom-file-input"/>
                <asp:Label ID="lblBuscar" runat="server" Text="Buscar foto" CssClass="custom-file-label" for="customFile" data-browse="Examinar"></asp:Label>         

                <br />
                <br />
            </div>

                <div class="row">
                    <div class="col-md-2">
                       <asp:Label ID="Label1" runat="server" Text="Nombre de tu mascota:"></asp:Label>&nbsp;
                    </div>

                    <div class="col-md-4">
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form form-control"></asp:TextBox>
                    </div>

                    <div class="col-md-2">
                        <asp:Label ID="Label2" runat="server" Text="Fecha de nacimiento:"></asp:Label>&nbsp;

                    </div>

                    <div class="col-md-4">
                        <asp:TextBox ID="txtFechaNac" runat="server" CssClass="form form-control"></asp:TextBox>

                    </div>
                </div>
                <br />
                 <div class="row" style="padding-left:45px;padding-right:45px;">
                    <div class="col-md-2">
                       <asp:Label ID="Label3" runat="server" Text="Zona de extravio:"></asp:Label>&nbsp;
                    </div>

                    <div class="col-md-2">
                        <asp:DropDownList ID="ddl_zona" runat="server" CssClass="btn btn-secondary dropdown-toggle"></asp:DropDownList>
                    </div>
                     

                    <div class="col-md-2">
                        <asp:Label ID="Label4" runat="server" Text="Especie:"></asp:Label>&nbsp;

                    </div>

                    <div class="col-md-2">
                        <asp:DropDownList ID="ddl_especie" runat="server" CssClass="btn btn-secondary dropdown-toggle"></asp:DropDownList>
                    </div>
                     <div class="col-md-2">
                       <asp:Label ID="Label5" runat="server" Text="Raza:" ></asp:Label>&nbsp;
                    </div>

                    <div class="col-md-2">
                       <asp:DropDownList ID="ddl_raza" runat="server" CssClass="btn btn-secondary dropdown-toggle"></asp:DropDownList>

                    </div>
                </div>



                

               
            </div>
          </div>
        </div>
     </div>
         </div>
          
      


    </div>

    <br />
    <br />





</asp:Content>
