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
    }
}