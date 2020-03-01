using API.Models;
using API.MyConnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class AnswerKeyRepository : GeneralRepository<AnswerKey>
    {
        public AnswerKeyRepository(ConnectionString connectionString) : base(connectionString)
        {

        }
    }
}
