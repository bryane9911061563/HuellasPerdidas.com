using PeludosPerdidos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace PeludosPerdidos
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String[] imagencatalogo = new string[4];
            imagencatalogo[0] = "Imagenes/perrito1.jpg";
            imagencatalogo[1] = "Imagenes/perrito2.jpg";
            imagencatalogo[2] = "Imagenes/perrito3.jpg";
            imagencatalogo[3] = "Imagenes/perrito4.jpg";
            for (int a = 0; a < 10; a++)
            {

                for (int i = 0; i < 4; i++)
                {
                    HtmlGenericControl newimag = new HtmlGenericControl("img style='width:100%' src ='" + imagencatalogo[i] + "'");
                    newimag.ID = "image" + i;
                    HtmlGenericControl newtitle = new HtmlGenericControl("h3");
                    newtitle.ID = "title" + i;
                    newtitle.InnerHtml = "NombrePerrito";
                    HtmlGenericControl newdiv = new HtmlGenericControl("div ");
                    newdiv.ID = "div" + i;

                    //newControl.ID = "imagen" + i;
                    //newControl.InnerHtml = "This is a dynamically created HTML server control.";
                    newdiv.Attributes.Add("class", "test col-sm-4");
                    // newdiv.Attributes.Add("class", "col-sm-3");
                    newdiv.Controls.Add(newimag);
                    newdiv.Controls.Add(newtitle);
                    Panel2.Controls.Add(newdiv);

                    //Image1.CssClass = "test";          
                }
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LogIn_Click(object sender, EventArgs e)
        {
            Cliente_Dao datos =new Cliente_Dao();
            int aux = 0;
            aux = datos.iniciar_sesion(this.TextBox1.Text, this.TextBox2.Text);
            Console.Write(aux);
                Session["id"] = aux;
                Response.Redirect("GUI/UserMain.aspx");
        }

        protected void newUser_Click(object sender, EventArgs e)
        {
            Session["id"] = 0;
            Response.Redirect("GUI/NewUser.aspx");
        }
    }
}