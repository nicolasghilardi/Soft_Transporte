namespace Capa_Presentacion
{
    partial class Salir
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
            label1 = new Label();
            btnSi = new Button();
            btnNo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(139, 37);
            label1.Name = "label1";
            label1.Size = new Size(293, 27);
            label1.TabIndex = 0;
            label1.Text = "Seguro que quieres Salir?";
            // 
            // btnSi
            // 
            btnSi.BackColor = Color.FromArgb(236, 227, 206);
            btnSi.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSi.ForeColor = Color.Black;
            btnSi.Location = new Point(34, 116);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(179, 46);
            btnSi.TabIndex = 1;
            btnSi.Text = "SI";
            btnSi.UseVisualStyleBackColor = false;
            btnSi.Click += btnSi_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.FromArgb(236, 227, 206);
            btnNo.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNo.ForeColor = Color.Black;
            btnNo.Location = new Point(370, 116);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(179, 46);
            btnNo.TabIndex = 2;
            btnNo.Text = "NO";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // Salir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(79, 111, 82);
            ClientSize = new Size(597, 220);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Salir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSi;
        private Button btnNo;
    }
}