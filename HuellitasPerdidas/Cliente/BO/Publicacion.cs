using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeludosPerdidos.BO
{
    public class Publicacion
    {
        int Publicacion_id;
        int cliente_id;
        int mascota_id;
        String contenido;
        String fechaPublicacion;
        String fechaCierre;
        int estado;
        String nombreMascotaAux;

        public int Publicacion_id1 { get => Publicacion_id; set => Publicacion_id = value; }
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }
        public int Mascota_id { get => mascota_id; set => mascota_id = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public string FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }
        public string FechaCierre { get => fechaCierre; set => fechaCierre = value; }
        public int Estado { get => estado; set => estado = value; }
        public string NombreMascotaAux { get => nombreMascotaAux; set => nombreMascotaAux = value; }
    }
}