using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace Capa_Presentacion
{
    public partial class Camiones : Form
    {
        CN_Camion objetoCamN = new CN_Camion();
        private bool EditarC = false;
        private string idCamion = null;
        public Camiones()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Camiones_Load(object sender, EventArgs e)
        {
            MostrarCamion();
        }

        private void MostrarCamion()
        {
            CN_Camion objetoCamN = new CN_Camion();
            dataGridCamiones.DataSource = objetoCamN.MostrarCamion();
        }

        private void btnAgregarCamion_Click(object sender, EventArgs e)
        {
            if (EditarC == false)
                try
                {
                    objetoCamN.InsertarNCamion(txtMarcaCamion.Text, txtModeloCamion.Text, txtPatenteCamion.Text, txtCapacidadCamion.Text, txtObsCamion.Text);
                    MessageBox.Show("El camion fue agregado correctamente");
                    MostrarCamion();
                    LimpiarFormCamion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar el cliente por: " + ex);
                }
            if (EditarC == true)
            {
                try
                {
                    objetoCamN.EditarNCamion(idCamion, txtMarcaCamion.Text, txtModeloCamion.Text, txtPatenteCamion.Text, txtCapacidadCamion.Text, txtObsCamion.Text);
                    MessageBox.Show("El camion se edito correctamente");
                    MostrarCamion();
                    LimpiarFormCamion();
                    EditarC = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar por: " + ex);
                }
            }
        }
        private void LimpiarFormCamion()
        {
            txtMarcaCamion.Clear();
            txtModeloCamion.Clear();
            txtPatenteCamion.Clear();
            txtCapacidadCamion.Clear();
            txtObsCamion.Clear();
        }

        private void btnEditarCamion_Click(object sender, EventArgs e)
        {
            if (dataGridCamiones.SelectedRows.Count > 0)
            {
                EditarC = true;
                txtMarcaCamion.Text = dataGridCamiones.CurrentRow.Cells["Marca"].Value.ToString();
                txtModeloCamion.Text = dataGridCamiones.CurrentRow.Cells["Modelo"].Value.ToString();
                txtPatenteCamion.Text = dataGridCamiones.CurrentRow.Cells["Patente"].Value.ToString();
                txtCapacidadCamion.Text = dataGridCamiones.CurrentRow.Cells["Capacidad"].Value.ToString();
                txtObsCamion.Text = dataGridCamiones.CurrentRow.Cells["Observación"].Value.ToString();
                idCamion = dataGridCamiones.CurrentRow.Cells["ID Camion"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btnEliminarCamion_Click(object sender, EventArgs e)
        {
            if (dataGridCamiones.SelectedRows.Count > 0)
            {
                idCamion = dataGridCamiones.CurrentRow.Cells["ID Camion"].Value.ToString();
                objetoCamN.EliminarNCamion(idCamion);
                MessageBox.Show("Camion eliminado corretamente");
                MostrarCamion();
            }
            else
                MessageBox.Show("Seleccione una Fila por favor");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu1 = new Menu();
            menu1.Show();
            Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Salir salir1 = new Salir();
            salir1.Show();
        }

        private void btnMximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
