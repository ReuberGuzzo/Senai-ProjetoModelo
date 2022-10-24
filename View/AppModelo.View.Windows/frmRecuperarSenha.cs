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
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecuperarAcesso_Click(object sender, EventArgs e)
        {
            var form = new frmPrincipal();
            form.Show();
            this.Close();
        }
    }
}
