<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/AdminMascotas.Master" AutoEventWireup="true" 
    CodeBehind="Raza.aspx.cs" Inherits="ProyectoMarisaEB.GUI.Catalogos.Raza" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="content">
        <div class="main">
            <div class="card border-primary mb-3 tamformulario" >
               <div class="card-header"> Catalogo Razas</div>
               <div class="card-body">
               <p class="card-text">
                   <br />
                   <asp:TextBox runat="server" ID="txtID" Visible="false"></asp:TextBox>
                   <br />
                   <asp:Label ID="Label4" runat="server" Text="Nombre de la raza:"></asp:Label> 
                   <asp:TextBox ID="txt_NombreRaza" runat="server" CssClass="form-control" Width="418px"></asp:TextBox>
                   <br />
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                       ErrorMessage="El campo no puede estar vacio" ControlToValidate="txt_NombreRaza">*</asp:RequiredFieldValidator>
                   <br />
                   <asp:Label ID="Label1" runat="server" Text="Seleccione la especie:"></asp:Label> 
                   <asp:DropDownList ID="cboespecie" runat="server">
                   </asp:DropDownList>
                   <br />
                   <br />
                   <asp:Button ID="btn_Registrar" runat="server" Text="Registrar" Class="btn btn-warning"  CssClass="btn" style="background:#00A65A" OnClick="btn_Registrar_Click" />
                   <asp:Button ID="btn_Modificar" runat="server" Text="Modificar" Class="btn btn-warning" CssClass="btn " style="background:#00A65A" OnClick="btn_Modificar_Click" />
                   <asp:Button ID="btn_Eliminar" runat="server" Text="Eliminar" Class="btn btn-warning" CssClass="btn " style="background:#00A65A" OnClick="btn_Eliminar_Click" />
                    <asp:Button ID="btn_Limpiar" runat="server" Text="Limpiar" Class="btn btn-warning" CssClass="btn" style="background:#00A65A" OnClick="btn_Limpiar_Click" />
                    <h6 class="card-title">&nbsp;</h6>
                   <h6 class="card-title">Buscar Raza:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TxtBusqueda" runat="server" AutoPostBack="True" OnTextChanged="Busqueda"></asp:TextBox>
                       <br /></h6>
               </p>
               </div>
            </div>
        <asp:GridView ID="dgv_razas" runat="server" CssClass="table table-hover"
        OnSelectedIndexChanged="seleccionar_registro" OnRowDataBound="dgvrazas_RowDataBound"
        NullDisplayText="" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#00A65A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
    </div>
    </section>
</asp:Content>
