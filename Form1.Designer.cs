﻿namespace FestaDelivery
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            gerenciamentoToolStripMenuItem = new ToolStripMenuItem();
            catálogoDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gerenciamentoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // gerenciamentoToolStripMenuItem
            // 
            gerenciamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { catálogoDeProdutosToolStripMenuItem });
            gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            gerenciamentoToolStripMenuItem.Size = new Size(100, 20);
            gerenciamentoToolStripMenuItem.Text = "Gerenciamento";
            // 
            // catálogoDeProdutosToolStripMenuItem
            // 
            catálogoDeProdutosToolStripMenuItem.Name = "catálogoDeProdutosToolStripMenuItem";
            catálogoDeProdutosToolStripMenuItem.Size = new Size(189, 22);
            catálogoDeProdutosToolStripMenuItem.Text = "Catálogo de Produtos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private ToolStripMenuItem catálogoDeProdutosToolStripMenuItem;
    }
}
