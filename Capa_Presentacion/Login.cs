namespace Capa_Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.label1.Parent = this.pictureBox1;
            this.label1.BackColor = Color.Transparent;
            this.label2.Parent = this.pictureBox1;
            this.label2.BackColor = Color.Transparent;
            this.checkBox1.Parent = this.pictureBox1;
            this.checkBox1.BackColor = Color.Transparent;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Supervisor" || this.textBox2.Text == "Admin1234")
            {
                Menu menu1 = new Menu();
                menu1.Show();
                Hide();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (textBox2.PasswordChar == '*')
                {
                    textBox2.PasswordChar = '\0';
                }
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}