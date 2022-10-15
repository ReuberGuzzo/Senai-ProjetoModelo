using AppModelo.Model.Domain.Wrappers;
using AppModelo.Model.Infra.Services;
using System;

namespace AppModelo.Controller.External
{
    public class ViaCepController
    {
        //retorna a classe ViaCepWrapper
        public ViaCepWrapper Obter(String cep)
        {
            var service = new ViaCepService();

            var viaCep = service.ObterDaApi(cep);

            return viaCep;
        }

    }
}
