﻿using AppModelo.Model.Domain.Entities;
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
    public class NaturalidadeRepository
    {
        //CRUD - create - read   - update - delete
        //       insert - select - update - delete  
        public bool Inserir(string descricao)
        {
            //string interpolation
            var sql = $"INSERT INTO naturalidade (descricao) VALUES ('{descricao}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public bool Atualizar()
        {
            return false;
        }
        public bool Remover()
        {
            return false;
        }
        public IEnumerable<NaturalidadeEntity> ObterTodos()
        {
            var sql = "SELECT id, descricao FROM naturalidade ORDER BY descricao DESC";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;
        }
        public NaturalidadeEntity ObterPorId()
        {
            return new NaturalidadeEntity();
        }
    }
}
