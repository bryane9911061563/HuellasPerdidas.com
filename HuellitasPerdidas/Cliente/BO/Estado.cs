using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeludosPerdidos.BO
{
    public class Estado
    {
        private int estado_id;
        private String estado_Nombre;

        public int Estado_id { get => estado_id; set => estado_id = value; }
        public String Estado_Nombre { get => estado_Nombre; set => estado_Nombre = value; }
    }
}