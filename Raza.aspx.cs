using ProyectoMarisaEB.BO;
using ProyectoMarisaEB.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoMarisaEB.GUI.Catalogos
{
    public partial class Raza : System.Web.UI.Page
    {
        RazaBO BO = new RazaBO();
        RazaDAO DAO = new RazaDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
            if (!this.IsPostBack)
            {
                cboespecie.DataSource = DAO.llenarcbo();
                cboespecie.DataTextField = "Nombre_Especie";
                cboespecie.DataValueField = "ID_Especie";
                cboespecie.DataBind();
                cboespecie.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }
            dgv_razas.DataSource = DAO.buscar();
            dgv_razas.DataBind();
        }

        protected void llenarbo()
        {
            BO.Nombre_Raza = txt_NombreRaza.Text;
            BO.ID_Especie1 = int.Parse(cboespecie.Text);
        }

        protected void limpiarcontroles()
        {
            txtID.Text = "";
            txt_NombreRaza.Text = "";
            TxtBusqueda.Text = "";
            cboespecie.SelectedIndex = 0;
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
            btn_Registrar.Enabled = true;
        }

        protected void btn_Registrar_Click(object sender, EventArgs e)
        {
            //llena el BO
            llenarbo();
            BO.ID_Raza = DAO.agregar(BO);

            string scriptjs =
               @"<script type='text/javascript'>

                    $.alert({

                    title: 'Alert!',

                    content: 'Datos agregados correctamente!',

                });
                </script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);

            limpiarcontroles();
            dgv_razas.DataSource = DAO.buscar();
            dgv_razas.DataBind();
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            llenarbo();
            //agrego el id al bo 
            BO.ID_Raza = int.Parse(txtID.Text);
            var valor = DAO.modificar(BO);

            string scriptjs =
                @"<script type='text/javascript'> 
                    $.alert({ 
                        title: 'Alert!', 
                        content: 'Datos actualizados correctamente!', 
                        }); 
                </script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);

            limpiarcontroles();
            dgv_razas.DataSource = DAO.buscar();
            dgv_razas.DataBind();
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            BO.ID_Raza = int.Parse(txtID.Text);
            llenarbo();
            var valor = DAO.eliminar(BO);

            string scriptjs =
                @"<script type='text/javascript'> 

                    $.alert({ 
                        title: 'Mensaje del sistema!', 
                        type: 'blue', 
                        content: 'Datos eliminados correctamente!', 

                    }); 
                </script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);

            limpiarcontroles();
            dgv_razas.DataSource = DAO.buscar();
            dgv_razas.DataBind();
        }

        protected void Busqueda(object sender, EventArgs e)
        {
            BO.Nombre_Raza = TxtBusqueda.Text;
            dgv_razas.DataSource = DAO.buscar_Nombre(BO);
            dgv_razas.DataBind();
        }


        protected void dgvrazas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(dgv_razas, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }

        protected void seleccionar_registro(object sender, EventArgs e)
        {
            btn_Registrar.Enabled = false;
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
            txtID.Text = dgv_razas.SelectedRow.Cells[0].Text.Trim();
            txt_NombreRaza.Text = dgv_razas.SelectedRow.Cells[1].Text.Trim();
            BO.Nombre_Especie = dgv_razas.SelectedRow.Cells[2].Text.Trim();
            var cbo = DAO.recuperarid(BO);
            cboespecie.Text = cbo.ToString();
        }

        protected void btn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
        }
    }
}