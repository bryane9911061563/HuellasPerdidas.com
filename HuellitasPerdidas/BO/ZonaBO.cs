using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HuellitasPerdidas.BO
{
    public class ZonaBO
    {
        int zona_id;
        int ciudad_id;
        string nombre_zona;

        public int Zona_id { get => zona_id; set => zona_id = value; }
        public int Ciudad_id { get => ciudad_id; set => ciudad_id = value; }
        public string Nombre_zona { get => nombre_zona; set => nombre_zona = value; }

    }
}