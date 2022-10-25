using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppModelo.View.Windows.Cadastros
{
    
    public partial class frmNaturalidade : Form
    {
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmNaturalidade()
        {
            InitializeComponent();

            var listaDeNacionalidades = _naturalidadeController.ObterTodasNaturalidades();
            gvNaturalidades.DataSource = listaDeNacionalidades;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var salvou = _naturalidadeController.Cadastrar(txtDescricao.Text);
            if (salvou)
            {
                MessageBox.Show("Nacionalidade incluída com sucesso");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao salvar no banco de dados");

            }
        }

        private void txtDescricao_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
           //primeira regra nome < que 30 letras
            if (txtDescricao.Text.Length < 30)
            {
                errorProvider.SetError(txtDescricao, "Digite sua Naturalidade");
                return;
            }

            //verifica se digitou algum numero
            foreach (var letra in txtDescricao.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider
                        .SetError(txtDescricao, "Seu nome parece estar errado");
                    return;
                }
            }
            errorProvider.Clear();

        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (var letra in txtDescricao.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider
                        .SetError(txtDescricao, "Campo não pode conter Numerais e nem caracteres especiais!");
                    return;
                }
            }
        }
    }
}
