namespace FestaDelivery
{
    partial class FormAdicionarNoCarrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarNoCarrinho));
            LblNome = new Label();
            LblPreco = new Label();
            label1 = new Label();
            LblNomeProduto = new Label();
            LblPrecoProduto = new Label();
            LblQuant = new Label();
            LblQuantidadeDisponivel = new Label();
            BtnAdicionar = new Button();
            TxtQuantidade = new TextBox();
            LblQuantidadeSalv = new Label();
            SuspendLayout();
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNome.Location = new Point(212, 56);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(82, 27);
            LblNome.TabIndex = 1;
            LblNome.Text = "Nome:";
            // 
            // LblPreco
            // 
            LblPreco.AutoSize = true;
            LblPreco.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPreco.Location = new Point(124, 108);
            LblPreco.Name = "LblPreco";
            LblPreco.Size = new Size(170, 27);
            LblPreco.TabIndex = 2;
            LblPreco.Text = "Preço Unitário:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 112);
            label1.Name = "label1";
            label1.Size = new Size(0, 27);
            label1.TabIndex = 3;
            // 
            // LblNomeProduto
            // 
            LblNomeProduto.AutoSize = true;
            LblNomeProduto.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNomeProduto.Location = new Point(300, 56);
            LblNomeProduto.Name = "LblNomeProduto";
            LblNomeProduto.Size = new Size(20, 27);
            LblNomeProduto.TabIndex = 4;
            LblNomeProduto.Text = "-";
            // 
            // LblPrecoProduto
            // 
            LblPrecoProduto.AutoSize = true;
            LblPrecoProduto.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPrecoProduto.Location = new Point(300, 108);
            LblPrecoProduto.Name = "LblPrecoProduto";
            LblPrecoProduto.Size = new Size(20, 27);
            LblPrecoProduto.TabIndex = 5;
            LblPrecoProduto.Text = "-";
            // 
            // LblQuant
            // 
            LblQuant.AutoSize = true;
            LblQuant.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblQuant.Location = new Point(87, 159);
            LblQuant.Name = "LblQuant";
            LblQuant.Size = new Size(207, 27);
            LblQuant.TabIndex = 6;
            LblQuant.Text = "Quantidade Disp.:";
            // 
            // LblQuantidadeDisponivel
            // 
            LblQuantidadeDisponivel.AutoSize = true;
            LblQuantidadeDisponivel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblQuantidadeDisponivel.Location = new Point(300, 159);
            LblQuantidadeDisponivel.Name = "LblQuantidadeDisponivel";
            LblQuantidadeDisponivel.Size = new Size(20, 27);
            LblQuantidadeDisponivel.TabIndex = 7;
            LblQuantidadeDisponivel.Text = "-";
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAdicionar.Location = new Point(355, 265);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(138, 37);
            BtnAdicionar.TabIndex = 8;
            BtnAdicionar.Text = "Adicionar ao Carrinho";
            BtnAdicionar.UseVisualStyleBackColor = true;
            BtnAdicionar.Click += BtnAdicionar_Click;
            // 
            // TxtQuantidade
            // 
            TxtQuantidade.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtQuantidade.Location = new Point(300, 213);
            TxtQuantidade.MaxLength = 8;
            TxtQuantidade.Name = "TxtQuantidade";
            TxtQuantidade.Size = new Size(228, 35);
            TxtQuantidade.TabIndex = 9;
            // 
            // LblQuantidadeSalv
            // 
            LblQuantidadeSalv.AutoSize = true;
            LblQuantidadeSalv.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblQuantidadeSalv.Location = new Point(149, 216);
            LblQuantidadeSalv.Name = "LblQuantidadeSalv";
            LblQuantidadeSalv.Size = new Size(145, 27);
            LblQuantidadeSalv.TabIndex = 10;
            LblQuantidadeSalv.Text = "Quantidade:";
            // 
            // FormAdicionarNoCarrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblQuantidadeSalv);
            Controls.Add(TxtQuantidade);
            Controls.Add(BtnAdicionar);
            Controls.Add(LblQuantidadeDisponivel);
            Controls.Add(LblQuant);
            Controls.Add(LblPrecoProduto);
            Controls.Add(LblNomeProduto);
            Controls.Add(label1);
            Controls.Add(LblPreco);
            Controls.Add(LblNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormAdicionarNoCarrinho";
            Text = "Adicionar no Carrinho";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNome;
        private Label LblPreco;
        private Label label1;
        private Label LblNomeProduto;
        private Label LblPrecoProduto;
        private Label LblQuant;
        private Label LblQuantidadeDisponivel;
        private Button BtnAdicionar;
        private TextBox TxtQuantidade;
        private Label LblQuantidadeSalv;
    }
}