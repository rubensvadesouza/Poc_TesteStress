namespace MemberStressTest.Service
{
    using MemberStressTest.Model;
    using MongoDB.Driver;
    using System.Collections.Generic;
    using System.Linq;

    namespace MemberProducerSync.MemberService
    {
        public class MemberMongoService
        {
            private MongoClient _client => new MongoClient("mongodb://localhost:27017");

            public async void InsertMember(MemberModel model)
            {
                IMongoDatabase db = _client.GetDatabase("Member");
                var collection = db.GetCollection<MemberModel>("Members");

                await collection.InsertOneAsync(model);

                //var member = Find(model.ID);

                //if (member != null)
                //{
                //    await collection.ReplaceOneAsync(x => x.ID == member.ID, member);
                //}
                //else
                //{
                //    await collection.InsertOneAsync(model);
                //}
            }

            public List<MemberModel> List()
            {
                IMongoDatabase db = _client.GetDatabase("Member");
                var collection = db.GetCollection<MemberModel>("Members");
                return collection.FindAsync(x => true).Result.ToList();
            }

            public MemberModel Find(string id)
            {
                IMongoDatabase db = _client.GetDatabase("Member");
                var collection = db.GetCollection<MemberModel>("Members");
                return collection.Find(x => x.ID == id).FirstOrDefault();
            }
        }
    }
}