using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HuellitasPerdidas.DAO;
using HuellitasPerdidas.BO;
namespace HuellitasPerdidas.GUI
{
    public partial class administracionEstados_DASH : System.Web.UI.Page
    {
        EstadosDAO objdao = new EstadosDAO();
        EstadoBO objbo = new EstadoBO();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            gv_estados.DataSource = objdao.mostrar_estados();
            gv_estados.DataBind();
            btn_eliminar.Enabled = false;
            btn_guardarcomo.Enabled = false;
        }

        private void llenarbo()
        {
            objbo.Id_estado =int.Parse( txtId_Estado.Text);
            objbo.Nombre_Estado1 = txtNombreEstado.Text;
        }
        private void limpiarcontroles()
        {
            txtId_Estado.Text = "";
            txtNombreEstado.Text = "";
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            objbo.Nombre_Estado1 = txtNombreEstado.Text;
            objdao.agregar_estado(objbo);
            limpiarcontroles();
            gv_estados.DataSource = objdao.mostrar_estados();
            gv_estados.DataBind();
        }

        protected void gv_estados_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_eliminar.Enabled = true;
            btn_guardarcomo.Enabled = true;

            txtId_Estado.Text = gv_estados.SelectedRow.Cells[0].Text;
            txtNombreEstado.Text = gv_estados.SelectedRow.Cells[1].Text.Trim();
            
        }

        protected void gv_estados_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gv_estados, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }

        protected void btn_guardarcomo_Click(object sender, EventArgs e)
        {
            objbo.Id_estado = int.Parse(txtId_Estado.Text);
            objbo.Nombre_Estado1 = txtNombreEstado.Text;
            objdao.modificar_estado(objbo);
            gv_estados.DataSource = objdao.mostrar_estados();
            gv_estados.DataBind();
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            objbo.Id_estado =int.Parse(txtId_Estado.Text);
            objdao.eliminar_estado(objbo);
            gv_estados.DataSource = objdao.mostrar_estados();
            gv_estados.DataBind();
            limpiarcontroles();
        }
    }
}