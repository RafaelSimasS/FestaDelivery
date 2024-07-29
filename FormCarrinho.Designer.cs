namespace FestaDelivery
{
    partial class FormCarrinho
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
            LstCarrinho = new ListView();
            menuStrip1 = new MenuStrip();
            fecharCarrinhoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LstCarrinho
            // 
            LstCarrinho.Dock = DockStyle.Fill;
            LstCarrinho.Location = new Point(0, 24);
            LstCarrinho.Name = "LstCarrinho";
            LstCarrinho.Size = new Size(800, 426);
            LstCarrinho.TabIndex = 0;
            LstCarrinho.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fecharCarrinhoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fecharCarrinhoToolStripMenuItem
            // 
            fecharCarrinhoToolStripMenuItem.Name = "fecharCarrinhoToolStripMenuItem";
            fecharCarrinhoToolStripMenuItem.Size = new Size(103, 20);
            fecharCarrinhoToolStripMenuItem.Text = "Fechar Carrinho";
            fecharCarrinhoToolStripMenuItem.Click += fecharCarrinhoToolStripMenuItem_Click;
            // 
            // FormCarrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LstCarrinho);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCarrinho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Festa Delivery: Carrinho";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView LstCarrinho;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fecharCarrinhoToolStripMenuItem;
    }
}