﻿namespace FestaDelivery
{
    partial class FormCadastro
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
            TxtEmail = new TextBox();
            LblEmail = new Label();
            TxtSenha = new TextBox();
            LblSenha = new Label();
            TxtNome = new TextBox();
            LblNome = new Label();
            BtnCadastro = new Button();
            LblLogin = new Label();
            SuspendLayout();
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEmail.Location = new Point(309, 131);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(228, 35);
            TxtEmail.TabIndex = 5;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblEmail.Location = new Point(215, 134);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(79, 27);
            LblEmail.TabIndex = 4;
            LblEmail.Text = "Email:";
            // 
            // TxtSenha
            // 
            TxtSenha.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSenha.Location = new Point(309, 190);
            TxtSenha.MaxLength = 8;
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PasswordChar = '*';
            TxtSenha.Size = new Size(228, 35);
            TxtSenha.TabIndex = 7;
            // 
            // LblSenha
            // 
            LblSenha.AutoSize = true;
            LblSenha.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSenha.Location = new Point(205, 193);
            LblSenha.Name = "LblSenha";
            LblSenha.Size = new Size(89, 27);
            LblSenha.TabIndex = 6;
            LblSenha.Text = "Senha:";
            // 
            // TxtNome
            // 
            TxtNome.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNome.Location = new Point(309, 72);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(228, 35);
            TxtNome.TabIndex = 9;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNome.Location = new Point(215, 75);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(82, 27);
            LblNome.TabIndex = 8;
            LblNome.Text = "Nome:";
            // 
            // BtnCadastro
            // 
            BtnCadastro.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCadastro.Location = new Point(344, 267);
            BtnCadastro.Name = "BtnCadastro";
            BtnCadastro.Size = new Size(138, 37);
            BtnCadastro.TabIndex = 10;
            BtnCadastro.Text = "Cadastrar";
            BtnCadastro.UseVisualStyleBackColor = true;
            BtnCadastro.Click += BtnCadastro_Click;
            // 
            // LblLogin
            // 
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Arial", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            LblLogin.Location = new Point(717, 414);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(71, 27);
            LblLogin.TabIndex = 11;
            LblLogin.Text = "Login";
            LblLogin.Click += LblLogin_Click;
            LblLogin.MouseEnter += LblLogin_MouseEnter;
            LblLogin.MouseLeave += LblLogin_MouseLeave;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblLogin);
            Controls.Add(BtnCadastro);
            Controls.Add(TxtNome);
            Controls.Add(LblNome);
            Controls.Add(TxtSenha);
            Controls.Add(LblSenha);
            Controls.Add(TxtEmail);
            Controls.Add(LblEmail);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Festa Delivey: Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEmail;
        private Label LblEmail;
        private TextBox TxtSenha;
        private Label LblSenha;
        private TextBox TxtNome;
        private Label LblNome;
        private Button BtnCadastro;
        private Label LblLogin;
    }
}