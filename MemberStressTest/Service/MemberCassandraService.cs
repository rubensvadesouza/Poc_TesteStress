using Dharma.Configurations;
using Dharma.Data.CassandraDB.Repositories;
using MemberStressTest.Model;

namespace MemberStressTest.Service
{
    public class MemberCassandraService : CassandraRepository<MemberCassandraModel>
    {
        public MemberCassandraService(CassandraOptions configuration) 
            : base(configuration)
        {
        }
    }
}