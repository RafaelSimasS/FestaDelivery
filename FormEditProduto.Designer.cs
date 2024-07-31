namespace FestaDelivery
{
    partial class FormEditProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditProduto));
            LblCategoria = new Label();
            LblNome = new Label();
            LblDescricao = new Label();
            LblPrecoUni = new Label();
            LblQuantidade = new Label();
            TxtNome = new TextBox();
            TxtCategoria = new TextBox();
            TxtDescricao = new TextBox();
            TxtQuantidade = new TextBox();
            TxtPrecoUni = new TextBox();
            BtnSalvar = new Button();
            BtnExcluirProd = new Button();
            SuspendLayout();
            // 
            // LblCategoria
            // 
            LblCategoria.AutoSize = true;
            LblCategoria.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCategoria.Location = new Point(152, 113);
            LblCategoria.Name = "LblCategoria";
            LblCategoria.Size = new Size(122, 27);
            LblCategoria.TabIndex = 0;
            LblCategoria.Text = "Categoria:";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNome.Location = new Point(192, 48);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(82, 27);
            LblNome.TabIndex = 1;
            LblNome.Text = "Nome:";
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDescricao.Location = new Point(150, 185);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(124, 27);
            LblDescricao.TabIndex = 2;
            LblDescricao.Text = "Descrição:";
            // 
            // LblPrecoUni
            // 
            LblPrecoUni.AutoSize = true;
            LblPrecoUni.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPrecoUni.Location = new Point(96, 313);
            LblPrecoUni.Name = "LblPrecoUni";
            LblPrecoUni.Size = new Size(178, 27);
            LblPrecoUni.TabIndex = 3;
            LblPrecoUni.Text = "Preço Unidade:";
            // 
            // LblQuantidade
            // 
            LblQuantidade.AutoSize = true;
            LblQuantidade.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblQuantidade.Location = new Point(129, 252);
            LblQuantidade.Name = "LblQuantidade";
            LblQuantidade.Size = new Size(145, 27);
            LblQuantidade.TabIndex = 4;
            LblQuantidade.Text = "Quantidade:";
            // 
            // TxtNome
            // 
            TxtNome.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNome.Location = new Point(280, 45);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(277, 35);
            TxtNome.TabIndex = 5;
            // 
            // TxtCategoria
            // 
            TxtCategoria.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCategoria.Location = new Point(280, 110);
            TxtCategoria.Name = "TxtCategoria";
            TxtCategoria.Size = new Size(277, 35);
            TxtCategoria.TabIndex = 6;
            // 
            // TxtDescricao
            // 
            TxtDescricao.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDescricao.Location = new Point(280, 182);
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(277, 35);
            TxtDescricao.TabIndex = 7;
            // 
            // TxtQuantidade
            // 
            TxtQuantidade.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtQuantidade.Location = new Point(280, 249);
            TxtQuantidade.Name = "TxtQuantidade";
            TxtQuantidade.Size = new Size(277, 35);
            TxtQuantidade.TabIndex = 8;
            // 
            // TxtPrecoUni
            // 
            TxtPrecoUni.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPrecoUni.Location = new Point(280, 310);
            TxtPrecoUni.Name = "TxtPrecoUni";
            TxtPrecoUni.Size = new Size(277, 35);
            TxtPrecoUni.TabIndex = 9;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalvar.Location = new Point(280, 368);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(125, 36);
            BtnSalvar.TabIndex = 10;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnExcluirProd
            // 
            BtnExcluirProd.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnExcluirProd.Location = new Point(432, 368);
            BtnExcluirProd.Name = "BtnExcluirProd";
            BtnExcluirProd.Size = new Size(125, 36);
            BtnExcluirProd.TabIndex = 11;
            BtnExcluirProd.Text = "Excluir";
            BtnExcluirProd.UseVisualStyleBackColor = true;
            BtnExcluirProd.Click += BtnExcluirProd_Click;
            // 
            // FormEditProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnExcluirProd);
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
            Name = "FormEditProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Festa Delivery: Editar Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCategoria;
        private Label LblNome;
        private Label LblDescricao;
        private Label LblPrecoUni;
        private Label LblQuantidade;
        private TextBox TxtNome;
        private TextBox TxtCategoria;
        private TextBox TxtDescricao;
        private TextBox TxtQuantidade;
        private TextBox TxtPrecoUni;
        private Button BtnSalvar;
        private Button BtnExcluirProd;
    }
}