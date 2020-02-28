using API.Models;
using API.MyConnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class QuestionRepository : GeneralRepository<Question>
    {
        public QuestionRepository(ConnectionString connectionString) : base(connectionString)
        {

        }
    }
}
