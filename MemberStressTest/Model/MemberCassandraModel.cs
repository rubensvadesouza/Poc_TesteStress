using Dharma.Data.CassandraDB.Entities;
using System;

namespace MemberStressTest.Model
{
    public class MemberCassandraModel : CassandraEntityBase
    {
        public int Source { get; set; }
        public string Code { get; set; }
        public string RequestId { get; set; }
        public DateTime RequestDate { get; set; }
        public string FullName { get; set; }
        public long Age { get; set; }
        public string CellNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime Date { get; set; }
        public long Version { get; set; }
    }
}