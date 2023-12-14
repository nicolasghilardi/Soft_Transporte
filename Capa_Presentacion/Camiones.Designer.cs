namespace Capa_Presentacion
{
    partial class Camiones
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
            btnCerrar = new Button();
            btnMximizar = new Button();
            btnMinimizar = new Button();
            btnMenu = new Button();
            button5 = new Button();
            button4 = new Button();
            btnClose = new Button();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            btnEliminarCamion = new Button();
            btnEditarCamion = new Button();
            btnAgregarCamion = new Button();
            txtPatenteCamion = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtObsCamion = new TextBox();
            label6 = new Label();
            txtCapacidadCamion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtModeloCamion = new TextBox();
            label1 = new Label();
            txtMarcaCamion = new TextBox();
            dataGridCamiones = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCamiones).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(79, 111, 82);
            panelTop.Controls.Add(btnCerrar);
            panelTop.Controls.Add(btnMximizar);
            panelTop.Controls.Add(btnMinimizar);
            panelTop.Controls.Add(btnMenu);
            panelTop.Controls.Add(button5);
            panelTop.Controls.Add(button4);
            panelTop.Controls.Add(btnClose);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1238, 38);
            panelTop.TabIndex = 17;
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
            btnCerrar.Location = new Point(1195, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(31, 29);
            btnCerrar.TabIndex = 12;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMximizar
            // 
            btnMximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMximizar.Cursor = Cursors.Hand;
            btnMximizar.FlatAppearance.BorderSize = 0;
            btnMximizar.FlatAppearance.MouseDownBackColor = Color.White;
            btnMximizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnMximizar.FlatStyle = FlatStyle.Flat;
            btnMximizar.Image = Properties.Resources.max;
            btnMximizar.Location = new Point(1160, 3);
            btnMximizar.Name = "btnMximizar";
            btnMximizar.Size = new Size(31, 29);
            btnMximizar.TabIndex = 11;
            btnMximizar.UseVisualStyleBackColor = true;
            btnMximizar.Click += btnMximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = Properties.Resources.min;
            btnMinimizar.Location = new Point(1123, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(31, 29);
            btnMinimizar.TabIndex = 10;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
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
            btnMenu.TabIndex = 9;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(107, 41);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 33;
            label7.Text = "CAMIONES";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Prueba_Los_Pamperos_;
            pictureBox1.Location = new Point(91, 320);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // btnEliminarCamion
            // 
            btnEliminarCamion.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarCamion.Location = new Point(3, 248);
            btnEliminarCamion.Name = "btnEliminarCamion";
            btnEliminarCamion.Size = new Size(88, 23);
            btnEliminarCamion.TabIndex = 8;
            btnEliminarCamion.Text = "Eliminar";
            btnEliminarCamion.UseVisualStyleBackColor = true;
            btnEliminarCamion.Click += btnEliminarCamion_Click;
            // 
            // btnEditarCamion
            // 
            btnEditarCamion.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarCamion.Location = new Point(117, 248);
            btnEditarCamion.Name = "btnEditarCamion";
            btnEditarCamion.Size = new Size(88, 23);
            btnEditarCamion.TabIndex = 7;
            btnEditarCamion.Text = "Editar";
            btnEditarCamion.UseVisualStyleBackColor = true;
            btnEditarCamion.Click += btnEditarCamion_Click;
            // 
            // btnAgregarCamion
            // 
            btnAgregarCamion.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCamion.Location = new Point(232, 248);
            btnAgregarCamion.Name = "btnAgregarCamion";
            btnAgregarCamion.Size = new Size(88, 23);
            btnAgregarCamion.TabIndex = 6;
            btnAgregarCamion.Text = "Agregar";
            btnAgregarCamion.UseVisualStyleBackColor = true;
            btnAgregarCamion.Click += btnAgregarCamion_Click;
            // 
            // txtPatenteCamion
            // 
            txtPatenteCamion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatenteCamion.Location = new Point(107, 153);
            txtPatenteCamion.Margin = new Padding(3, 2, 3, 2);
            txtPatenteCamion.Name = "txtPatenteCamion";
            txtPatenteCamion.Size = new Size(213, 22);
            txtPatenteCamion.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 153);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 27;
            label4.Text = "Patente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(-2, 206);
            label5.Name = "label5";
            label5.Size = new Size(101, 19);
            label5.TabIndex = 26;
            label5.Text = "Observación:";
            // 
            // txtObsCamion
            // 
            txtObsCamion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtObsCamion.Location = new Point(106, 206);
            txtObsCamion.Margin = new Padding(3, 2, 3, 2);
            txtObsCamion.Name = "txtObsCamion";
            txtObsCamion.Size = new Size(214, 22);
            txtObsCamion.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 180);
            label6.Name = "label6";
            label6.Size = new Size(96, 19);
            label6.TabIndex = 24;
            label6.Text = "Capacidad:";
            // 
            // txtCapacidadCamion
            // 
            txtCapacidadCamion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCapacidadCamion.Location = new Point(106, 180);
            txtCapacidadCamion.Margin = new Padding(3, 2, 3, 2);
            txtCapacidadCamion.Name = "txtCapacidadCamion";
            txtCapacidadCamion.Size = new Size(214, 22);
            txtCapacidadCamion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(75, 76);
            label3.Name = "label3";
            label3.Size = new Size(26, 19);
            label3.TabIndex = 22;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 127);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 21;
            label2.Text = "Modelo:";
            // 
            // txtModeloCamion
            // 
            txtModeloCamion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtModeloCamion.Location = new Point(106, 127);
            txtModeloCamion.Margin = new Padding(3, 2, 3, 2);
            txtModeloCamion.Name = "txtModeloCamion";
            txtModeloCamion.Size = new Size(214, 22);
            txtModeloCamion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 101);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 19;
            label1.Text = "Marca:";
            // 
            // txtMarcaCamion
            // 
            txtMarcaCamion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarcaCamion.Location = new Point(106, 101);
            txtMarcaCamion.Margin = new Padding(3, 2, 3, 2);
            txtMarcaCamion.Name = "txtMarcaCamion";
            txtMarcaCamion.Size = new Size(214, 22);
            txtMarcaCamion.TabIndex = 1;
            // 
            // dataGridCamiones
            // 
            dataGridCamiones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCamiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCamiones.BackgroundColor = Color.FromArgb(236, 227, 206);
            dataGridCamiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCamiones.Location = new Point(334, 45);
            dataGridCamiones.Name = "dataGridCamiones";
            dataGridCamiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCamiones.Size = new Size(897, 449);
            dataGridCamiones.TabIndex = 34;
            // 
            // Camiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 227, 206);
            ClientSize = new Size(1238, 501);
            Controls.Add(dataGridCamiones);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminarCamion);
            Controls.Add(btnEditarCamion);
            Controls.Add(btnAgregarCamion);
            Controls.Add(txtPatenteCamion);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtObsCamion);
            Controls.Add(label6);
            Controls.Add(txtCapacidadCamion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtModeloCamion);
            Controls.Add(label1);
            Controls.Add(txtMarcaCamion);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Camiones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Camiones";
            WindowState = FormWindowState.Maximized;
            Load += Camiones_Load;
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCamiones).EndInit();
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
        private Button btnMximizar;
        private Button btnCerrar;
        private Label label7;
        private PictureBox pictureBox1;
        private Button btnEliminarCamion;
        private Button btnEditarCamion;
        private Button btnAgregarCamion;
        private TextBox txtPatenteCamion;
        private Label label4;
        private Label label5;
        private TextBox txtObsCamion;
        private Label label6;
        private TextBox txtCapacidadCamion;
        private Label label3;
        private Label label2;
        private TextBox txtModeloCamion;
        private Label label1;
        private TextBox txtMarcaCamion;
        private DataGridView dataGridCamiones;
    }
}