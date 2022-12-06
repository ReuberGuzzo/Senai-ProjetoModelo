using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    public class FuncionarioRepository
    {
        /// <summary>
        /// inseri as informações inseridas nos campos da tela no banco de dados para armazenamento.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="dataDeNascimento"></param>
        /// <param name="sexo"></param>
        /// <param name="cpf"></param>
        /// <param name="id_nacionalidade"></param>
        /// <param name="id_naturalidade"></param>
        /// <param name="email"></param>
        /// <param name="telefone"></param>
        /// <param name="telefone_contato"></param>
        /// <param name="cep"></param>
        /// <param name="logradouro"></param>
        /// <param name="numero"></param>
        /// <param name="complemento"></param>
        /// <param name="bairro"></param>
        /// <param name="municipio"></param>
        /// <param name="uf"></param>
        /// <returns>Retorna essas informações em forma de cadastro no programa</returns>
        public bool Inserir(string nome, DateTime dataDeNascimento, bool sexo, string cpf, int id_nacionalidade, int id_naturalidade, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf)
        {
            var sql = $"INSERT INTO funcionarios (nome, data_de_nascimento, sexo,cpf,id_nacionalidade, id_naturalidade, email, telefone, telefone_contato,cep,logradouro, numero, complemento, bairro, municipio, uf) VALUES ('{nome}', '{dataDeNascimento}',{sexo}, '{cpf}',{id_nacionalidade},{id_naturalidade}, '{email}', '{telefone}', '{telefone_contato}', '{cep}', '{logradouro}',{numero}, '{complemento}', '{bairro}','{municipio}', '{uf}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

        public IEnumerable<FuncionarioEntity> ObterTodos()
        {
            var sql = $"SELECT id, nome, data_de_nascimento, cpf, telefone, logradouro, numero, municipio, bairro FROM funcionarios";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<FuncionarioEntity>(sql);

            return resultado;
        }
    }
}
