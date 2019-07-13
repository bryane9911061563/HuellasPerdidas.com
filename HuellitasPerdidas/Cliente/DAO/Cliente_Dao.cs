using PeludosPerdidos.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PeludosPerdidos.DAO
{
    public class Cliente_Dao
    {
        Conexion conect = new Conexion();
        
        public Estado[] estados()
        {
            DataSet datos = conect.EjecutarSentencia("select * from Estado");
            Estado[] temporal = new Estado[datos.Tables[0].Rows.Count];
            
            for (int i =0; i< datos.Tables[0].Rows.Count; i ++)
            {
                temporal[i] = new Estado();
                temporal[i].Estado_Nombre = datos.Tables[0].Rows[i]["Nombre_Estado"].ToString();
            }
            return temporal;
        }

        public Ciudad[] ciudaes()
        {
            DataSet datos = conect.EjecutarSentencia("select * from Ciudad");
            Ciudad[] temporal = new Ciudad[datos.Tables[0].Rows.Count];

            for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
            {
                temporal[i] = new Ciudad();
                temporal[i].Ciudad_nombre = datos.Tables[0].Rows[i]["Nombre_Ciudad"].ToString();
            }
            return temporal;
        }

        public Zona[] zonas()
        {
            DataSet datos = conect.EjecutarSentencia("select * from Zona");
            Zona[] temporal = new Zona[datos.Tables[0].Rows.Count];

            for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
            {
                temporal[i] = new Zona();
                temporal[i].Zona_nombre = datos.Tables[0].Rows[i]["Nombre_Zona"].ToString();
            }
            return temporal;
        }

        public void crearUsuario(String nombre, String ap1, String ap2, String mail, String passwo, int Estado, int Ciudad, int Zona, String direc)
        {
            conect.EjecutarSentencia("exec agregar_cliente '"+ nombre+"','"+ap1+"','"+ap2+ "','25/feb/2019','" + mail+"','"+passwo+"',1,1,1,'"+direc+"'");
        }

        public int iniciar_sesion(string nombre, string contra)
        {
            DataSet datos= conect.EjecutarSentencia("exec iniciar_sesionCliente '" + nombre + "','" + contra + "'");
            try
            {
                return int.Parse(datos.Tables[0].Rows[0]["Cliente_id"].ToString());
            }catch(Exception ex)
            {
                return 0;
            }
        }

        public Cliente optener_info(int id)
        {
            Cliente aux = new Cliente();
            DataSet datos = new DataSet();
            datos = conect.EjecutarSentencia("exec recibirClienteInfo " + id);
            aux.Nombre = datos.Tables[0].Rows[0]["Nombres"].ToString();
            aux.Apellido_Paterno = datos.Tables[0].Rows[0]["Apellido_Paterno"].ToString();
            aux.Apellido_Materno = datos.Tables[0].Rows[0]["Apellido_Materno"].ToString();
            aux.Fecha_Nacimiento = datos.Tables[0].Rows[0]["Fecha_Nacimiento"].ToString();
            aux.Foto = datos.Tables[0].Rows[0]["Imagen"].ToString();
            aux.Direccion = datos.Tables[0].Rows[0]["Direccion_especifica"].ToString();
            //aux. = datos.Tables[0].Rows[0]["Direccion_especifica"].ToString();
            //aux.Direccion = datos.Tables[0].Rows[0]["Direccion_especifica"].ToString();
            return aux;
        }
    }
}