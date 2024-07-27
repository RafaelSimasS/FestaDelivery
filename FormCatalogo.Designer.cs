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
            LstCatalogo = new ListView();
            SuspendLayout();
            // 
            // LstCatalogo
            // 
            LstCatalogo.Dock = DockStyle.Fill;
            LstCatalogo.Location = new Point(0, 0);
            LstCatalogo.Name = "LstCatalogo";
            LstCatalogo.Size = new Size(800, 450);
            LstCatalogo.TabIndex = 0;
            LstCatalogo.UseCompatibleStateImageBehavior = false;
            // 
            // FormCatalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LstCatalogo);
            MinimizeBox = false;
            Name = "FormCatalogo";
            Text = "Catálogo de Produtos";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private ListView LstCatalogo;
    }
}