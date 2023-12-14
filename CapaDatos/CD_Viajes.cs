using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Viajes
    {
        private CD_Conexion conexion1 = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable Mostrar()
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "MostrarViajes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion1.CerrarConexion();
            return tabla;
        }

        public void InsertarDViaje(Int32 idCamion, Int32 idChofer, Int32 idCliente, string fechaViaje, string origen, string destino, string carga, string costo, string observacionViaje)
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "InsertarViaje";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("idCamion", idCamion);
            comando.Parameters.AddWithValue("idChofer", idChofer);
            comando.Parameters.AddWithValue("idCliente", idCliente);
            comando.Parameters.AddWithValue("fechaViaje", fechaViaje);
            comando.Parameters.AddWithValue("origen", origen);
            comando.Parameters.AddWithValue("destino", destino);
            comando.Parameters.AddWithValue("carga", carga);
            comando.Parameters.AddWithValue("costo", costo);
            comando.Parameters.AddWithValue("observacionViaje", observacionViaje);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion1.CerrarConexion();
        }
        public void EditarDViaje(Int64 idViaje, Int32 idCamion, Int32 idChofer, Int32 idCliente, string fechaViaje, string origen, string destino, string carga, string costo, string observacionViaje)
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "EditarViaje";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("idViaje", idViaje);
            comando.Parameters.AddWithValue("idCamion", idCamion);
            comando.Parameters.AddWithValue("idChofer", idChofer);
            comando.Parameters.AddWithValue("idCliente", idCliente);
            comando.Parameters.AddWithValue("fechaViaje", fechaViaje);
            comando.Parameters.AddWithValue("origen", origen);
            comando.Parameters.AddWithValue("destino", destino);
            comando.Parameters.AddWithValue("carga", carga);
            comando.Parameters.AddWithValue("costo", costo);
            comando.Parameters.AddWithValue("observacionViaje", observacionViaje);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion1.CerrarConexion();
        }

        public void EliminarDViaje(Int64 idViaje)
        {
            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "EliminarViaje";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idViaje", idViaje);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion1.CerrarConexion();

        }
    }
}
