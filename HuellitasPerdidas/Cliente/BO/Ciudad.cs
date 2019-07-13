using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeludosPerdidos.BO
{
    public class Ciudad
    {
        private int ciudad_id;
        private int estado_id;
        private String ciudad_nombre;

        public int Ciudad_id { get => ciudad_id; set => ciudad_id = value; }
        public int Estado_id { get => estado_id; set => estado_id = value; }
        public string Ciudad_nombre { get => ciudad_nombre; set => ciudad_nombre = value; }
    }
}