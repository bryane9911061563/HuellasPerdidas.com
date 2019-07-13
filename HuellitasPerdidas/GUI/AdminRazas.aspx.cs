using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HuellitasPerdidas.BO;
using HuellitasPerdidas.DAO;

namespace HuellitasPerdidas.GUI
{
    public partial class AdminRazas : System.Web.UI.Page
    {
        EspecieDAO objEspeciesDao = new EspecieDAO();
        RazaBo objRazaBO = new RazaBo();
        RazaDAO objRazaDAO = new RazaDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            if (!this.IsPostBack)
            {
                DDL_eapecies.DataSource = objRazaDAO.mostrar_especies_enRazas();
                DDL_eapecies.DataTextField = "Nombre_Especie";
                DDL_eapecies.DataValueField = "Especie_id";
                DDL_eapecies.DataBind();
                DDL_eapecies.Items.Insert(0, new ListItem("[Seleccionar...]", "0"));
            }
            gv_razas.DataSource = objRazaDAO.mostrar_razas();
            gv_razas.DataBind();

            
        }


        private void llenarbo()
        {
            objRazaBO.Idespecie =int.Parse( DDL_eapecies.SelectedValue);

            objRazaBO.Nombreraza = txtnombreraza.Text;
        }
        protected void btn_agregar_Click(object sender, EventArgs e)
        {
           
            llenarbo();
            objRazaBO.Idraza = objRazaDAO.agregar_raza(objRazaBO);

            gv_razas.DataSource = objRazaDAO.mostrar_razas();
            gv_razas.DataBind();

            btn_modificar.Enabled = true;


        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {

            int valor = objRazaDAO.modificar_raza(objRazaBO);
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
    title: 'Alert!',
    content: 'Datos actualizados correctamente!',
});
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);


            gv_razas.DataSource = objRazaDAO.mostrar_razas();
            gv_razas.DataBind();
        }

        protected void gv_razas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_modificar.Enabled = true;
            txtIdRaza.Text = gv_razas.SelectedRow.Cells[0].Text;
            txtnombreraza.Text = gv_razas.SelectedRow.Cells[1].Text.Trim();
            DDL_eapecies.SelectedValue = gv_razas.SelectedRow.Cells[2].Text.Trim();
        }

        protected void gv_razas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[2].Visible = false;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gv_razas, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }
    }
}