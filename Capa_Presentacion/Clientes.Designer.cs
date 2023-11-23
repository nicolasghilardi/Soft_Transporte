namespace Capa_Presentacion
{
    partial class Clientes
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(100, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 26);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 92);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 3;
            label2.Text = "Teléfono:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(100, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(298, 26);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(61, 28);
            label3.Name = "label3";
            label3.Size = new Size(33, 21);
            label3.TabIndex = 4;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(452, 28);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 9;
            label4.Text = "Dirección:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(422, 94);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 8;
            label5.Text = "Observación:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(551, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(590, 26);
            textBox3.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(473, 62);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 6;
            label6.Text = "Correo:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(551, 62);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(590, 26);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(551, 28);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(590, 26);
            textBox5.TabIndex = 10;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 227, 206);
            ClientSize = new Size(1433, 666);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}