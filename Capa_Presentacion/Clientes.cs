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

    public partial class Clientes : Form
    {
        CN_Cliente objetoCliN = new CN_Cliente();
        private bool EditarC = false;
        private string idCliente = null;

        public Clientes()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            MostrarCliente();
            dataGridView1.Columns[0].Width = 65;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 350;

        }
        private void MostrarCliente()
        {
            CN_Cliente objetoCliN = new CN_Cliente();
            dataGridView1.DataSource = objetoCliN.MostrarCliente();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (EditarC == false)
                try
                {
                    objetoCliN.InsertarNCliente(txtNombreCliente.Text, txtTelCliente.Text, txtDirCliente.Text, txtCorreoCliente.Text, txtObsCliente.Text);
                    MessageBox.Show("El cliente fue agregado correctamente");
                    MostrarCliente();
                    LimpiarFormCliente();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar el cliente por: " + ex);
                }
            if (EditarC == true)
            {
                try
                {
                    objetoCliN.EditarNCliente(idCliente, txtNombreCliente.Text, txtTelCliente.Text, txtDirCliente.Text, txtCorreoCliente.Text, txtObsCliente.Text);
                    MessageBox.Show("El cliente se edito correctamente");
                    MostrarCliente();
                    LimpiarFormCliente();
                    EditarC = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar por: " + ex);
                }
            }
        }
        private void LimpiarFormCliente()
        {
            txtNombreCliente.Clear();
            txtTelCliente.Clear();
            txtDirCliente.Clear();
            txtCorreoCliente.Clear();
            txtObsCliente.Clear();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu1 = new Menu();
            menu1.Show();
            Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Salir salir1 = new Salir();
            salir1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditarC = true;
                txtNombreCliente.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtTelCliente.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                txtDirCliente.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                txtCorreoCliente.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                txtObsCliente.Text = dataGridView1.CurrentRow.Cells["Observación"].Value.ToString();
                idCliente = dataGridView1.CurrentRow.Cells["ID Cliente"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idCliente = dataGridView1.CurrentRow.Cells["ID Cliente"].Value.ToString();
                DialogResult result = MessageBox.Show("¿Seguro quieres eliminar el Cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    objetoCliN.EliminarNCliente(idCliente);
                    MessageBox.Show("Cliente eliminado corretamente");
                    MostrarCliente();
                }
            }
            else
                MessageBox.Show("Seleccione una Fila por favor");
        }
    }
}
