using AppModelo.Controller.Cadastros;
using AppModelo.View.Windows.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmPrincipal : Form
    {
        private FuncionarioController _funcionarioController = new FuncionarioController();
        public frmPrincipal()
        {
            InitializeComponent();

            var listaFuncionarios = _funcionarioController.ObterTodosFuncionarios();
            dgvListarFuncionarios.DataSource = listaFuncionarios;

        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.Show();
        }

        private void nacionalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.Show();
        }

        private void naturalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.Show();
        }

        public void dgvListarFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ListaFuncionarios = _funcionarioController.ObterTodosFuncionarios();
            dgvListarFuncionarios.DataSource = ListaFuncionarios;
                                   
        }
    }
}
