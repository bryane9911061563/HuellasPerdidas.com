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
    public partial class UserMain : System.Web.UI.Page
    {
        HtmlGenericControl[] newTitle = new HtmlGenericControl[10];
        HtmlGenericControl[] newimag = new HtmlGenericControl[10];
        HtmlGenericControl[] newDiv = new HtmlGenericControl[10];
        HtmlGenericControl[] newA = new HtmlGenericControl[10];
        protected void Page_Load(object sender, EventArgs e)
        {
            Cliente_Dao conectar = new Cliente_Dao();
            try
            {


                    for (int i = 0; i < 10; i++)
                    {
                        newTitle[i] = new HtmlGenericControl("h2 class='puppycardTitle'");
                        newTitle[i].InnerHtml = "Nombre Perrito";
                         newimag[i] = new HtmlGenericControl("img src='../Imagenes/perrito1.jpg' /");
                         newDiv[i] = new HtmlGenericControl("div class='puppycard' ");
                         newA[i] = new HtmlGenericControl("a   href='Publicacion.aspx' runat='server' OnClick='algo("+i+ ")'class='col-sm-3' style=' padding: 20PX; '");

                        newDiv[i].Controls.Add(newimag[i]);
                        newDiv[i].Controls.Add(newTitle[i]);
                        newA[i].Controls.Add(newDiv[i]);
                        UserMainContent.Controls.Add(newA[i]);
                    }
                    /*HtmlGenericControl newimag = new HtmlGenericControl("img style='width:100%' src ='" + imagencatalogo[i] + "'");
                    newimag.ID = "image" + i;
                    HtmlGenericControl newtitle = new HtmlGenericControl("h3");
                    newtitle.ID = "title" + i;
                    newtitle.InnerHtml = "NombrePerrito";
                    HtmlGenericControl newdiv = new HtmlGenericControl("div ");
                    newdiv.ID = "div" + i;
                    newdiv.Controls.Add(newtitle);
                            Panel2.Controls.Add(newdiv);*/
                


            }catch(Exception ex)
            {
                Session["id"] = 0;
                Response.Redirect("../index.aspx");
            }
        }

        public void algo (int id)
        {
            newTitle[id].InnerHtml = "funciona";
        }
    }
}