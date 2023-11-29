namespace Capa_Presentacion
{
    partial class Choferes
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
            btnMenu = new Button();
            btnMaximizar = new Button();
            button5 = new Button();
            btnCerrar = new Button();
            button4 = new Button();
            btnClose = new Button();
            label7 = new Label();
            btnEliminarChofer = new Button();
            btnEditarChofer = new Button();
            btnAgregarChofer = new Button();
            txtDocumento = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtAntiguedad = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtLicencia = new TextBox();
            label1 = new Label();
            txtNombreChofer = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridChoferes = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridChoferes).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(79, 111, 82);
            panelTop.Controls.Add(btnMinimizar);
            panelTop.Controls.Add(btnMenu);
            panelTop.Controls.Add(btnMaximizar);
            panelTop.Controls.Add(button5);
            panelTop.Controls.Add(btnCerrar);
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
            btnMinimizar.Location = new Point(1121, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(31, 29);
            btnMinimizar.TabIndex = 20;
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
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
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
            btnMaximizar.Location = new Point(1158, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(31, 29);
            btnMaximizar.TabIndex = 19;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
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
            btnCerrar.TabIndex = 18;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
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
            label7.Location = new Point(119, 38);
            label7.Name = "label7";
            label7.Size = new Size(104, 23);
            label7.TabIndex = 48;
            label7.Text = "CHOFERES";
            // 
            // btnEliminarChofer
            // 
            btnEliminarChofer.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarChofer.Location = new Point(15, 245);
            btnEliminarChofer.Name = "btnEliminarChofer";
            btnEliminarChofer.Size = new Size(88, 23);
            btnEliminarChofer.TabIndex = 47;
            btnEliminarChofer.Text = "Eliminar";
            btnEliminarChofer.UseVisualStyleBackColor = true;
            btnEliminarChofer.Click += btnEliminarChofer_Click;
            // 
            // btnEditarChofer
            // 
            btnEditarChofer.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarChofer.Location = new Point(129, 245);
            btnEditarChofer.Name = "btnEditarChofer";
            btnEditarChofer.Size = new Size(88, 23);
            btnEditarChofer.TabIndex = 46;
            btnEditarChofer.Text = "Editar";
            btnEditarChofer.UseVisualStyleBackColor = true;
            btnEditarChofer.Click += btnEditarChofer_Click;
            // 
            // btnAgregarChofer
            // 
            btnAgregarChofer.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarChofer.Location = new Point(244, 245);
            btnAgregarChofer.Name = "btnAgregarChofer";
            btnAgregarChofer.Size = new Size(88, 23);
            btnAgregarChofer.TabIndex = 45;
            btnAgregarChofer.Text = "Agregar";
            btnAgregarChofer.UseVisualStyleBackColor = true;
            btnAgregarChofer.Click += btnAgregarChofer_Click;
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.Location = new Point(119, 150);
            txtDocumento.Margin = new Padding(3, 2, 3, 2);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(213, 22);
            txtDocumento.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 150);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 43;
            label4.Text = "Documento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 202);
            label5.Name = "label5";
            label5.Size = new Size(96, 19);
            label5.TabIndex = 42;
            label5.Text = "Antiguedad:";
            // 
            // txtAntiguedad
            // 
            txtAntiguedad.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAntiguedad.Location = new Point(118, 203);
            txtAntiguedad.Margin = new Padding(3, 2, 3, 2);
            txtAntiguedad.Name = "txtAntiguedad";
            txtAntiguedad.Size = new Size(214, 22);
            txtAntiguedad.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(42, 176);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 40;
            label6.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(118, 177);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(214, 22);
            txtTelefono.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(86, 68);
            label3.Name = "label3";
            label3.Size = new Size(26, 19);
            label3.TabIndex = 38;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 126);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 37;
            label2.Text = "Licencia:";
            // 
            // txtLicencia
            // 
            txtLicencia.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLicencia.Location = new Point(118, 124);
            txtLicencia.Margin = new Padding(3, 2, 3, 2);
            txtLicencia.Name = "txtLicencia";
            txtLicencia.Size = new Size(214, 22);
            txtLicencia.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 98);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 35;
            label1.Text = "Nombre:";
            // 
            // txtNombreChofer
            // 
            txtNombreChofer.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreChofer.Location = new Point(118, 98);
            txtNombreChofer.Margin = new Padding(3, 2, 3, 2);
            txtNombreChofer.Name = "txtNombreChofer";
            txtNombreChofer.Size = new Size(214, 22);
            txtNombreChofer.TabIndex = 34;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Prueba_Los_Pamperos_;
            pictureBox1.Location = new Point(109, 307);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // dataGridChoferes
            // 
            dataGridChoferes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridChoferes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridChoferes.Location = new Point(338, 41);
            dataGridChoferes.Name = "dataGridChoferes";
            dataGridChoferes.Size = new Size(897, 449);
            dataGridChoferes.TabIndex = 49;
            // 
            // Choferes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 227, 206);
            ClientSize = new Size(1238, 501);
            Controls.Add(dataGridChoferes);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(btnEliminarChofer);
            Controls.Add(btnEditarChofer);
            Controls.Add(btnAgregarChofer);
            Controls.Add(txtDocumento);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtAntiguedad);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLicencia);
            Controls.Add(label1);
            Controls.Add(txtNombreChofer);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Choferes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choferes";
            WindowState = FormWindowState.Maximized;
            Load += Choferes_Load;
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridChoferes).EndInit();
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
        private Label label7;
        private Button btnEliminarChofer;
        private Button btnEditarChofer;
        private Button btnAgregarChofer;
        private TextBox txtDocumento;
        private Label label4;
        private Label label5;
        private TextBox txtAntiguedad;
        private Label label6;
        private TextBox txtTelefono;
        private Label label3;
        private Label label2;
        private TextBox txtLicencia;
        private Label label1;
        private TextBox txtNombreChofer;
        private PictureBox pictureBox1;
        private DataGridView dataGridChoferes;
    }
}