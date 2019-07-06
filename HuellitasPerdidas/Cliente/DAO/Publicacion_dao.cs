using PeludosPerdidos.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PeludosPerdidos.DAO
{
    public class Publicacion_dao
    {

        DataSet datos = new DataSet();
        Conexion conect = new Conexion();

        public Publicacion[] vertodaspulicaciones()
        {
            datos = conect.EjecutarSentencia("select* from publicacion");
            Publicacion[] aux = new Publicacion[datos.Tables[0].Rows.Count];
            for(int i=0;i< datos.Tables[0].Rows.Count; i++)
            {
                aux[i] = new Publicacion();
                aux[i].Publicacion_id1 = int.Parse(datos.Tables[0].Rows[i]["Cliente_id"].ToString());

            }
            return aux;
        }
            public Publicacion[] verpulicaciones_cliente(int cliente)
        {
            datos = conect.EjecutarSentencia("exec verPublicacionesCliente " +cliente);
            Publicacion[] aux = new Publicacion[datos.Tables[0].Rows.Count];
            for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
            {
                aux[i] = new Publicacion();
                aux[i].Publicacion_id1 = int.Parse(datos.Tables[0].Rows[i]["Publicacion_id"].ToString());
                aux[i].Publicacion_id1 = int.Parse(datos.Tables[0].Rows[i]["Cliente_id"].ToString());
                aux[i].NombreMascotaAux = datos.Tables[0].Rows[i]["Nombre"].ToString();

            }
            return aux;
        }
        
        public void agregarpublicacion(int cliente , int mascota, String contenido, String fecha)
        {
            conect.EjecutarComando("exec iniciarpublicacion " + cliente + "," + mascota + ",'" + contenido + "','25/feb/2019'," + 0);
        }

    }
}