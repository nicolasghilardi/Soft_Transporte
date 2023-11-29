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
    public class CN_Chofer
    {
        private CD_Choferes objetoChofD = new CD_Choferes();
        private CD_Choferes objetoLCh = new CD_Choferes();

        public DataTable MostrarChofer()
        {
            DataTable tabla = new DataTable();
            tabla = objetoChofD.Mostrar();
            return tabla;
        }

        public void InsertarNChofer(string nombreChofer, string licencia, string documento, string telefono, string antiguedad)
        {
            objetoChofD.InsertarDChofer(nombreChofer, licencia, documento, telefono, antiguedad);
        }
        public void EditarNChofer(string idChofer, string nombreChofer, string licencia, string documento, string telefono, string antiguedad)
        {
            objetoChofD.EditarDChofer(Convert.ToInt32(idChofer), nombreChofer, licencia, documento, telefono, antiguedad);
        }

        public void EliminarNChofer(string idChofer)
        {
            objetoChofD.EliminarDChofer(Convert.ToInt32(idChofer));
        }
        public DataTable ListarNChofer()
        {
            DataTable tabla = new DataTable();
            tabla = objetoLCh.ListarDChofer();
            return tabla;
        }
    }
}
