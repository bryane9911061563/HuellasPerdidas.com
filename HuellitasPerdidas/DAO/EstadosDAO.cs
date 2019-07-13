using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using HuellitasPerdidas.BO;
namespace HuellitasPerdidas.DAO
{
    public class EstadosDAO
    {
        Conexion objConectar = new Conexion();
        EstadoBO objBO = new EstadoBO();
        public DataSet mostrar_estados()
        {
            DataSet datos = objConectar.EjecutarSentencia("select Estado_id as Codigo,Nombre_Estado as Estado from Estado");
            return datos;

        }
        public int agregar_estado( EstadoBO objEstado)
        {
            int id = objConectar.EjecutarComando("Insert into Estado(Nombre_Estado) output INSERTED.Estado_id values('" + objEstado.Nombre_Estado1 + "')");
            return id;
        }

        public int modificar_estado(EstadoBO objEstado)
        {
            int id=objConectar.EjecutarComando(string.Format("update Estado set Nombre_Estado='{0}' where Estado_id='{1}'",objBO.Nombre_Estado1,objBO.Id_estado));
            return 1;
        }

        public int eliminar_estado(EstadoBO objEstado)
        {
            int id = objConectar.EjecutarComando(string.Format("delete from Estado where Estado_id='{0}'", objBO.Id_estado));
            return 1;
        }
    }
}