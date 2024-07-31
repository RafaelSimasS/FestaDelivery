namespace FestaDelivery
{
    partial class FormHomeCliente
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
            menuStrip1 = new MenuStrip();
            exibirToolStripMenuItem = new ToolStripMenuItem();
            catálogoDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            gerenciarToolStripMenuItem = new ToolStripMenuItem();
            carrinhoToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { exibirToolStripMenuItem, gerenciarToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            exibirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { catálogoDeProdutosToolStripMenuItem });
            exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            exibirToolStripMenuItem.Size = new Size(48, 20);
            exibirToolStripMenuItem.Text = "Exibir";
            // 
            // catálogoDeProdutosToolStripMenuItem
            // 
            catálogoDeProdutosToolStripMenuItem.Name = "catálogoDeProdutosToolStripMenuItem";
            catálogoDeProdutosToolStripMenuItem.Size = new Size(189, 22);
            catálogoDeProdutosToolStripMenuItem.Text = "Catálogo de Produtos";
            catálogoDeProdutosToolStripMenuItem.Click += catálogoDeProdutosToolStripMenuItem_Click;
            // 
            // gerenciarToolStripMenuItem
            // 
            gerenciarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { carrinhoToolStripMenuItem, pedidosToolStripMenuItem });
            gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            gerenciarToolStripMenuItem.Size = new Size(69, 20);
            gerenciarToolStripMenuItem.Text = "Gerenciar";
            // 
            // carrinhoToolStripMenuItem
            // 
            carrinhoToolStripMenuItem.Name = "carrinhoToolStripMenuItem";
            carrinhoToolStripMenuItem.Size = new Size(120, 22);
            carrinhoToolStripMenuItem.Text = "Carrinho";
            carrinhoToolStripMenuItem.Click += carrinhoToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(120, 22);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // FormHomeCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormHomeCliente";
            Text = "Festa Delivery: Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem exibirToolStripMenuItem;
        private ToolStripMenuItem catálogoDeProdutosToolStripMenuItem;
        private ToolStripMenuItem gerenciarToolStripMenuItem;
        private ToolStripMenuItem carrinhoToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}