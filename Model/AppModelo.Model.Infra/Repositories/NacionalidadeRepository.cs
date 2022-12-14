using AppModelo.Model.Domain.Entities;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System;

namespace AppModelo.Model.Infra.Repositories
{
    public class NacionalidadeRepository
    {   
        //CRUD - create - read   - update - delete
        //       insert - select - update - delete  
        public bool Inserir(string descricao, bool ativo)
        {
            //string interpolation
            var sql = $"INSERT INTO nacionalidade (descricao) VALUES ('{descricao}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        /// <summary>
        /// Busca no banco de dados as informações e atualiza as mesmas sobrepondo o que ja esta salvo
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Atualizar(string descricao, int id) 
        {
            //string interpolation
            var sql = $"UPDATE nacionalidade SET descricao = '{descricao}'  WHERE id = '{id}'";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        /// <summary>
        /// Vai no banco de dados e remove informações que estão salvas
        /// </summary>
        /// <param name="id"></param>
        /// <returns>retorna na variavel resultado os dados apagados</returns>
        public bool Remover(int id, string descricao) 
        {
            //string interpolation
            var sql = $"DELETE FROM nacionalidade  WHERE id  = '{id}' AND DESCRICAO = '{descricao}'" ;
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public IEnumerable<NacionalidadeEntity> ObterTodos()
        {
            var sql = "SELECT id, descricao FROM nacionalidade";
            
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            
            var resultado = conexaoBd.Query<NacionalidadeEntity>(sql);

            return resultado;
        }
        public NacionalidadeEntity ObterPorId() 
        {
            return new NacionalidadeEntity();
        }

        public object ObterPorDescricao(string descricao)
        {
            throw new NotImplementedException();
        }
    }
}
