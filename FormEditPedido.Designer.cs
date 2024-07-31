namespace FestaDelivery
{
    partial class FormEditPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditPedido));
            BtnSalvar = new Button();
            CmbStatus = new ComboBox();
            LblStatus = new Label();
            SuspendLayout();
            // 
            // BtnSalvar
            // 
            BtnSalvar.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalvar.Location = new Point(239, 168);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(125, 36);
            BtnSalvar.TabIndex = 11;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // CmbStatus
            // 
            CmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbStatus.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbStatus.FormattingEnabled = true;
            CmbStatus.Items.AddRange(new object[] { "Pendente", "Fazendo", "Em Entrega", "Entregue", "Cancelado" });
            CmbStatus.Location = new Point(196, 102);
            CmbStatus.Name = "CmbStatus";
            CmbStatus.Size = new Size(231, 35);
            CmbStatus.TabIndex = 12;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblStatus.Location = new Point(86, 105);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(88, 27);
            LblStatus.TabIndex = 13;
            LblStatus.Text = "Status:";
            // 
            // FormEditPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 264);
            Controls.Add(LblStatus);
            Controls.Add(CmbStatus);
            Controls.Add(BtnSalvar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Festa Delivery: Editar Pedido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalvar;
        private ComboBox CmbStatus;
        private Label LblStatus;
    }
}