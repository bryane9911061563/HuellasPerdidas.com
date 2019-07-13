using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using HuellitasPerdidas.BO;

namespace HuellitasPerdidas.DAO
{
    public class MascotaDAO
    {
        Conexion Conectted = new Conexion();

        public DataSet buscar_mascotas()
        {
            DataSet datos = Conectted.EjecutarSentencia("Select *from Mascota");
            return datos;
        }
    }
}