using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Clientes
    {
        private CD_Conexion conexion1 = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable Mostrar()
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "MostrarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion1.CerrarConexion();
            return tabla;
        }
        public void InsertarDCliente(string nombreCliente, string telCliente,string direccionCliente, string correoCliente, string observacionCliente)
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "InsertarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreCliente", nombreCliente);
            comando.Parameters.AddWithValue("@telCliente", telCliente);
            comando.Parameters.AddWithValue("@direccionCliente", direccionCliente);
            comando.Parameters.AddWithValue("@correoCliente", correoCliente);
            comando.Parameters.AddWithValue("@observacionCliente", observacionCliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion1.CerrarConexion();
        }
        public void EditarDCliente(int idCliente, string nombreCliente, string telCliente, string direccionCliente, string correoCliente, string observacionCliente)
        {

            //
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "EditarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.Parameters.AddWithValue("@nombreCliente", nombreCliente);
            comando.Parameters.AddWithValue("@telCliente", telCliente);
            comando.Parameters.AddWithValue("@direccionCliente", direccionCliente);
            comando.Parameters.AddWithValue("@correoCliente", correoCliente);
            comando.Parameters.AddWithValue("@observacionCliente", observacionCliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion1.CerrarConexion();
        }
        public void EliminarDCliente(int idCliente)
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion1.CerrarConexion();
        }
        public DataTable ListarDCliente()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "ListarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion1.CerrarConexion();
            return Tabla;
        }
    }
}
