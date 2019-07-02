using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using HuellitasPerdidas.BO;

namespace HuellitasPerdidas.DAO
{
    public class RazaDAO
    {
        Conexion objConectar = new Conexion();
        RazaBo objBO = new RazaBo();
        public DataSet buscar_raza()
        {
            DataSet datos = objConectar.EjecutarSentencia("select * from Raza");
            return datos;

        }
        public int agregar_raza(RazaBo obrazabo)
        {
            //inserta y devuelve el ultimo el id insertado
            int id = objConectar.EjecutarComando("INSERT INTO Raza (Especie_id,Nombre_Raza) output INSERTED.Raza_id values('" + obrazabo.Idespecie+ "','"+obrazabo.Nombreraza+"')");
            return id;

        }

    }
}