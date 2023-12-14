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
    public class CN_Viaje
    {
        private CD_Viajes objetoV = new CD_Viajes();

        public DataTable MostrarViajes()
        {
            DataTable tabla = new DataTable();
            tabla = objetoV.Mostrar();
            return tabla;
        }

        public void InsertarNViaje(string idCamion, string idChofer, string idCliente, string fechaViaje, string origen, string destino, string carga, string costo, string observacionViaje)
        {
            objetoV.InsertarDViaje(Convert.ToInt32(idCamion), Convert.ToInt32(idChofer), Convert.ToInt32(idCliente), fechaViaje, origen, destino, carga, costo, observacionViaje);
        }
        public void EditarNViaje(string idViaje, string idCamion, string idChofer, string idCliente, string fechaViaje, string origen, string destino, string carga, string costo, string observacionViaje)
        {
            objetoV.EditarDViaje(Convert.ToInt64(idViaje), Convert.ToInt32(idCamion), Convert.ToInt32(idChofer), Convert.ToInt32(idCliente), fechaViaje, origen, destino, carga, costo, observacionViaje);
        }
        public void EliminarNViaje(string idViaje)
        {
            objetoV.EliminarDViaje(Convert.ToInt64(idViaje));
        }
    }
}
