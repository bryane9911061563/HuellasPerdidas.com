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
    public partial class adminMascotas : System.Web.UI.Page
    {
        MascotaDAO objMascotaDAO = new MascotaDAO();
        MascotasBO objMascotaBO = new MascotasBO();

        protected void Page_Load(object sender, EventArgs e)
        {
            gv_mascotas.DataSource = objMascotaDAO.buscar_mascotas();
            gv_mascotas.DataBind();
        }
    }
}