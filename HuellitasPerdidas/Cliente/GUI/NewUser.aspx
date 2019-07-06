<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente/GUI/UserContent.Master" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="PeludosPerdidos.GUI.NewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="newustitle">Para poder publicar para buscar a tu perrito, deberas crear una cuenta y asi nos mantendremos en contacto</p>
    <div style="padding: 14% 30%;background:#47d337;margin-top: -10px;">
        <a href="../index.aspx"><div class="col-sm-12 backbutton" style="font-size: 50px;left: -50%;" >◄ BACK </div></a>
        <Table style="background: green;border-radius: 20px;">
             <tr>
                <th style="padding: 18px 10px;border-right: solid;border-bottom: solid;">Nombrer:</th>
                <th style="padding: 18px 10px;border-bottom: solid;">
                    <asp:TextBox ID="TextBox1" runat="server" style="border-radius: 6px;"></asp:TextBox>
                 </th>
             </tr>  
            <tr>
                <th style="padding: 18px 10px;border-right: solid;border-bottom: solid;">Apellido Paterno:</th>
                <th style="padding: 18px 10px;border-bottom: solid;">
                    <asp:TextBox ID="TextBox2" runat="server" style="border-radius: 6px;"></asp:TextBox>
                </th>
            </tr>
            <tr>
                <th style="padding: 18px 10px;border-right: solid;border-bottom: solid;">Apellido Materno:</th>
                <th style="padding: 18px 10px;border-bottom: solid;">
                    <asp:TextBox ID="TextBox7" runat="server" style="border-radius: 6px;"></asp:TextBox>
                </th>
            </tr>
            <tr>
                <th style="padding: 18px 10px;border-right: solid;border-bottom: solid;">Direccion:</th>
                <th style="padding: 18px 10px;border-bottom: solid;">
                    <asp:TextBox ID="TextBox3" runat="server" style="border-radius: 6px;"></asp:TextBox>
                </th>
            </tr>
            <tr>
                <th style="padding: 18px 10px;border-right: solid;border-bottom: solid;">Correo:</th>
                <th style="padding: 18px 10px;border-bottom: solid;">
                    <asp:TextBox ID="TextBox4" runat="server" style="border-radius: 6px;"></asp:TextBox>
                </th>
            </tr>
            <tr>
                <th style="padding: 18px 10px;border-right: solid;border-bottom: solid;">Contraseña:</th>
                <th style="padding: 18px 10px;border-bottom: solid;">
                    <asp:TextBox ID="TextBox5" runat="server" style="border-radius: 6px;"></asp:TextBox>
                </th>
            </tr>
            <tr>
                <th style="padding: 18px 10px; border-right:solid;">Confirmar:</th>
                <th  style="padding: 18px 10px;">
                    <asp:TextBox ID="TextBox6" runat="server" style="border-radius: 6px;"></asp:TextBox>
                </th>
            </tr>

            <tr>
                <th style="padding: 18px 10px; border-right:solid;">Estado:</th>
                <th  style="padding: 18px 10px;">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </th>
            </tr>
            <tr>
                <th style="padding: 18px 10px; border-right:solid;">Ciudad:</th>
                <th  style="padding: 18px 10px;">
                    <asp:DropDownList ID="DropDownList2" runat="server">
                    </asp:DropDownList>
                </th>
            </tr>
            <tr>
                <th style="padding: 18px 10px; border-right:solid;">Zona:
                </th>
                <th  style="padding: 18px 10px;">
                    <asp:DropDownList ID="DropDownList3" runat="server">
                    </asp:DropDownList>
                </th>
            </tr>
        </Table>

        <div class="row">
            <div class="col-lg-4"></div>
            <div class="col-lg-4"><asp:Button ID="Button1" runat="server" Text="Acceder" style="width:90%;background:#ba6615; border-radius:25px;font-size:25px;font-weight:900;" OnClick="Button1_Click" /></div>
        </div>
    </div>
</asp:Content>
