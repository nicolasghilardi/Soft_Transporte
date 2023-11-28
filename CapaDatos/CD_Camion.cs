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

    public DataTable Mostrar()
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "MostrarCamion";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion1.CerrarConexion();
            return tabla;
        }
    public void InsertarDCamion(string marca, int modelo, string patente, string capacidad, string observacionCamion)
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "InsertarCamion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@modelo", modelo);
            comando.Parameters.AddWithValue("@patente", patente);
            comando.Parameters.AddWithValue("@capacidad", capacidad);
            comando.Parameters.AddWithValue("@observacionCamion", observacionCamion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion1.CerrarConexion();
        }
    public void EditarDCamion(int idCamion, string marca, int modelo, string patente, string capacidad, string observacionCamion)
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "EditarCamion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCamion", idCamion);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@modelo", modelo);
            comando.Parameters.AddWithValue("@patente", patente);
            comando.Parameters.AddWithValue("@capacidad", capacidad);
            comando.Parameters.AddWithValue("@observacionCamion", observacionCamion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion1.CerrarConexion();
        }
    public void EliminarDCamion(int idCamion)
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "EliminarCamion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCamion", idCamion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion1.CerrarConexion();
        }
    public DataTable ListarDCamion()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "ListarCamion";
            comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            conexion1.CerrarConexion();
            return Tabla;
        }

    }
}
