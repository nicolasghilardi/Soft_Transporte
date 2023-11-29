using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocios;

namespace Capa_Presentacion
{
    public partial class Choferes : Form
    {
        CN_Chofer objetoChN = new CN_Chofer();
        private bool EditarC = false;
        private string idChofer = null;
        public Choferes()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Choferes_Load(object sender, EventArgs e)
        {
            MostrarChofer();

        }
        private void MostrarChofer()
        {
            CN_Chofer objetoChN = new CN_Chofer();
            dataGridChoferes.DataSource = objetoChN.MostrarChofer();
        }

        private void btnAgregarChofer_Click(object sender, EventArgs e)
        {
            if (EditarC == false)
                try
                {
                    objetoChN.InsertarNChofer(txtNombreChofer.Text, txtLicencia.Text, txtDocumento.Text, txtTelefono.Text, txtAntiguedad.Text);
                    MessageBox.Show("El Chofer fue agregado correctamente");
                    MostrarChofer();
                    LimpiarFormChofer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar el Chofer por: " + ex);
                }
            if (EditarC == true)
            {
                try
                {
                    objetoChN.EditarNChofer(idChofer, txtNombreChofer.Text, txtLicencia.Text, txtDocumento.Text, txtTelefono.Text, txtAntiguedad.Text);
                    MessageBox.Show("El Chofer se edito correctamente");
                    MostrarChofer();
                    LimpiarFormChofer();
                    EditarC = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudeo editar por: " + ex);
                }

            }
        }
        private void LimpiarFormChofer()
        {
            txtNombreChofer.Clear();
            txtLicencia.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
            txtAntiguedad.Clear();
        }

        private void btnEditarChofer_Click(object sender, EventArgs e)
        {
            if (dataGridChoferes.SelectedRows.Count > 0)
            {
                EditarC = true;
                txtNombreChofer.Text = dataGridChoferes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtLicencia.Text = dataGridChoferes.CurrentRow.Cells["Vencimiento Licencia"].Value.ToString();
                txtDocumento.Text = dataGridChoferes.CurrentRow.Cells["DNI"].Value.ToString();
                txtTelefono.Text = dataGridChoferes.CurrentRow.Cells["Telefono"].Value.ToString();
                txtAntiguedad.Text = dataGridChoferes.CurrentRow.Cells["Antiguedad"].Value.ToString();
                idChofer = dataGridChoferes.CurrentRow.Cells["ID Chofer"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btnEliminarChofer_Click(object sender, EventArgs e)
        {
            if (dataGridChoferes.SelectedRows.Count > 0)
            {
                idChofer = dataGridChoferes.CurrentRow.Cells["ID Chofer"].Value.ToString();
                objetoChN.EliminarNChofer(idChofer);
                MessageBox.Show("Chofer eliminado corretamente");
                MostrarChofer();
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

        private void btnMaximizar_Click(object sender, EventArgs e)
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
