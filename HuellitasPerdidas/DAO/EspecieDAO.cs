using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using HuellitasPerdidas.BO;


namespace HuellitasPerdidas.DAO
{
    public class EspecieDAO
    {
        Conexion objConectar = new Conexion();
        EspecieBO objBO = new EspecieBO();
        public DataSet buscar_especies()
        {
            DataSet datos = objConectar.EjecutarSentencia("select * from Especie");
            return datos;

        }


        public int agregar_especie(EspecieBO objespeciebo)
        {
            //inserta y devuelve el ultimo el id insertado
            int id = objConectar.EjecutarComando("INSERT INTO Especie (Nombre_Especie) output INSERTED.Especie_id values('" + objespeciebo.Nombre_especie + "')");
            return id;

        }
    }
}