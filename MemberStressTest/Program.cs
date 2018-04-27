using Dharma.Configurations;
using MemberStressTest.Service;
using MemberStressTest.Service.MemberProducerSync.MemberService;
using MemberStressTest.Utils;
using System;

namespace MemberStressTest
{
    internal class MemberProducerStressTest
    {
        private static MemberMongoService mongoService = new MemberMongoService();

        private static void Main(string[] args)
        {
            MongoRead();
        }

        #region Insert

        private static void MongoInsert()
        {
            var members = MemberHelpers.GetRandomMongoMembers(100000);

            var time = System.Diagnostics.Stopwatch.StartNew();

            foreach (var member in members)
            {
                mongoService.InsertMember(member);
            }

            time.Stop();
            Console.WriteLine($"Tempo de Execução do Insert:{time.ElapsedMilliseconds}");
        }

        private static void CassandraInsert()
        {
            var config = new CassandraOptions();
            config.Url = "localhost";
            config.DatabaseName = "MembersStore";

            var service = new JsonCassandraService(config);

            service.CreateTable();

            var members = MemberHelpers.GetRandomCassandraJsonMembers(100000);

            var time = System.Diagnostics.Stopwatch.StartNew();

            foreach (var member in members)
            {
                service.CreateAsync(member);
            }

            time.Stop();
            Console.WriteLine($"Tempo de Execução do Insert:{time.ElapsedMilliseconds}");
        }

        #endregion Insert

        #region Read

        private static void CassandraRead()
        {
            var config = new CassandraOptions();
            config.Url = "localhost";
            config.DatabaseName = "MembersStore";

            var service = new JsonCassandraService(config);

            var time = System.Diagnostics.Stopwatch.StartNew();

            var data = DateTime.Now.AddDays(-5);
            var lista = service.Read(x => x.Created > data);

            time.Stop();
            Console.WriteLine($"Tempo de Execução do Read:{time.ElapsedMilliseconds}");
        }

        private static void MongoRead()
        {
            var time = System.Diagnostics.Stopwatch.StartNew();

            var list = mongoService.List();

            time.Stop();
            Console.WriteLine($"Tempo de Execução do Read:{time.ElapsedMilliseconds}");
        }

        #endregion Read
    }
}