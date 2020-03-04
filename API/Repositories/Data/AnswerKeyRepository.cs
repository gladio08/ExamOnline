using API.Models;
using API.MyConnections;
using API.viewModel;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class AnswerKeyRepository : GeneralRepository<AnswerKey>
    {
        private readonly ConnectionString _connectionString;
        DynamicParameters param = new DynamicParameters();
        public AnswerKeyRepository(ConnectionString connectionString) : base(connectionString)
        {
            _connectionString = connectionString;
        }

        [HttpGet]
        public IEnumerable<AnswerKeyVM> AnswerKeys()
        {
            var query = "sp_retrieve_question";
            var result = _connectionString.Connections.Query<AnswerKeyVM>(query, commandType: CommandType.StoredProcedure);
            return result;
        }

        [HttpGet]
        public IEnumerable<AnswerKeyVM> GetAnswerKeys(int id)
        {
            var query = "sp_getbyid";
            param.Add("q_id", id);
            var result = _connectionString.Connections.Query<AnswerKeyVM>(query, param, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
