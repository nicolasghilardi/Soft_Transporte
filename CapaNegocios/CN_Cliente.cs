using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Cliente
    {
        private CD_Clientes objetoCliD = new CD_Clientes();
        private CD_Clientes objetoLC = new CD_Clientes();

        public DataTable MostrarCliente()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCliD.Mostrar();
            return tabla;
        }
        public void InsertarNCliente(string nombreCliente, string telCliente,string direccionCliente, string correoCliente, string observacionCliente)
        {
            objetoCliD.InsertarDCliente(nombreCliente, telCliente, direccionCliente,correoCliente, observacionCliente);
        }
        public void EditarNCliente(string idCliente, string nombreCliente, string telCliente,string direccionCliente, string correoCliente, string observacionCliente)
        {
            objetoCliD.EditarDCliente(Convert.ToInt32(idCliente), nombreCliente, telCliente, direccionCliente, correoCliente, observacionCliente);
        }
        public void EliminarNCliente(string idCliente)
        {
            objetoCliD.EliminarDCliente(Convert.ToInt32(idCliente));
        }
        public DataTable ListarNCliente()
        {
            DataTable tabla = new DataTable();
            tabla = objetoLC.ListarDCliente();
            return tabla;
        }
    }
}
