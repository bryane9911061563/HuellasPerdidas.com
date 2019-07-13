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
    public partial class adminUsuarios_DASH : System.Web.UI.Page
    {
        ClientesDAO objClientesDAO = new ClientesDAO();
        ClientesBO objClientesBO = new ClientesBO();
        EstadosDAO estadosDAO = new EstadosDAO();
        CiudadDAO ciudadDAO = new CiudadDAO();
        ZonaDAO zonaDAO = new ZonaDAO();
        


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ddl_estado.DataSource = estadosDAO.mostrar_estados();
                ddl_estado.DataTextField = "Estado";
                ddl_estado.DataValueField = "Codigo";
                ddl_estado.DataBind();
                ddl_estado.Items.Insert(0, new ListItem("Seleccionar estado...", "0"));
            }

            if (!this.IsPostBack)
            {
                ddl_ciudad.DataSource = ciudadDAO.mostrarciudades();
                ddl_ciudad.DataTextField = "Nombre_Ciudad";
                ddl_ciudad.DataValueField = "Ciudad_id";
                ddl_ciudad.DataBind();
                ddl_ciudad.Items.Insert(0, new ListItem("Seleccionar ciudad...", "0"));
            }

            if (!this.IsPostBack)
            {
                ddl_zona.DataSource = zonaDAO.mostrarzonas();
                ddl_zona.DataTextField = "Nombre_Zona";
                ddl_zona.DataValueField = "Zona_id";
                ddl_zona.DataBind();
                ddl_zona.Items.Insert(0, new ListItem("Seleccionar zona...", "0"));
            }
        }

        public void llenarbo()
        {
            objClientesBO.Nombres1 = txtNombre.Text;
            objClientesBO.ApellidoP1 = txtApellidoP.Text;
            objClientesBO.ApellidoM1 = txtApellidoM.Text;
            objClientesBO.Email = txtEmail.Text;
            objClientesBO.Pasw = txt_password.Text;
            objClientesBO.Direccion = txtDireccion.Text;
            objClientesBO.IdCiudad = ddl_ciudad.SelectedIndex;
            objClientesBO.IdEstado = ddl_estado.SelectedIndex;
            objClientesBO.IdZona = ddl_zona.SelectedIndex;
            
        }

        public void limpiarcampos()
        {
            txtNombre.Text = "";
            txtApellidoP.Text = "";
            txtApellidoM.Text = "";
            txtEmail.Text = "";
            txt_password.Text = "";
            txt_passwordconfirm.Text = "";
            txtDireccion.Text = "";
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            llenarbo();
            objClientesBO.IdCliente = objClientesDAO.agregar_cliente(objClientesBO);

        }
    }
}