using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace PeludosPerdidos.GUI
{
    public partial class Publicacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlGenericControl nombreMascota = new HtmlGenericControl("h3");
            nombreMascota.InnerHtml = "FIDO";
            this.Panel2.Controls.Add(nombreMascota);
            HtmlGenericControl comentarioResponsable = new HtmlGenericControl("h5");
            comentarioResponsable.InnerHtml = "nombre usuario";
            HtmlGenericControl contenidoComenatario = new HtmlGenericControl("div");
            contenidoComenatario.InnerHtml = "lorem ipsum dolo jadijsafasf sdafsgfsadg asgfsdf gdr gadg gdafgt dgda gadgadf dfg dfg adfg fdag adfgadf";
            HtmlGenericControl comentario = new HtmlGenericControl("div");
            comentario.Controls.Add(comentarioResponsable);
            comentario.Controls.Add(contenidoComenatario);
            Panel2.Controls.Add(comentario);
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}