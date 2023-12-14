namespace Capa_Presentacion
{
    partial class Viajes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            btnMinimizar = new Button();
            btnMaximizar = new Button();
            btnMenu = new Button();
            btnCerrar = new Button();
            button5 = new Button();
            button4 = new Button();
            btnClose = new Button();
            label3 = new Label();
            label1 = new Label();
            txtOrigen = new TextBox();
            cmbCamion = new ComboBox();
            cmbChofer = new ComboBox();
            label2 = new Label();
            cmbCliente = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtDestino = new TextBox();
            label8 = new Label();
            txtCosto = new TextBox();
            label9 = new Label();
            txtCarga = new TextBox();
            label10 = new Label();
            txtObservacionViaje = new TextBox();
            btnEliminarViaje = new Button();
            btnEditarViaje = new Button();
            btnAgregarViaje = new Button();
            pictureBox1 = new PictureBox();
            dataGridViajes = new DataGridView();
            cmbFechaViaje = new DateTimePicker();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViajes).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(79, 111, 82);
            panelTop.Controls.Add(btnMinimizar);
            panelTop.Controls.Add(btnMaximizar);
            panelTop.Controls.Add(btnMenu);
            panelTop.Controls.Add(btnCerrar);
            panelTop.Controls.Add(button5);
            panelTop.Controls.Add(button4);
            panelTop.Controls.Add(btnClose);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1238, 35);
            panelTop.TabIndex = 17;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = Properties.Resources.min;
            btnMinimizar.Location = new Point(1127, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(31, 29);
            btnMinimizar.TabIndex = 14;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatAppearance.MouseDownBackColor = Color.White;
            btnMaximizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Image = Properties.Resources.max;
            btnMaximizar.Location = new Point(1164, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(31, 29);
            btnMaximizar.TabIndex = 15;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(8, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(59, 29);
            btnMenu.TabIndex = 13;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = Properties.Resources.close;
            btnCerrar.Location = new Point(1201, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(31, 29);
            btnCerrar.TabIndex = 16;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.min;
            button5.Location = new Point(2176, 3);
            button5.Name = "button5";
            button5.Size = new Size(31, 29);
            button5.TabIndex = 2;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.White;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.max;
            button4.Location = new Point(2213, 3);
            button4.Name = "button4";
            button4.Size = new Size(31, 29);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(2250, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(31, 29);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 41);
            label3.Name = "label3";
            label3.Size = new Size(26, 19);
            label3.TabIndex = 41;
            label3.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 40;
            label1.Text = "Camion:";
            // 
            // txtOrigen
            // 
            txtOrigen.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrigen.Location = new Point(614, 70);
            txtOrigen.Margin = new Padding(3, 2, 3, 2);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(289, 22);
            txtOrigen.TabIndex = 7;
            txtOrigen.TextChanged += txtNombreChofer_TextChanged;
            // 
            // cmbCamion
            // 
            cmbCamion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCamion.FormattingEnabled = true;
            cmbCamion.Location = new Point(86, 67);
            cmbCamion.Name = "cmbCamion";
            cmbCamion.Size = new Size(165, 25);
            cmbCamion.TabIndex = 1;
            // 
            // cmbChofer
            // 
            cmbChofer.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbChofer.FormattingEnabled = true;
            cmbChofer.Location = new Point(86, 98);
            cmbChofer.Name = "cmbChofer";
            cmbChofer.Size = new Size(165, 25);
            cmbChofer.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 98);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 43;
            label2.Text = "Chofer:";
            // 
            // cmbCliente
            // 
            cmbCliente.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(86, 127);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(165, 25);
            cmbCliente.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 127);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 45;
            label4.Text = "Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(273, 71);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 47;
            label5.Text = "Fecha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(549, 71);
            label6.Name = "label6";
            label6.Size = new Size(59, 19);
            label6.TabIndex = 49;
            label6.Text = "Origen:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(545, 99);
            label7.Name = "label7";
            label7.Size = new Size(63, 19);
            label7.TabIndex = 51;
            label7.Text = "Destino:";
            // 
            // txtDestino
            // 
            txtDestino.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDestino.Location = new Point(614, 98);
            txtDestino.Margin = new Padding(3, 2, 3, 2);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(289, 22);
            txtDestino.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(278, 130);
            label8.Name = "label8";
            label8.Size = new Size(52, 19);
            label8.TabIndex = 55;
            label8.Text = "Costo:";
            // 
            // txtCosto
            // 
            txtCosto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCosto.Location = new Point(336, 130);
            txtCosto.Margin = new Padding(3, 2, 3, 2);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(167, 22);
            txtCosto.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(273, 102);
            label9.Name = "label9";
            label9.Size = new Size(57, 19);
            label9.TabIndex = 53;
            label9.Text = "Carga:";
            // 
            // txtCarga
            // 
            txtCarga.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCarga.Location = new Point(336, 99);
            txtCarga.Margin = new Padding(3, 2, 3, 2);
            txtCarga.Name = "txtCarga";
            txtCarga.Size = new Size(167, 22);
            txtCarga.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(507, 129);
            label10.Name = "label10";
            label10.Size = new Size(101, 19);
            label10.TabIndex = 57;
            label10.Text = "Observación:";
            // 
            // txtObservacionViaje
            // 
            txtObservacionViaje.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtObservacionViaje.Location = new Point(614, 128);
            txtObservacionViaje.Margin = new Padding(3, 2, 3, 2);
            txtObservacionViaje.Name = "txtObservacionViaje";
            txtObservacionViaje.Size = new Size(289, 22);
            txtObservacionViaje.TabIndex = 9;
            // 
            // btnEliminarViaje
            // 
            btnEliminarViaje.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarViaje.Location = new Point(933, 130);
            btnEliminarViaje.Name = "btnEliminarViaje";
            btnEliminarViaje.Size = new Size(88, 23);
            btnEliminarViaje.TabIndex = 12;
            btnEliminarViaje.Text = "Eliminar";
            btnEliminarViaje.UseVisualStyleBackColor = true;
            btnEliminarViaje.Click += btnEliminarViaje_Click;
            // 
            // btnEditarViaje
            // 
            btnEditarViaje.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarViaje.Location = new Point(933, 98);
            btnEditarViaje.Name = "btnEditarViaje";
            btnEditarViaje.Size = new Size(88, 23);
            btnEditarViaje.TabIndex = 11;
            btnEditarViaje.Text = "Editar";
            btnEditarViaje.UseVisualStyleBackColor = true;
            btnEditarViaje.Click += btnEditarViaje_Click;
            // 
            // btnAgregarViaje
            // 
            btnAgregarViaje.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarViaje.Location = new Point(933, 66);
            btnAgregarViaje.Name = "btnAgregarViaje";
            btnAgregarViaje.Size = new Size(88, 23);
            btnAgregarViaje.TabIndex = 10;
            btnAgregarViaje.Text = "Agregar";
            btnAgregarViaje.UseVisualStyleBackColor = true;
            btnAgregarViaje.Click += btnAgregarViaje_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Prueba_Los_Pamperos_;
            pictureBox1.Location = new Point(1068, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            // 
            // dataGridViajes
            // 
            dataGridViajes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViajes.BackgroundColor = Color.FromArgb(236, 227, 206);
            dataGridViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViajes.Location = new Point(12, 171);
            dataGridViajes.Name = "dataGridViajes";
            dataGridViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViajes.Size = new Size(1214, 318);
            dataGridViajes.TabIndex = 17;
            // 
            // cmbFechaViaje
            // 
            cmbFechaViaje.Format = DateTimePickerFormat.Short;
            cmbFechaViaje.Location = new Point(336, 66);
            cmbFechaViaje.Name = "cmbFechaViaje";
            cmbFechaViaje.Size = new Size(167, 23);
            cmbFechaViaje.TabIndex = 4;
            cmbFechaViaje.Value = new DateTime(2023, 12, 12, 11, 17, 41, 0);
            // 
            // Viajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 227, 206);
            ClientSize = new Size(1238, 501);
            Controls.Add(cmbFechaViaje);
            Controls.Add(dataGridViajes);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminarViaje);
            Controls.Add(btnEditarViaje);
            Controls.Add(btnAgregarViaje);
            Controls.Add(label10);
            Controls.Add(txtObservacionViaje);
            Controls.Add(label8);
            Controls.Add(txtCosto);
            Controls.Add(label9);
            Controls.Add(txtCarga);
            Controls.Add(label7);
            Controls.Add(txtDestino);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbCliente);
            Controls.Add(label4);
            Controls.Add(cmbChofer);
            Controls.Add(label2);
            Controls.Add(cmbCamion);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtOrigen);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Viajes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Viajes";
            WindowState = FormWindowState.Maximized;
            Load += Viajes_Load;
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViajes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Button btnMenu;
        private Button button5;
        private Button button4;
        private Button btnClose;
        private Button btnMinimizar;
        private Button btnMaximizar;
        private Button btnCerrar;
        private Label label3;
        private Label label1;
        private TextBox txtOrigen;
        private ComboBox cmbCamion;
        private ComboBox cmbChofer;
        private Label label2;
        private ComboBox cmbCliente;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtDestino;
        private Label label8;
        private TextBox txtCosto;
        private Label label9;
        private TextBox txtCarga;
        private Label label10;
        private TextBox txtObservacionViaje;
        private Button btnEliminarViaje;
        private Button btnEditarViaje;
        private Button btnAgregarViaje;
        private PictureBox pictureBox1;
        private DataGridView dataGridViajes;
        private DateTimePicker cmbFechaViaje;
    }
}