using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeludosPerdidos.BO
{
    public class Mascota
    {
        String Nombre;
        int Edad;
        int zona_id;
        int especie_id;
        int raza_id;
        String foto;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Edad1 { get => Edad; set => Edad = value; }
        public int Zona_id { get => zona_id; set => zona_id = value; }
        public int Especie_id { get => especie_id; set => especie_id = value; }
        public int Raza_id { get => raza_id; set => raza_id = value; }
        public string Foto { get => foto; set => foto = value; }
    }
}