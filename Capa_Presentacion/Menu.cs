using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir salir1 = new Salir();
            salir1.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes1 = new Clientes();
            clientes1.Show();
            Hide();
        }

        private void btnCamiones_Click(object sender, EventArgs e)
        {
            Camiones camiones1 = new Camiones();
            camiones1.Show();
            Hide();
        }
    }
}
