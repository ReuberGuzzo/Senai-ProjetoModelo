namespace AppModelo.View.Windows
{
    partial class frmRecuperarSenha
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
            this.lblRecuperarSenha = new System.Windows.Forms.Label();
            this.txtEmailRecuperarSenha = new System.Windows.Forms.TextBox();
            this.btnRecuperarAcesso = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecuperarSenha
            // 
            this.lblRecuperarSenha.AutoSize = true;
            this.lblRecuperarSenha.Location = new System.Drawing.Point(46, 26);
            this.lblRecuperarSenha.Name = "lblRecuperarSenha";
            this.lblRecuperarSenha.Size = new System.Drawing.Size(91, 13);
            this.lblRecuperarSenha.TabIndex = 0;
            this.lblRecuperarSenha.Text = "Recuperar Senha";
            // 
            // txtEmailRecuperarSenha
            // 
            this.txtEmailRecuperarSenha.Location = new System.Drawing.Point(13, 52);
            this.txtEmailRecuperarSenha.Name = "txtEmailRecuperarSenha";
            this.txtEmailRecuperarSenha.Size = new System.Drawing.Size(180, 20);
            this.txtEmailRecuperarSenha.TabIndex = 1;
            // 
            // btnRecuperarAcesso
            // 
            this.btnRecuperarAcesso.Location = new System.Drawing.Point(38, 79);
            this.btnRecuperarAcesso.Name = "btnRecuperarAcesso";
            this.btnRecuperarAcesso.Size = new System.Drawing.Size(124, 23);
            this.btnRecuperarAcesso.TabIndex = 2;
            this.btnRecuperarAcesso.Text = "Recuperar Acesso";
            this.btnRecuperarAcesso.UseVisualStyleBackColor = true;
            this.btnRecuperarAcesso.Click += new System.EventHandler(this.btnRecuperarAcesso_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(38, 109);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 173);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRecuperarAcesso);
            this.Controls.Add(this.txtEmailRecuperarSenha);
            this.Controls.Add(this.lblRecuperarSenha);
            this.Name = "frmRecuperarSenha";
            this.Text = "frmRecuperarSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecuperarSenha;
        private System.Windows.Forms.TextBox txtEmailRecuperarSenha;
        private System.Windows.Forms.Button btnRecuperarAcesso;
        private System.Windows.Forms.Button btnCancelar;
    }
}