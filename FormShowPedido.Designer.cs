﻿namespace FestaDelivery
{
    partial class FormShowPedido
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
            LstItensPedido = new ListView();
            SuspendLayout();
            // 
            // LstItensPedido
            // 
            LstItensPedido.Dock = DockStyle.Fill;
            LstItensPedido.Location = new Point(0, 0);
            LstItensPedido.Name = "LstItensPedido";
            LstItensPedido.Size = new Size(800, 450);
            LstItensPedido.TabIndex = 0;
            LstItensPedido.UseCompatibleStateImageBehavior = false;
            // 
            // FormShowPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LstItensPedido);
            Name = "FormShowPedido";
            Text = "FormShowPedido";
            ResumeLayout(false);
        }

        #endregion

        private ListView LstItensPedido;
    }
}