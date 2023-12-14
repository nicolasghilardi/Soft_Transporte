using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace Capa_Presentacion
{
    public partial class Viajes : Form
    {
        CN_Viaje objetoV = new CN_Viaje();
        private bool EditarV = false;
        private string idViaje = null;
        public Viajes()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void txtNombreChofer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Viajes_Load(object sender, EventArgs e)
        {
            MostrarViajes();
            cmbFechaViaje.Value = DateTime.Now;
            ListarCliente();
            ListarCamion();
            ListarChofer();
        }
        private void MostrarViajes()
        {
            CN_Viaje objetoV = new CN_Viaje();
            dataGridViajes.DataSource = objetoV.MostrarViajes();
        }

        private void ListarCliente()
        {
            CN_Cliente objetoLC = new CN_Cliente();
            cmbCliente.DataSource = objetoLC.ListarNCliente();
            cmbCliente.DisplayMember = "nombreCliente";
            cmbCliente.ValueMember = "idCliente";
        }

        private void ListarCamion()
        {
            CN_Camion objetoLC = new CN_Camion();
            cmbCamion.DataSource = objetoLC.ListarNCamion();
            cmbCamion.DisplayMember = "patente";
            cmbCamion.ValueMember = "idCamion";
        }
        private void ListarChofer()
        {
            CN_Chofer objetoLC = new CN_Chofer();
            cmbChofer.DataSource = objetoLC.ListarNChofer();
            cmbChofer.DisplayMember = "nombreChofer";
            cmbChofer.ValueMember = "idChofer";
        }

        private void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            if (EditarV == false)
                try
                {
                    objetoV.InsertarNViaje(Convert.ToString(cmbCamion.SelectedValue), Convert.ToString(cmbChofer.SelectedValue), Convert.ToString(cmbCliente.SelectedValue), cmbFechaViaje.Text, txtOrigen.Text, txtDestino.Text, txtCarga.Text, txtCosto.Text, txtObservacionViaje.Text);
                    MessageBox.Show("El viaje fue agregado correctamente");
                    MostrarViajes();
                    LimpiarFormViajes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar por: " + ex);
                }
            if (EditarV == true)
            {
                try
                {
                    objetoV.EditarNViaje(idViaje, Convert.ToString(cmbCamion.SelectedValue), Convert.ToString(cmbChofer.SelectedValue), Convert.ToString(cmbCliente.SelectedValue), cmbFechaViaje.Text, txtOrigen.Text, txtDestino.Text, txtCarga.Text, txtCosto.Text, txtObservacionViaje.Text);
                    MessageBox.Show("El viaje fue modificado correctamente");
                    MostrarViajes();
                    LimpiarFormViajes();
                    EditarV = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar por: " + ex);

                }
            }
        }
        private void LimpiarFormViajes()
        {
            cmbCliente.Text = "";
            cmbCamion.Text = "";
            cmbChofer.Text = "";
            txtOrigen.Clear();
            txtDestino.Clear();
            txtCarga.Clear();
            txtCosto.Clear();
            txtObservacionViaje.Clear();
        }

        private void btnEditarViaje_Click(object sender, EventArgs e)
        {
            if (dataGridViajes.SelectedRows.Count > 0)
            {
                EditarV = true;
                cmbCamion.Text = dataGridViajes.CurrentRow.Cells["Camion"].Value.ToString();
                cmbChofer.Text = dataGridViajes.CurrentRow.Cells["Chofer"].Value.ToString();
                cmbCliente.Text = dataGridViajes.CurrentRow.Cells["Cliente"].Value.ToString();
                cmbFechaViaje.Text = dataGridViajes.CurrentRow.Cells["Fecha"].Value.ToString();
                txtOrigen.Text = dataGridViajes.CurrentRow.Cells["Origen"].Value.ToString();
                txtDestino.Text = dataGridViajes.CurrentRow.Cells["Destino"].Value.ToString();
                txtCarga.Text = dataGridViajes.CurrentRow.Cells["Carga"].Value.ToString();
                txtCosto.Text = dataGridViajes.CurrentRow.Cells["Costo"].Value.ToString();
                txtObservacionViaje.Text = dataGridViajes.CurrentRow.Cells["Observación"].Value.ToString();
                idViaje = dataGridViajes.CurrentRow.Cells["ID"].Value.ToString();
            }
        }

        private void btnEliminarViaje_Click(object sender, EventArgs e)
        {
            if (dataGridViajes.SelectedRows.Count > 0)
            {
                idViaje = dataGridViajes.CurrentRow.Cells["ID"].Value.ToString();
                DialogResult result = MessageBox.Show("¿Seguro quieres eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    objetoV.EliminarNViaje(idViaje);
                    MessageBox.Show("Viaje eliminado corretamente");
                    MostrarViajes();
                }
            }
            else
                MessageBox.Show("Seleccione una Fila por favor");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Salir salir1 = new Salir();
            salir1.Show();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu1 = new Menu();
            menu1.Show();
            Hide();
        }
    }
}
