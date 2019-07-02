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
            DDL_eapecies.DataSource = objEspeciesDao.buscar_especies();
            DDL_eapecies.DataTextField = "Nombre_Especie";
            DDL_eapecies.DataValueField = "Especie_id";
            DDL_eapecies.DataBind();
            DDL_eapecies.Items.Insert(0, new ListItem("Seleccione..", string.Empty));

            gv_razas.DataSource = objRazaDAO.buscar_raza();
            gv_razas.DataBind();
        }


        private void llenarbo()
        {
            objRazaBO.Idespecie = 1;

            objRazaBO.Nombreraza = txtnombreraza.Text;
        }
        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            llenarbo();
            objRazaBO.Idraza = objRazaDAO.agregar_raza(objRazaBO);

            gv_razas.DataSource = objRazaDAO.buscar_raza();
            gv_razas.DataBind();

        }
    }
}