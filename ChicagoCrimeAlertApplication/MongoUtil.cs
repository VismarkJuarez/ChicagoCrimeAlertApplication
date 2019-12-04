using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ChicagoCrimeAlertApplication
{
    class MongoUtil
    {
        private MongoUtil() { /* Hiding constructor.  This is a utility class. */}

        public static IMongoCollection<BsonDocument> retrieveCollection(String databaseName, String collectionName) {
            var mongoUsername = CredentialsFileReaderUtil.retrieveFromCredentialsFile("mongoUsername");
            var mongoPassword = CredentialsFileReaderUtil.retrieveFromCredentialsFile("mongoPassword");

            var client = new MongoClient("mongodb://" + mongoUsername + ":" + mongoPassword + "@cluster0-shard-00-00-xbyzl.mongodb.net:27017,cluster0-shard-00-01-xbyzl.mongodb.net:27017,cluster0-shard-00-02-xbyzl.mongodb.net:27017/test?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin&retryWrites=true&w=majority");
            var database = client.GetDatabase(databaseName);

            //get mongodb collection
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>(collectionName);

            return collection;

        }

    }
}
