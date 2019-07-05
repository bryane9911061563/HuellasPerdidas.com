using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HuellitasPerdidas.DAO;
using HuellitasPerdidas.BO;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace HuellitasPerdidas.GUI
{
    public partial class AdminClientes : System.Web.UI.Page
    {
        ClientesBO objClientesBO = new ClientesBO();
        ClientesDAO objClientesDAO = new ClientesDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

            ddlciudad.DataSource = (objClientesDAO.buscar_ciudad());
            ddlciudad.DataTextField = "Nombre_Ciudad";
            ddlciudad.DataValueField = "Ciudad_id";
            ddlciudad.DataBind();
            ddlciudad.Items.Insert(0, new ListItem("Seleccione..", string.Empty));

            ddlzona.DataSource = objClientesDAO.buscar_zona();
            ddlzona.DataTextField = "Nombre_Zona";
            ddlzona.DataValueField = "Zona_id";
            ddlzona.DataBind();
            ddlzona.Items.Insert(0, new ListItem("Seleccione..", string.Empty));

            ddlestados.DataSource = objClientesDAO.buscar_estado();
            ddlestados.DataTextField = "Nombre_Estado";
            ddlestados.DataValueField = "Estado_id";
            ddlestados.DataBind();
            ddlestados.Items.Insert(0, new ListItem("Seleccione..", string.Empty));



            gv_usuarios.DataSource = objClientesDAO.buscar_cliente();
            gv_usuarios.DataBind();

        }

        private void llenarbo()
        {
            objClientesBO.Nombres1 = txtNombre.Text;
            objClientesBO.ApellidoP1 = txtApellidoP.Text;
            objClientesBO.ApellidoM1 = txtApellidoM.Text;
            objClientesBO.Fecha_nac = DateTime.Parse( txtFechaNac.Text);
            objClientesBO.Email = txtEmail.Text;
            objClientesBO.Pasw = txtPasw.Text;
            objClientesBO.IdCiudad =int.Parse( ddlciudad.SelectedValue);
            objClientesBO.IdEstado = int.Parse(ddlestados.SelectedValue);
            objClientesBO.IdZona = int.Parse(ddlzona.SelectedValue);
            objClientesBO.Direccion = txtDireccion.Text;

        }

        private void limpiarcampos()
        {
            txtNombre.Text = "";
            txtApellidoP.Text = "";
            txtApellidoM.Text = "";
            txtFechaNac.Text = "";
            txtEmail.Text = "";
            txtPasw.Text = "";
            txtDireccion.Text = "";

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            llenarbo();

            if (fu_perfil.HasFile)
            {
                
                String fileExtension = Path.GetExtension(fu_perfil.FileName).ToLower();

                String[] Exten_validas = { ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < Exten_validas.Length; i++)
                {
                    if (fileExtension == Exten_validas[i])
                    {
                        System.Drawing.Image ObjetoImagen;
                        string NombreArchivoPequenio = "_" + Path.GetFileName(fu_perfil.PostedFile.FileName.Replace("_", ""));

                        objClientesBO.ImagenPerfil1 = NombreArchivoPequenio;

                        objClientesBO.IdCliente = objClientesDAO.agregar_cliente(objClientesBO);

                        string RutaImagenes = "~/Recursos/fotos_usuarios/";
                        Bitmap ImagenEnBinario = new Bitmap(fu_perfil.PostedFile.InputStream);
                        ObjetoImagen = objClientesBO.RedimencionarImagen(ImagenEnBinario, 100);
                        switch (fileExtension)
                        {
                            case ".png":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objClientesBO.IdCliente + NombreArchivoPequenio, ImageFormat.Png);

                                break;
                            case ".jpg":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objClientesBO.IdCliente + NombreArchivoPequenio, ImageFormat.Jpeg);
                                break;
                            case ".jpeg":
                                ObjetoImagen.Save(Server.MapPath(RutaImagenes) + objClientesBO.IdCliente + NombreArchivoPequenio, ImageFormat.Jpeg);
                                break;
                        }


                    }
                }

            }
            else
            {
                objClientesBO.ImagenPerfil1 = "";
                objClientesBO.IdCliente = objClientesDAO.agregar_cliente(objClientesBO);
            }
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
    title: 'Alert!',
    content: 'Datos agregados correctamente!',
});
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            limpiarcampos();


            gv_usuarios.DataSource = objClientesDAO.buscar_cliente();
            gv_usuarios.DataBind();
        }

        protected void gv_usuarios_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gv_usuarios, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }

        protected void gv_usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCliente.Text = gv_usuarios.SelectedRow.Cells[0].Text;
            txtNombre.Text = gv_usuarios.SelectedRow.Cells[1].Text.Trim();
            txtApellidoP.Text = gv_usuarios.SelectedRow.Cells[2].Text.Trim();
            txtApellidoM.Text = gv_usuarios.SelectedRow.Cells[3].Text.Trim();
            txtFechaNac.Text = gv_usuarios.SelectedRow.Cells[4].Text.Trim();
            txtfotousuario.Text = "";
            if (gv_usuarios.SelectedRow.Cells[5].Text.Trim() != "")
            {
               txtfotousuario.Text = gv_usuarios.SelectedRow.Cells[0].Text + gv_usuarios.SelectedRow.Cells[5].Text;
            }
            txtEmail.Text = gv_usuarios.SelectedRow.Cells[6].Text.Trim();
            txtPasw.Text = gv_usuarios.SelectedRow.Cells[7].Text.Trim();
            ddlciudad.Text = gv_usuarios.SelectedRow.Cells[8].Text.Trim();
            ddlzona.Text= gv_usuarios.SelectedRow.Cells[9].Text.Trim();
            ddlestados.Text= gv_usuarios.SelectedRow.Cells[10].Text.Trim();
            txtDireccion.Text = gv_usuarios.SelectedRow.Cells[11].Text.Trim();

        }
    }
}