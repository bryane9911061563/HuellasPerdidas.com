<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente/Main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PeludosPerdidos.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"  >
    
    <asp:Panel ID="Panel1" runat="server" style="margin-top:-30px" CssClass=" col-12 row headermio">
        <h5  class="row col-sm-4">Usuario: 
            <asp:TextBox ID="TextBox1" runat="server" Height="16px" OnTextChanged="TextBox1_TextChanged" style="margin-bottom: 0px"></asp:TextBox>
        </h5>
        <h5  class="row col-sm-8">Contraseña: 
            <asp:TextBox ID="TextBox2" Height="16px" runat="server"></asp:TextBox>
            <asp:Button ID="LogIn" runat="server" OnClick="LogIn_Click" Text="Iniciar" />
            <asp:Button ID="newUser" runat="server" OnClick="newUser_Click" Text="Crear Cuenta" />
        </h5>
    </asp:Panel>
    
    <asp:Panel ID="Panel2" runat="server" Height="100%" CssClass="row"  style="margin-top:30px; padding: 0 62px" OnLoad="Page_Load" BorderColor="#ffffff" BackColor="#ffffff">
    </asp:Panel>

    
</asp:Content>
