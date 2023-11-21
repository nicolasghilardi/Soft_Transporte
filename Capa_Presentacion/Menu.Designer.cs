namespace Capa_Presentacion
{
    partial class Menu
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
            btnCamiones = new Button();
            btnChoferes = new Button();
            btnClientes = new Button();
            btnViajes = new Button();
            btnMantenimiento = new Button();
            btnFinanzas = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCamiones
            // 
            btnCamiones.BackColor = Color.FromArgb(79, 111, 82);
            btnCamiones.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCamiones.ForeColor = Color.White;
            btnCamiones.Location = new Point(12, 22);
            btnCamiones.Name = "btnCamiones";
            btnCamiones.Size = new Size(179, 46);
            btnCamiones.TabIndex = 0;
            btnCamiones.Text = "Camiones";
            btnCamiones.UseVisualStyleBackColor = false;
            // 
            // btnChoferes
            // 
            btnChoferes.BackColor = Color.FromArgb(79, 111, 82);
            btnChoferes.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnChoferes.ForeColor = Color.White;
            btnChoferes.Location = new Point(12, 74);
            btnChoferes.Name = "btnChoferes";
            btnChoferes.Size = new Size(179, 46);
            btnChoferes.TabIndex = 1;
            btnChoferes.Text = "Choferes";
            btnChoferes.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(79, 111, 82);
            btnClientes.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(12, 126);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(179, 46);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnViajes
            // 
            btnViajes.BackColor = Color.FromArgb(79, 111, 82);
            btnViajes.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnViajes.ForeColor = Color.White;
            btnViajes.Location = new Point(12, 178);
            btnViajes.Name = "btnViajes";
            btnViajes.Size = new Size(179, 46);
            btnViajes.TabIndex = 3;
            btnViajes.Text = "Viajes";
            btnViajes.UseVisualStyleBackColor = false;
            // 
            // btnMantenimiento
            // 
            btnMantenimiento.BackColor = Color.FromArgb(79, 111, 82);
            btnMantenimiento.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMantenimiento.ForeColor = Color.White;
            btnMantenimiento.Location = new Point(12, 230);
            btnMantenimiento.Name = "btnMantenimiento";
            btnMantenimiento.Size = new Size(179, 46);
            btnMantenimiento.TabIndex = 4;
            btnMantenimiento.Text = "Mantenimiento";
            btnMantenimiento.UseVisualStyleBackColor = false;
            // 
            // btnFinanzas
            // 
            btnFinanzas.BackColor = Color.FromArgb(79, 111, 82);
            btnFinanzas.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinanzas.ForeColor = Color.White;
            btnFinanzas.Location = new Point(12, 282);
            btnFinanzas.Name = "btnFinanzas";
            btnFinanzas.Size = new Size(179, 46);
            btnFinanzas.TabIndex = 5;
            btnFinanzas.Text = "Finanzas";
            btnFinanzas.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(79, 111, 82);
            btnSalir.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(12, 438);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(179, 46);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Prueba_Los_Pamperos_;
            pictureBox1.Location = new Point(374, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(689, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 41);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(329, 30);
            label1.Name = "label1";
            label1.Size = new Size(354, 27);
            label1.TabIndex = 9;
            label1.Text = "Cantidad de Viajes realizados:";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 227, 206);
            ClientSize = new Size(907, 496);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnFinanzas);
            Controls.Add(btnMantenimiento);
            Controls.Add(btnViajes);
            Controls.Add(btnClientes);
            Controls.Add(btnChoferes);
            Controls.Add(btnCamiones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCamiones;
        private Button btnChoferes;
        private Button btnClientes;
        private Button btnViajes;
        private Button btnMantenimiento;
        private Button btnFinanzas;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
    }
}