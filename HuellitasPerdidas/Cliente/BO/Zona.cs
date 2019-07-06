using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeludosPerdidos.BO
{
    public class Zona
    {
        private int zona_id;
        private int ciudad_id;
        private string zona_nombre;

        public int Zona_id { get => zona_id; set => zona_id = value; }
        public int Ciudad_id { get => ciudad_id; set => ciudad_id = value; }
        public string Zona_nombre { get => zona_nombre; set => zona_nombre = value; }
    }
}