using API.Model;
using API.MyConnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class RoleRepository : GeneralRepository<Role>
    {
        public RoleRepository(ConnectionString connectionString) : base(connectionString) { }
    }
}
