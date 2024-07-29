namespace FestaDelivery
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = TxtEmail.Text;
            string senha = TxtSenha.Text;

            var user = Program.Users.FirstOrDefault(u => u.Email == email && u.Senha == senha);

            if (user != null)
            {
                Program.currentUser = user;
                this.Hide();
                if (user.Tipo == "Cliente")
                {
                    FormHomeCliente formHomeCliente = new FormHomeCliente();
                    formHomeCliente.FormClosed += (s, args) => this.Show();
                    formHomeCliente.Show();
                }
                else
                {
                    FormHome formHome = new FormHome();
                    formHome.FormClosed += (s, args) => this.Show();
                    formHome.Show();

                }
            }
            else
            {
                MessageBox.Show("Credenciais inválidas. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LblCadastro_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void LblCadastro_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void LblCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.FormClosed += (s, args) => this.Show();
            formCadastro.Show();
        }
    }
}
