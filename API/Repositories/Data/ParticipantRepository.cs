using API.Models;
using API.MyConnections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class ParticipantRepository : GeneralRepository<Participant>
    {
        public ParticipantRepository(ConnectionString connectionString) : base(connectionString)
        {

        }
    }
}
