using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //crio a instancia controllador
            var cepController = new ViaCepController();

            // Recebo os dados do metodo obter para endereço
            var endereco = cepController.Obter(txtEnderecoCep.Text);

            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if(txtNome.Text.Length < 6) 
            {
                errorProvider.SetError(txtNome, "Digite seu nome completo");
                return;
            }
            
            foreach(var letra in txtNome.Text)
            {
                if(char.IsNumber(letra))
                {
                    errorProvider.SetError(txtNome, "Seu nome parece estar incorreto");
                    return ;
                }
            }
            errorProvider.Clear();
        }

        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf);
            
            if (cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF Invalido");
                return;
            }
            errorProvider.Clear();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var EmailEhValido = Validadores.EmailEValido(email);
            
            if (EmailEhValido is false)
            {
                errorProvider.SetError(txtEmail, "Email Invalido");
                return;
            }
            errorProvider.Clear();
        }

        private void txtDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            var dataNascimento = DateTime.Parse(txtDataNascimento.Text);
            
            if(dataNascimento < )
        }
    }
}
