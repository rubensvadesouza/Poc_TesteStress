using Dharma.Configurations;
using Dharma.Data.CassandraDB.Repositories;
using MemberStressTest.Model;

namespace MemberStressTest.Service
{
    public class JsonCassandraService : CassandraRepository<JsonCassandraModel>
    {
        public JsonCassandraService(CassandraOptions configuration)
            : base(configuration)
        {
        }
    }
}