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
    public partial class AdminEspecies : System.Web.UI.Page
    {
        EspecieBO objBO = new EspecieBO();
        EspecieDAO objDAO = new EspecieDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            gv_especies.DataSource = objDAO.buscar_especies();
            gv_especies.DataBind();

            if(txtID_especie.Text=="" || txtNombreespecie.Text=="")
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                
            }
        }

        private void llenarbo()
        {
            objBO.Nombre_especie = txtNombreespecie.Text;
        }
        

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            llenarbo();

            objBO.Id_especie = objDAO.agregar_especie(objBO);


            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
    title: 'Alert!',
    content: 'Datos agregados correctamente!',
});
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);

            gv_especies.DataSource = objDAO.buscar_especies();
            gv_especies.DataBind();

            txtNombreespecie.Text = "";
        }
 protected void gv_especies_DataBound(object sender, EventArgs e)
        {
          
        }
        protected void IndexChanged(object sender, EventArgs e)
        {
            txtID_especie.Text = gv_especies.SelectedRow.Cells[0].Text;
            txtNombreespecie.Text = gv_especies.SelectedRow.Cells[1].Text;

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        protected void gv_especies_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gv_especies, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            //agrego el id al bo
            objBO.Id_especie = int.Parse(txtID_especie.Text);
           

            
            int valor = objDAO.modificar_especie(objBO);
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
    title: 'Alert!',
    content: 'Datos actualizados correctamente!',
});
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            


            gv_especies.DataSource = objDAO.buscar_especies();
            gv_especies.DataBind();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            objBO.Id_especie = int.Parse(txtID_especie.Text);


            int valor = objDAO.eliminar_especie(objBO);
            string scriptjs = @"<script type='text/javascript'>
                            $.alert({
    title: 'Mensaje del sistema!',
     type: 'blue',
    content: 'Datos eliminados correctamente!',
});
                        </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", scriptjs, false);
            gv_especies.DataSource = objDAO.buscar_especies();
            gv_especies.DataBind();

        }
    }
}