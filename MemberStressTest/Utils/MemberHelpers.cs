using MemberStressTest.Model;
using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MemberStressTest.Utils
{
    public static class MemberHelpers
    {
        public static List<MemberModel> GetRandomMongoMembers(int qtd)
        {
            var list = new List<MemberModel>();

            for (int i = 0; i < qtd; i++)
            {
                var date = DateTime.Now.AddMinutes(i);
                var id = ObjectId.GenerateNewId(DateTime.Now.AddMinutes(i)).ToString();

                var member = new MemberModel()
                {
                    ID = id,
                    Source = 0,
                    Code = "",
                    RequestId = id,
                    RequestDate = date,
                    FullName = $"Name_{id}",
                    Age = i,
                    CellNumber = $"Fone_{id}",
                    DateOfBirth = DateTime.Now.AddMinutes(-i),
                    Date = date,
                    Version = 1
                };

                list.Add(member);
            }

            return list;
        }

        public static List<JsonCassandraModel> GetRandomCassandraJsonMembers(int qtd)
        {
            var list = new List<JsonCassandraModel>();
            for (int i = 0; i < qtd; i++)
            {
                var date = DateTime.Now.AddMinutes(i);
                var id = ObjectId.GenerateNewId(DateTime.Now.AddMinutes(i)).ToString();

                var item = new JsonCassandraModel();

                var member = new MemberCassandraModel()
                {
                    Source = 0,
                    Code = "",
                    RequestId = id,
                    RequestDate = date,
                    FullName = $"Name_{id}",
                    Age = i,
                    CellNumber = $"Fone_{id}",
                    DateOfBirth = DateTime.Now.AddMinutes(-i),
                    Date = date,
                    Version = 1
                };

                item.Json = JsonConvert.SerializeObject(member);

                list.Add(item);
            }

            return list;
        }

        public static List<MemberCassandraModel> GetRandomCassandraMembers(int qtd)
        {
            var list = new List<MemberCassandraModel>();

            for (int i = 0; i < qtd; i++)
            {
                var date = DateTime.Now.AddMinutes(i);
                var id = ObjectId.GenerateNewId(DateTime.Now.AddMinutes(i)).ToString();

                var member = new MemberCassandraModel()
                {
                    Source = 0,
                    Code = "",
                    RequestId = id,
                    RequestDate = date,
                    FullName = $"Name_{id}",
                    Age = i,
                    CellNumber = $"Fone_{id}",
                    DateOfBirth = DateTime.Now.AddMinutes(-i),
                    Date = date,
                    Version = 1
                };

                list.Add(member);
            }

            return list;
        }

        public static List<MemberModel> GetMembers()
        {
            var list = new List<MemberModel>();

            var m1 = new MemberModel()
            {
                ID = "1",
                Source = 0,
                Code = "",
                RequestId = ObjectId.GenerateNewId().ToString(),
                RequestDate = DateTime.Now,
                FullName = "Joao da Silva Penha",
                Age = 25,
                CellNumber = "15997791860",
                DateOfBirth = DateTime.Now.AddYears(-25),
                Date = DateTime.Now,
                Version = 1
            };

            var m2 = new MemberModel()
            {
                ID = "2",
                Source = 0,
                Code = "",
                RequestId = ObjectId.GenerateNewId().ToString(),
                RequestDate = DateTime.Now,
                FullName = "Ricardo Alves Souza",
                Age = 25,
                CellNumber = "15997791860",
                DateOfBirth = DateTime.Now.AddYears(-25),
                Date = DateTime.Now,
                Version = 1
            };

            var m3 = new MemberModel()
            {
                ID = "3",
                Source = 0,
                Code = "",
                RequestId = ObjectId.GenerateNewId().ToString(),
                RequestDate = DateTime.Now,
                FullName = "Rubens Souza",
                Age = 25,
                CellNumber = "15997791860",
                DateOfBirth = DateTime.Now.AddYears(-25),
                Date = DateTime.Now,
                Version = 1
            };

            var m4 = new MemberModel()
            {
                ID = "4",
                Source = 0,
                Code = "",
                RequestId = ObjectId.GenerateNewId().ToString(),
                RequestDate = DateTime.Now,
                FullName = "Rubens Souza",
                Age = 25,
                CellNumber = "159874632",
                DateOfBirth = DateTime.Now.AddYears(-25),
                Date = DateTime.Now,
                Version = 1
            };

            var m5 = new MemberModel()
            {
                ID = "4",
                Source = 0,
                Code = "",
                RequestId = ObjectId.GenerateNewId().ToString(),
                RequestDate = DateTime.Now,
                FullName = "Rafael Sila Souza",
                Age = 25,
                CellNumber = "159874632",
                DateOfBirth = DateTime.Now.AddYears(-25),
                Date = DateTime.Now,
                Version = 1
            };

            list.Add(m1);
            list.Add(m2);
            list.Add(m3);
            list.Add(m4);
            list.Add(m5);

            return list;
        }
    }
}