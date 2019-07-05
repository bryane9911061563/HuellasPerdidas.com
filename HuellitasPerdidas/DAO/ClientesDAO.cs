using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using HuellitasPerdidas.BO;
namespace HuellitasPerdidas.DAO
{
    public class ClientesDAO
    {
        Conexion objConectar = new Conexion();
        ClientesBO objBO = new ClientesBO();

        public DataSet buscar_cliente()
        {
            DataSet datos = objConectar.EjecutarSentencia("select * from Cliente");
            return datos;

        }

        public DataSet buscar_ciudad()
        {
            DataSet datos = objConectar.EjecutarSentencia("Select*from Ciudad");
            return datos;
        }
        public DataSet buscar_zona()
        {
            DataSet datos = objConectar.EjecutarSentencia("Select*from Zona");
            return datos;
        }
        public DataSet buscar_estado()
        {
            DataSet datos = objConectar.EjecutarSentencia("Select*from Estado");
            return datos;
        }

        public int agregar_cliente(ClientesBO objclientebo)
        {
            int id = objConectar.EjecutarComando("insert into Cliente (Nombres,Apellido_Paterno,Apellido_Materno,Fecha_Nacimiento,Imagen,Email,Contrasenia,Ciudad_id,Zona_id,Estado_id,Direccion_especifica) values('" + objclientebo.Nombres1 + "','" + objclientebo.ApellidoP1 + "','" + objclientebo.ApellidoM1 + "','" + objclientebo.Email + "','" + objclientebo.Email + "'," + objclientebo.IdCiudad + "," + objclientebo.IdZona + "," + objclientebo.IdEstado + ",'" + objclientebo.Direccion + "')");

            return id;

        }


    }
}