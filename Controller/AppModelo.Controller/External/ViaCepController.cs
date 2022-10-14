using AppModelo.Model.Domain.Wrappers;
using System;

namespace AppModelo.Controller.External
{
    public class ViaCepController
    {
        //retorna a classe ViaCepWrapper
        public ViaCepWrapper Obter(String cep)
        {
            var viaCep = new ViaCepWrapper();

            // fake consulta
            viaCep.Bairro = "Aviso";
            viaCep.Logradouro = "Filogonio Peixoto";
            viaCep.Localidade = "Linhares";

            return viaCep;
        }

    }
}
