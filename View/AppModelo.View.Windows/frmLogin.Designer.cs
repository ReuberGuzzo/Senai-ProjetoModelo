﻿namespace AppModelo.View.Windows
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEsqueciSenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblSuporteContato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 35);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(12, 96);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(210, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // txtEsqueciSenha
            // 
            this.txtEsqueciSenha.AutoSize = true;
            this.txtEsqueciSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEsqueciSenha.Location = new System.Drawing.Point(114, 121);
            this.txtEsqueciSenha.Name = "txtEsqueciSenha";
            this.txtEsqueciSenha.Size = new System.Drawing.Size(108, 13);
            this.txtEsqueciSenha.TabIndex = 4;
            this.txtEsqueciSenha.Text = "Esqueci minha senha";
            this.txtEsqueciSenha.Click += new System.EventHandler(this.txtEsqueciSenha_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEntrar.Location = new System.Drawing.Point(64, 167);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(110, 34);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblSuporteContato
            // 
            this.lblSuporteContato.AutoSize = true;
            this.lblSuporteContato.Location = new System.Drawing.Point(72, 223);
            this.lblSuporteContato.Name = "lblSuporteContato";
            this.lblSuporteContato.Size = new System.Drawing.Size(93, 13);
            this.lblSuporteContato.TabIndex = 6;
            this.lblSuporteContato.Text = "Suporte e Contato";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 235);
            this.Controls.Add(this.lblSuporteContato);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtEsqueciSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label txtEsqueciSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblSuporteContato;
    }
}