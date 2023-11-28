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
    public class CN_Camion
    {
        private CD_Camion objetoCD = new CD_Camion();
        private CD_Camion objetoLC = new CD_Camion();

        public DataTable MostrarCamion()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarNCamion(string marca, string modelo, string patente, string capacidad, string observacionCamion)
        {
            objetoCD.InsertarDCamion(marca, Convert.ToInt32(modelo), patente, capacidad, observacionCamion);
        }
        public void EditarNCamion(string idCamion, string marca, string modelo, string patente, string capacidad, string observacionCamion)
        {
            objetoCD.EditarDCamion(Convert.ToInt32(idCamion), marca, Convert.ToInt32(modelo), patente, capacidad,observacionCamion);
        }
        public void EliminarNCamion(string idCamion)
        {
            objetoCD.EliminarDCamion(Convert.ToInt32(idCamion));
        }
        public DataTable ListarNCamion()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListarDCamion();
            return tabla;
        }
    }
}
