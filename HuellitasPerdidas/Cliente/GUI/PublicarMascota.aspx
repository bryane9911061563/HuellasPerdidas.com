<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente/GUI/UserContent.Master" AutoEventWireup="true" CodeBehind="PublicarMascota.aspx.cs" Inherits="PeludosPerdidos.GUI.PublicarMascota" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-sm-3"></div>
        <div class="col-sm-9">
        <a href="UserMain.aspx"><div class="col-sm-12 backbutton" >◄ BACK </div></a>
            <div style="padding: 14% 25%;margin-top: -10px;">
                <Table style="background: green;border-radius: 20px;">
                     <tr>
                        <th style="padding: 18px 10px;border-right: solid;border-bottom: solid;">Nombrer:</th>
                        <th style="padding: 18px 10px;border-bottom: solid;">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                         </th>
                     </tr>  
                    <tr>
                        <th style="padding: 18px 10px;border-right: solid;border-bottom: solid;">Raza:</th>
                        <th style="padding: 18px 10px;border-bottom: solid;">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </th>
                    </tr>
                    <tr>
                        <th style="padding: 18px 10px;border-right: solid;border-bottom: solid;">Zona Aproximada:</th>
                        <th style="padding: 18px 10px;border-bottom: solid;">
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </th>
                    </tr>
                    <tr>
                        <th style="padding: 18px 10px;border-right: solid;border-bottom: solid;">Añadir Imagen:</th>
                        <th style="padding: 18px 10px;border-bottom: solid;">
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </th>
                    </tr>
                    <tr>
                        <th style="padding: 18px 10px; border-right:solid;">Especie:</th>
                        <th  style="padding: 18px 10px;">
                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                            
                        </th>
                    </tr>
            
                </Table>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button"  Style="font-weight:700; border-radius:15px;" />
                 <asp:TextBox ID="TextBox6" runat="server" Text="Cuentanos de el" Style="width:80%; border-radius:15px;margin-left:10%;" ></asp:TextBox>
            </div>
        </div>
    </div>
</asp:Content>
