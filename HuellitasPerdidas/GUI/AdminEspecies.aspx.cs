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

        protected void IndexChanged(object sender, EventArgs e)
        {

        }
    }
}