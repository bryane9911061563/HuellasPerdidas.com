using PeludosPerdidos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PeludosPerdidos.GUI
{
    public partial class PublicarMascota : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Mascota_DAO nueva = new Mascota_DAO();
            Publicacion_dao publica = new Publicacion_dao();
                nueva.agregarMascota(TextBox1.Text,8,1,1,1,"none");
            publica.agregarpublicacion(int.Parse(Session["id"].ToString()),1,TextBox6.Text,"25/March/2019");

        }
    }
}