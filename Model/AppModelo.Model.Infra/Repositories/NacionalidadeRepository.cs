using AppModelo.Model.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    public class NacionalidadeRepository
    {
        //CRUD - Create - read - update - delete 
        public bool Inserir () 
        {

        }
        public bool Atualizar ()
        {

        }
        public bool Remover (){}
        public List<NacionalidadeEntity> ObterTodos()
        {
            var sql = "SELECT *From nacionalidades";
        }
        public NacionalidadeEntity ObterporId(){}
    }
}
