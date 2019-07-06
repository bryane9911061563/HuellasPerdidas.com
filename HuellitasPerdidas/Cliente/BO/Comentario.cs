using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeludosPerdidos.DAO
{
    public class Comentario
    {
        int comentario_id;
        int cliente_id;
        int Publicacion_id;
        String Contenido;

        public int Cliente_id { get => cliente_id; set => cliente_id = value; }
        public int Publicacion_id1 { get => Publicacion_id; set => Publicacion_id = value; }
        public string Contenido1 { get => Contenido; set => Contenido = value; }
        public int Comentario_id { get => comentario_id; set => comentario_id = value; }
    }
}