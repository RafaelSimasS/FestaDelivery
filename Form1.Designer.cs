namespace FestaDelivery
{
    partial class FormLogin
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
            LblEmail = new Label();
            LblSenha = new Label();
            TxtSenha = new TextBox();
            TxtEmail = new TextBox();
            BtnLogin = new Button();
            LblCadastro = new Label();
            SuspendLayout();
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblEmail.Location = new Point(216, 145);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(79, 27);
            LblEmail.TabIndex = 0;
            LblEmail.Text = "Email:";
            // 
            // LblSenha
            // 
            LblSenha.AutoSize = true;
            LblSenha.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSenha.Location = new Point(206, 202);
            LblSenha.Name = "LblSenha";
            LblSenha.Size = new Size(89, 27);
            LblSenha.TabIndex = 1;
            LblSenha.Text = "Senha:";
            // 
            // TxtSenha
            // 
            TxtSenha.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSenha.Location = new Point(310, 199);
            TxtSenha.MaxLength = 8;
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PasswordChar = '*';
            TxtSenha.Size = new Size(228, 35);
            TxtSenha.TabIndex = 2;
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEmail.Location = new Point(310, 142);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(228, 35);
            TxtEmail.TabIndex = 3;
            // 
            // BtnLogin
            // 
            BtnLogin.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLogin.Location = new Point(350, 262);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(138, 37);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Entrar";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // LblCadastro
            // 
            LblCadastro.AutoSize = true;
            LblCadastro.Font = new Font("Arial", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            LblCadastro.Location = new Point(638, 414);
            LblCadastro.Name = "LblCadastro";
            LblCadastro.Size = new Size(150, 27);
            LblCadastro.TabIndex = 5;
            LblCadastro.Text = "Cadastrar-se";
            LblCadastro.Click += LblCadastro_Click;
            LblCadastro.MouseEnter += LblCadastro_MouseEnter;
            LblCadastro.MouseLeave += LblCadastro_MouseLeave;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblCadastro);
            Controls.Add(BtnLogin);
            Controls.Add(TxtEmail);
            Controls.Add(TxtSenha);
            Controls.Add(LblSenha);
            Controls.Add(LblEmail);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Festa Delivery: Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblEmail;
        private Label LblSenha;
        private TextBox TxtSenha;
        private TextBox TxtEmail;
        private Button BtnLogin;
        private Label LblCadastro;
    }
}
