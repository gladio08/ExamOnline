using API.Models;
using API.MyConnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class AnswerRepository : GeneralRepository<Answer>
    {
        public AnswerRepository(ConnectionString connectionString) : base(connectionString)
        {

        }
    }
}
