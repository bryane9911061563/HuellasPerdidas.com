using PeludosPerdidos.BO;
using PeludosPerdidos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace PeludosPerdidos.GUI
{
    public partial class UserContent : System.Web.UI.MasterPage
    {
        public Cliente info = new Cliente();
        protected void Page_Load(object sender, EventArgs e)
        {
            Cliente_Dao conectar = new Cliente_Dao();
            if (Session["id"] != null)
            {
                if (int.Parse(Session["id"].ToString()) > 0)
                {
                    info = conectar.optener_info(int.Parse(Session["id"].ToString()));
                }
                else
                {
                    Session["id"] = 0;
                    Response.Redirect("../index.aspx");
                }
            }
            else
            {
                Response.Redirect("../index.aspx");
            }
        }
    }
}