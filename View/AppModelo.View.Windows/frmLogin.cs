using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var Email = txtEmail.Text;
            var emailEhValido = Validadores.EmailEValido(Email);
            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "CPF Inválido");
                return;
            }
            errorProvider1.Clear();

            var form = new frmPrincipal();
            form.Show();
            this.Hide();
        }

        private void txtEsqueciSenha_Click(object sender, EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.ShowDialog();
            
        }

        public void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
