using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HuellitasPerdidas.BO
{
    public class EspecieBO
    {
        int id_especie;
        string nombre_especie;

        public int Id_especie { get => id_especie; set => id_especie = value; }
        public string Nombre_especie { get => nombre_especie; set => nombre_especie = value; }
    }
}