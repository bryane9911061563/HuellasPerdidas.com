<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente/GUI/UserContent.Master" AutoEventWireup="true" CodeBehind="UserMain.aspx.cs" Inherits="PeludosPerdidos.GUI.UserMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="row">
        <div class="col-sm-3"></div>
        <asp:Panel ID="UserMainContent" runat="server"  class="col-sm-9 row" style="background:#d88e0a; padding-bottom:100%; padding-top: 50px;">
            <a href="PublicarMascota.aspx" class="col-sm-3"  style="margin: -24px 0px;padding: 20PX;">
                <div  style="background:#20930e;border-radius:25px;">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/perrito1.jpg" />
                    <h2 style="color: blue;font-size: 21px; text-align: center;margin-top: 0px;" >Agregar Publicacion</h2>
                </div>
            </a>
        </asp:Panel>
    </div>
    
</asp:Content>
