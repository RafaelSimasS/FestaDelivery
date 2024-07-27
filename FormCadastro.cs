using FestaDelivery.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestaDelivery
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            string nome = TxtNome.Text;
            string email = TxtEmail.Text;
            string senha = TxtSenha.Text;

            // Verifica se os campos não estão vazios
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se o email já existe na lista de usuários
            if (Program.Users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("O email informado já está em uso. Por favor, escolha outro email.", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gera o próximo ID disponível
            int novoId = Program.Users.Any() ? Program.Users.Max(u => u.Id) + 1 : 1;

            User novoCliente = new User(novoId, nome, "Cliente", email, senha);

            // Adiciona o novo cliente à lista de usuários
            Program.Users.Add(novoCliente);

            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpa os campos de texto
            TxtNome.Clear();
            TxtEmail.Clear();
            TxtSenha.Clear();
        }

        private void LblLogin_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void LblLogin_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void LblLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
