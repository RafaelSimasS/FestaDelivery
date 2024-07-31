namespace FestaDelivery
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            menuHome = new MenuStrip();
            gerenciamentoToolStripMenuItem = new ToolStripMenuItem();
            catalogoDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuHome.SuspendLayout();
            SuspendLayout();
            // 
            // menuHome
            // 
            menuHome.Items.AddRange(new ToolStripItem[] { gerenciamentoToolStripMenuItem, sairToolStripMenuItem });
            menuHome.Location = new Point(0, 0);
            menuHome.Name = "menuHome";
            menuHome.Size = new Size(800, 24);
            menuHome.TabIndex = 1;
            menuHome.Text = "menuStrip1";
            // 
            // gerenciamentoToolStripMenuItem
            // 
            gerenciamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { catalogoDeProdutosToolStripMenuItem, pedidosToolStripMenuItem });
            gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            gerenciamentoToolStripMenuItem.Size = new Size(100, 20);
            gerenciamentoToolStripMenuItem.Text = "Gerenciamento";
            // 
            // catalogoDeProdutosToolStripMenuItem
            // 
            catalogoDeProdutosToolStripMenuItem.Name = "catalogoDeProdutosToolStripMenuItem";
            catalogoDeProdutosToolStripMenuItem.Size = new Size(189, 22);
            catalogoDeProdutosToolStripMenuItem.Text = "Catalogo de Produtos";
            catalogoDeProdutosToolStripMenuItem.Click += catalogoDeProdutosToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(189, 22);
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
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuHome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuHome;
            Name = "FormHome";
            Text = "Administração: Home";
            menuHome.ResumeLayout(false);
            menuHome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuHome;
        private ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private ToolStripMenuItem catalogoDeProdutosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
    }
}