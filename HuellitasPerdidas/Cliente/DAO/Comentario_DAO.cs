using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PeludosPerdidos.DAO
{
    public class Comentario_DAO
    {
        Comentario Comentario = new Comentario();
        Conexion conect = new Conexion();

        public void AgregarComentario(int cliente, int publi, String contenido)
        {
            Comentario.Cliente_id = cliente;
            Comentario.Publicacion_id1 = publi;
            Comentario.Contenido1 = contenido;
            conect.EjecutarSentencia("exec agregarCOmentario "+ Comentario.Cliente_id+","+ Comentario.Publicacion_id1+",'"+ Comentario.Contenido1+"'");
        }
        public Comentario[] verComentarios(int id)
        {
            DataSet datos = new DataSet();
            try
            {
                datos = conect.EjecutarSentencia("exec verComentarios " + id);
                Comentario[] aux = new Comentario[datos.Tables[0].Rows.Count];



                for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
                {
                    aux[i] = new Comentario();
                    aux[i].Comentario_id = int.Parse(datos.Tables[0].Rows[i]["Comentario_id"].ToString());
                    aux[i].Cliente_id = int.Parse(datos.Tables[0].Rows[i]["Cliente_id"].ToString());
                    aux[i].Publicacion_id1 = int.Parse(datos.Tables[0].Rows[i]["Publicacion_id"].ToString());
                    aux[i].Contenido1 = datos.Tables[0].Rows[i]["Contenido"].ToString();
                }
                return aux;
            }catch(Exception ex)
            {
                return null;
            }
            
        }
    }
}