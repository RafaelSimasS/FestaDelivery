namespace FestaDelivery
{
    partial class FormAdicionarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarProduto));
            BtnSalvar = new Button();
            TxtPrecoUni = new TextBox();
            TxtQuantidade = new TextBox();
            TxtDescricao = new TextBox();
            TxtCategoria = new TextBox();
            TxtNome = new TextBox();
            LblQuantidade = new Label();
            LblPrecoUni = new Label();
            LblDescricao = new Label();
            LblNome = new Label();
            LblCategoria = new Label();
            SuspendLayout();
            // 
            // BtnSalvar
            // 
            BtnSalvar.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalvar.Location = new Point(365, 366);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(125, 36);
            BtnSalvar.TabIndex = 21;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // TxtPrecoUni
            // 
            TxtPrecoUni.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPrecoUni.Location = new Point(298, 306);
            TxtPrecoUni.Name = "TxtPrecoUni";
            TxtPrecoUni.Size = new Size(277, 35);
            TxtPrecoUni.TabIndex = 20;
            // 
            // TxtQuantidade
            // 
            TxtQuantidade.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtQuantidade.Location = new Point(298, 245);
            TxtQuantidade.Name = "TxtQuantidade";
            TxtQuantidade.Size = new Size(277, 35);
            TxtQuantidade.TabIndex = 19;
            // 
            // TxtDescricao
            // 
            TxtDescricao.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDescricao.Location = new Point(298, 178);
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(277, 35);
            TxtDescricao.TabIndex = 18;
            // 
            // TxtCategoria
            // 
            TxtCategoria.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCategoria.Location = new Point(298, 106);
            TxtCategoria.Name = "TxtCategoria";
            TxtCategoria.Size = new Size(277, 35);
            TxtCategoria.TabIndex = 17;
            // 
            // TxtNome
            // 
            TxtNome.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNome.Location = new Point(298, 41);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(277, 35);
            TxtNome.TabIndex = 16;
            // 
            // LblQuantidade
            // 
            LblQuantidade.AutoSize = true;
            LblQuantidade.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblQuantidade.Location = new Point(147, 248);
            LblQuantidade.Name = "LblQuantidade";
            LblQuantidade.Size = new Size(145, 27);
            LblQuantidade.TabIndex = 15;
            LblQuantidade.Text = "Quantidade:";
            // 
            // LblPrecoUni
            // 
            LblPrecoUni.AutoSize = true;
            LblPrecoUni.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPrecoUni.Location = new Point(114, 309);
            LblPrecoUni.Name = "LblPrecoUni";
            LblPrecoUni.Size = new Size(178, 27);
            LblPrecoUni.TabIndex = 14;
            LblPrecoUni.Text = "Preço Unidade:";
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDescricao.Location = new Point(168, 181);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(124, 27);
            LblDescricao.TabIndex = 13;
            LblDescricao.Text = "Descrição:";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNome.Location = new Point(210, 44);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(82, 27);
            LblNome.TabIndex = 12;
            LblNome.Text = "Nome:";
            // 
            // LblCategoria
            // 
            LblCategoria.AutoSize = true;
            LblCategoria.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCategoria.Location = new Point(170, 109);
            LblCategoria.Name = "LblCategoria";
            LblCategoria.Size = new Size(122, 27);
            LblCategoria.TabIndex = 11;
            LblCategoria.Text = "Categoria:";
            // 
            // FormAdicionarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSalvar);
            Controls.Add(TxtPrecoUni);
            Controls.Add(TxtQuantidade);
            Controls.Add(TxtDescricao);
            Controls.Add(TxtCategoria);
            Controls.Add(TxtNome);
            Controls.Add(LblQuantidade);
            Controls.Add(LblPrecoUni);
            Controls.Add(LblDescricao);
            Controls.Add(LblNome);
            Controls.Add(LblCategoria);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdicionarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Festa Delivery: Adicionar Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalvar;
        private TextBox TxtPrecoUni;
        private TextBox TxtQuantidade;
        private TextBox TxtDescricao;
        private TextBox TxtCategoria;
        private TextBox TxtNome;
        private Label LblQuantidade;
        private Label LblPrecoUni;
        private Label LblDescricao;
        private Label LblNome;
        private Label LblCategoria;
    }
}