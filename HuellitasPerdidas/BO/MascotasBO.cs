using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HuellitasPerdidas.BO
{
    public class MascotasBO
    {
        int mascotaid;
        string nombre;
        DateTime fecha_nac;
        int zonaid;
        int especieid;
        int razaid;
        string foto;

        public int Mascotaid { get => mascotaid; set => mascotaid = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
        public int Zonaid { get => zonaid; set => zonaid = value; }
        public int Especieid { get => especieid; set => especieid = value; }
        public int Razaid { get => razaid; set => razaid = value; }
        public string Foto { get => foto; set => foto = value; }
    }
}