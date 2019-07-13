using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeludosPerdidos.BO
{
    public class Cliente
    {
        private String nombre;
        private String apellido_Paterno;
        private String apellido_Materno;
        private String fecha_Nacimiento;
        private String foto;
        private int ciudad_id;
        private int estado_id;
        private int zona_id;
        private String direccion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_Paterno { get => apellido_Paterno; set => apellido_Paterno = value; }
        public string Apellido_Materno { get => apellido_Materno; set => apellido_Materno = value; }
        public string Fecha_Nacimiento { get => fecha_Nacimiento; set => fecha_Nacimiento = value; }
        public string Foto { get => foto; set => foto = value; }
        public int Ciudad_id { get => ciudad_id; set => ciudad_id = value; }
        public int Estado_id { get => estado_id; set => estado_id = value; }
        public int Zona_id { get => zona_id; set => zona_id = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}