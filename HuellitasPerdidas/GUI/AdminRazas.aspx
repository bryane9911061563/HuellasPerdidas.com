<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/HuellasPerdidas_admin.Master" AutoEventWireup="true" enableEventValidation="false" CodeBehind="AdminRazas.aspx.cs" Inherits="HuellitasPerdidas.GUI.AdminRazas" %>
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
                      

                    
                    <h3 class="mb-0">
                        <a href="PanelAdministrativo.aspx" class="btn btn-default btn-circle">
                            <img class="fas"src="../Recursos/img2/Back_22px.png" style="text-align:center;width:50%;margin-bottom:3px" />

                      </a>&nbsp;&nbsp;&nbsp;&nbsp;Administracion de razas

                    </h3>
                </div>

                      
              </div>
            </div>
            <div class="card-body">
                <asp:TextBox ID="txtIdRaza" runat="server" Visible="False"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text="Seleccione la especie a la que pertenece la raza:"></asp:Label>&nbsp;

                <asp:DropDownList ID="DDL_eapecies" runat="server" CssClass="btn btn-secondary dropdown-toggle">
                </asp:DropDownList><br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Nombre de la raza:"></asp:Label>
                <asp:TextBox ID="txtnombreraza" runat="server" CssClass="form form-control"></asp:TextBox>
                <br />
                <asp:Button ID="btn_agregar" runat="server" Text="Agregar" CssClass="btn " OnClick="btn_agregar_Click" />
                <asp:Button ID="btn_modificar" runat="server" Text="Modificar" CssClass="btn" OnClick="btn_modificar_Click" />
                <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" CssClass="btn btn-warning" />
            </div>
          </div>
        </div>
     </div>
         </div>
          
      


    </div>

    <br />
    <br />
    <div class="formulariopadding row" style="margin-left:3px;margin-right:3px;">
        <div class="col-md-12">
            <asp:GridView ID="gv_razas" runat="server" CssClass="table table-hover" OnRowDataBound="gv_razas_RowDataBound" OnSelectedIndexChanged="gv_razas_SelectedIndexChanged"></asp:GridView>
        </div>
    </div>
</asp:Content>
