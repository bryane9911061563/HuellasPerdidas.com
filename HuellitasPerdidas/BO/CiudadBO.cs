using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HuellitasPerdidas.BO
{
    public class CiudadBO
    {
        int id_ciudad;
        string nombre_ciudad;
        int id_estado;

        public int Id_ciudad { get => id_ciudad; set => id_ciudad = value; }
        public string Nombre_ciudad { get => nombre_ciudad; set => nombre_ciudad = value; }
        public int Id_estado { get => id_estado; set => id_estado = value; }
    }
}