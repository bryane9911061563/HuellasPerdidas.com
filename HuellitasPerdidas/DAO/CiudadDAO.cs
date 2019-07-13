using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using HuellitasPerdidas.BO;

namespace HuellitasPerdidas.DAO
{
    public class CiudadDAO
    {
        Conexion con = new Conexion();
        public DataSet mostrarciudades()
        {

            DataSet datos = con.EjecutarSentencia("Select *from Ciudad");
            return datos;
        }
    }
}