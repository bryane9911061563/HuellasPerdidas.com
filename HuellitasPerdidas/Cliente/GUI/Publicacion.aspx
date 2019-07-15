<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente/GUI/UserContent.Master" AutoEventWireup="true" CodeBehind="Publicacion.aspx.cs" Inherits="PeludosPerdidos.GUI.Publicacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <asp:Panel ID="Panel1" runat="server" style="background:#d88e0a" CssClass="row">
        <div class="col-3"></div>      
        
        <div class="col-9" style=" width: 66%; margin-left: 26%;">        
            <div style="padding:10%;"><asp:image runat="server" ImageUrl="~/Cliente/Imagenes/perrito1.jpg"  ></asp:image>

            <asp:Panel ID="Panel2" runat="server">
   
            </asp:Panel>
            <asp:Panel ID="Panel3" runat="server">
                <div class="row">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="col-12" style="border-radius:15px;height: 51px;width: 92%;margin-left: 3%;">Me has visto?</asp:TextBox>
                  <div class="col-10"></div>
                  <asp:Button ID="Button1" runat="server" Text="Comentar"  Style="font-weight:700; border-radius:15px;" OnClick="Button1_Click" />
                </div>
            </asp:Panel>
        </div>

        </div>

        
    </asp:Panel>
</asp:Content>
