<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/HuellasPerdidas_admin.Master" AutoEventWireup="true" CodeBehind="AdminEspecies.aspx.cs" Inherits="HuellitasPerdidas.GUI.AdminEspecies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Recursos/css/formulariosstyle.css" rel="stylesheet" />
    <link href="../Recursos/css/argon.css" rel="stylesheet" />
    <link href="../Recursos/css/argon.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="formulariopadding">
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
                  <h3 class="mb-0">Administracion de especies</h3>
                </div>

                      
              </div>
            </div>
            <div class="card-body">
                <asp:TextBox ID="txtID_especie" runat="server" Visible="False"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text="Nombre de especie:"></asp:Label>
                <asp:TextBox ID="txtNombreespecie" runat="server" CssClass="form form-control"></asp:TextBox>
                <br />
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn" OnClick="btnAgregar_Click" />
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-warning" />
              
            </div>
          </div>
        </div>
          
      </div>
            <div class="row">
                <div class="col-md-12">

                    <br />
                    <asp:GridView ID="gv_especies" runat="server" CssClass="table table-hover" OnSelectedIndexChanged="IndexChanged" OnDataBound="gv_especies_DataBound"></asp:GridView>
                </div>
            </div>
            
     
    </div>


    </div>

</asp:Content>
