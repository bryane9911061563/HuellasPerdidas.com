using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using HuellitasPerdidas.BO;

namespace HuellitasPerdidas.DAO
{
    public class ZonaDAO
    {
        Conexion con = new Conexion();
        ZonaBO objzonabo = new ZonaBO();

        public DataSet mostrarzonas()
        {
            DataSet datos = con.EjecutarSentencia("Select * from Zona");
            return datos;
        }
    }
}