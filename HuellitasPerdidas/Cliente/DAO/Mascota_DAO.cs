using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PeludosPerdidos.DAO
{
    public class Mascota_DAO
    {
        DataSet datos = new DataSet();
        Conexion conect = new Conexion();

        public void agregarMascota(String nombre, int edad, int zona, int especie, int raza, String foto)
        {
            try
            {
                conect.EjecutarComando("exec agregarMascota '" + nombre + "'," + edad + "," + zona + "," + "," + especie + "," + raza + ",'" + foto + "'");
            }
            catch (Exception ex)
            {

            }
        }

        
    }
}