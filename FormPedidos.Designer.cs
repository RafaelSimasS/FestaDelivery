namespace FestaDelivery
{
    partial class FormPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            LstPedidos = new ListView();
            SuspendLayout();
            // 
            // LstPedidos
            // 
            LstPedidos.Dock = DockStyle.Fill;
            LstPedidos.Location = new Point(0, 0);
            LstPedidos.Name = "LstPedidos";
            LstPedidos.Size = new Size(800, 450);
            LstPedidos.TabIndex = 0;
            LstPedidos.UseCompatibleStateImageBehavior = false;
            LstPedidos.DoubleClick += LstPedidos_DoubleClick;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LstPedidos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Pedidos";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private ListView LstPedidos;
    }
}