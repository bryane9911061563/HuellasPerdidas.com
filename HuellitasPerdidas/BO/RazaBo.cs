using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HuellitasPerdidas.BO
{
    public class RazaBo
    {
        int idraza;
        int idespecie;
        string nombreraza;

        public int Idraza { get => idraza; set => idraza = value; }
        public int Idespecie { get => idespecie; set => idespecie = value; }
        public string Nombreraza { get => nombreraza; set => nombreraza = value; }
    }
}