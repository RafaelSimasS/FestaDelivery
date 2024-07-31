namespace FestaDelivery
{
    partial class FormCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatalogo));
            LstCatalogo = new ListView();
            menuCatalogo = new MenuStrip();
            adicionarProdutoToolStripMenuItem = new ToolStripMenuItem();
            menuCatalogo.SuspendLayout();
            SuspendLayout();
            // 
            // LstCatalogo
            // 
            LstCatalogo.Dock = DockStyle.Fill;
            LstCatalogo.Location = new Point(0, 24);
            LstCatalogo.Name = "LstCatalogo";
            LstCatalogo.Size = new Size(800, 426);
            LstCatalogo.TabIndex = 0;
            LstCatalogo.UseCompatibleStateImageBehavior = false;
            LstCatalogo.DoubleClick += LstCatalogo_DoubleClick;
            // 
            // menuCatalogo
            // 
            menuCatalogo.Items.AddRange(new ToolStripItem[] { adicionarProdutoToolStripMenuItem });
            menuCatalogo.Location = new Point(0, 0);
            menuCatalogo.Name = "menuCatalogo";
            menuCatalogo.Size = new Size(800, 24);
            menuCatalogo.TabIndex = 1;
            menuCatalogo.Text = "menuStrip1";
            // 
            // adicionarProdutoToolStripMenuItem
            // 
            adicionarProdutoToolStripMenuItem.Name = "adicionarProdutoToolStripMenuItem";
            adicionarProdutoToolStripMenuItem.Size = new Size(116, 20);
            adicionarProdutoToolStripMenuItem.Text = "Adicionar Produto";
            adicionarProdutoToolStripMenuItem.Click += adicionarProdutoToolStripMenuItem_Click;
            // 
            // FormCatalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LstCatalogo);
            Controls.Add(menuCatalogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuCatalogo;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCatalogo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Catálogo de Produtos";
            WindowState = FormWindowState.Maximized;
            menuCatalogo.ResumeLayout(false);
            menuCatalogo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView LstCatalogo;
        private MenuStrip menuCatalogo;
        private ToolStripMenuItem adicionarProdutoToolStripMenuItem;
    }
}