using PeludosPerdidos.BO;
using PeludosPerdidos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PeludosPerdidos.GUI
{
    public partial class NewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            iniciartablas();
            //this.DropDownList1.DataSource = estado.Estados();
            //DataSet datos = estado.Estados();
            //this.DropDownList1.Items.Add(datos.Tables[0].Rows[0]["Nombre_Estado"].ToString());
        }

        private void iniciartablas()
        {
            Cliente_Dao datos = new Cliente_Dao();
            Estado[] estadosinfo = datos.estados();
            Ciudad[] ciudadinfo = datos.ciudaes();
            Zona[] zonasinfo = datos.zonas();
            for (int i = 0; i < estadosinfo.Length; i++)
            {
                this.DropDownList1.Items.Add(estadosinfo[i].Estado_Nombre);
            }
            for (int i = 0; i < ciudadinfo.Length; i++)
            {
                this.DropDownList2.Items.Add(ciudadinfo[i].Ciudad_nombre);
            }
            for (int i = 0; i < zonasinfo.Length; i++)
            {
                this.DropDownList3.Items.Add(zonasinfo[i].Zona_nombre);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Cliente_Dao datos = new Cliente_Dao();
            datos.crearUsuario(this.TextBox1.Text,this.TextBox2.Text, this.TextBox7.Text, this.TextBox4.Text,this.TextBox5.Text,1,1,1,this.TextBox3.Text);
            Response.Redirect("../index.aspx");
        }
    }
}