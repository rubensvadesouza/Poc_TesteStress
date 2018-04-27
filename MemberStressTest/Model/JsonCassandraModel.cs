using Dharma.Data.CassandraDB.Entities;
using System;

namespace MemberStressTest.Model
{
    public class JsonCassandraModel : CassandraEntityBase
    {
        public string Json { get; set; }
    }
}