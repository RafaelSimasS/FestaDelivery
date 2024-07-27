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
    public partial class FormEditPedido : Form
    {
        private Pedido _pedido;
        public FormEditPedido(Pedido pedido)
        {
            InitializeComponent();
            _pedido = pedido;
            CmbStatus.SelectedItem = _pedido.Status;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Atualizar o status do pedido
            string status = CmbStatus.SelectedItem.ToString();

            if(_pedido.Status == "Entregue")
            {
                MessageBox.Show("Não é possível alterar o status pois o pedido já foi marcado como entregue.");
                return;
            }
            if (status == null)
            {
                MessageBox.Show("Selecione um status válido.");
                return;
            }

            _pedido.Status = status;

            // Definir o resultado do diálogo como OK e fechar o formulário
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
