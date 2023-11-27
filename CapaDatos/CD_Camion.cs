using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Camion
    {
        private CD_Conexion conexion1 = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private SqlDataReader LeerFilas;

    private DataTable Mostrar()
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "MostrarCamion";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            conexion1.CerrarConexion();
            return tabla;
        }
    }
}
