using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using HuellitasPerdidas.BO;

namespace HuellitasPerdidas.DAO
{
    public class RazaDAO
    {
        Conexion objConectar = new Conexion();
        RazaBo objBO = new RazaBo();
       
        public int agregar_raza(RazaBo obrazabo)
        {
            //inserta y devuelve el ultimo el id insertado
            int id = objConectar.EjecutarComando("INSERT INTO Raza (Especie_id,Nombre_Raza) output INSERTED.Raza_id values('" + obrazabo.Idespecie+ "','"+obrazabo.Nombreraza+"')");
            return id;

        }

        public int modificar_raza(RazaBo objrazabo)
        {
            int id = objConectar.EjecutarComando(string.Format("update Raza set Especie_id='{0}',Nombre_Raza='{1}' where Raza_id={2}", objBO.Idespecie, objBO.Nombreraza, objBO.Idraza));
            return 1;
        }

        public DataSet mostrar_razas()
        {
            DataSet datos = objConectar.EjecutarSentencia("select R.Raza_id as 'Codigo' , R.Nombre_Raza as 'Nombre de raza' ,E.Especie_id, E.Nombre_Especie as 'Especie' from Especie E inner join Raza R on R.Especie_id=E.Especie_id");
            return datos;
        }
        public DataSet mostrar_especies_enRazas()
        {
            DataSet datosRaza = objConectar.EjecutarSentencia("Select *from Especie");
            return datosRaza;
        }

    }
}