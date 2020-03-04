using API.Models;
using API.MyConnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class BootcampRepository : GeneralRepository<Bootcamp>
    {
        public BootcampRepository(ConnectionString connectionString) : base(connectionString)
        {

        }
    }
}
