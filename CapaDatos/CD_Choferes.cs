using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Choferes
    {
        private CD_Conexion conexion1 = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private SqlDataReader LeerFilas;

    public DataTable Mostrar()
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "MostrarChofer";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion1.CerrarConexion();
            return tabla;
        }
    public void InsertarDChofer(string nombreChofer, string licencia, string documento, string telefono, string antiguedad)
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "InsertarChofer";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreChofer", nombreChofer);
            comando.Parameters.AddWithValue("@licencia", licencia);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@antiguedad", antiguedad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion1.CerrarConexion();
        }
    public void EditarDChofer(int idChofer, string nombreChofer, string licencia, string documento, string telefono, string antiguedad)
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "EditarChofer";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idChofer", idChofer);
            comando.Parameters.AddWithValue("@nombreChofer", nombreChofer);
            comando.Parameters.AddWithValue("@licencia", licencia);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@antiguedad", antiguedad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion1.CerrarConexion();
        }
    public void EliminarDChofer(int idChofer)
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "EliminarChofer";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idChofer", idChofer);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion1.CerrarConexion();
        }
    public DataTable ListarDChofer()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "ListarChofer";
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion1.CerrarConexion();
            return Tabla;
        }
    }
}
