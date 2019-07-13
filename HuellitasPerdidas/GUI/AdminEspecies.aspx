<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/HuellasPerdidas_admin.Master" AutoEventWireup="true"  enableEventValidation="false" CodeBehind="AdminEspecies.aspx.cs" Inherits="HuellitasPerdidas.GUI.AdminEspecies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Recursos/css/formulariosstyle.css" rel="stylesheet" />
    <link href="../Recursos/css/argon.css" rel="stylesheet" />
    <link href="../Recursos/css/argon.min.css" rel="stylesheet" />
        <link href="../Recursos/css/cirularbutton.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="padding-left:500px">
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <div class="container-fluid mt--7">
      <div class="row">
        

        <div class="col-xl-8 order-xl-1">
          <div class="card bg-secondary shadow">
            <div class="card-header bg-white border-0">
              <div class="row align-items-center">
                <div class="col-8">

                  <a href="PanelAdministrativo.aspx" class="btn btn-default btn-circle">
                            <img class="fas"src="../Recursos/img2/Back_22px.png" style="text-align:center;width:50%;margin-bottom:3px" />

                      </a>&nbsp;&nbsp;&nbsp;&nbsp;<h3 class="mb-0">Administracion de especies</h3>

                </div>

                      
              </div>
            </div>
            <div class="card-body">
                <asp:TextBox ID="txtID_especie" runat="server"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text="Nombre de especie:"></asp:Label>
                <asp:TextBox ID="txtNombreespecie" runat="server" CssClass="form form-control"></asp:TextBox>
                <br />
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn" OnClick="btnAgregar_Click" />
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn" OnClick="btnModificar_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-warning" OnClick="btnEliminar_Click" />
              
            </div>
          </div>
        </div>
          
      </div>
            
            
     
    </div>


    </div>


    <div class="formulariopadding row" style="margin-left:3px;margin-right:3px;">
                <div class="col-md-12">

                    <br />
                    <asp:GridView ID="gv_especies" runat="server" CssClass="table table-hover" OnSelectedIndexChanged="IndexChanged" OnRowDataBound="gv_especies_RowDataBound"></asp:GridView>
                </div>
            </div>
</asp:Content>
