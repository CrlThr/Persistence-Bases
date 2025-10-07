// using MongoDB.Driver;

// var client = new MongoClient("mongodb://localhost:27017");
// var database = client.GetDatabase("game");
// await database.CreateCollectionAsync("profiles");
// await database.CreateCollectionAsync("saves");

// var profiles = database.GetCollection<ProfileDoc>("profiles");

// var newProfile = new ProfileDoc
// {
//     Id = "0",
//     Username = "Coco"
// };

// await profiles.InsertOneAsync(newProfile);


// public class ProfileDoc
// {
//     [BsonId]
//     [BsonRepresentation(BsonType.ObjectId)]
//     public string Id { get; set; } = default!;
//     public string Username { get; set; } = default!;
//     public string PasswordHashB64 { get; set; } = default!;
//     public string SaltB64 { get; set; } = default!;
//     public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
// }


// // public class MongoManager
// // {

// //     public void ManageProfiles()
// //     {
// //         var keys = Builders<ProfileDoc>.IndexKeys.Ascending(p => p.Username);
// //         var options = new CreateIndexOptions { Unique = true, Name = "ux_username" };
// //         Profiles.Indexes.CreateOne(new CreateIndexModel<ProfileDoc>(keys, options));
// //     }

// //     public void ManageSaves()
// //     {
// //         var scoreKeys = Builders<SaveGameDoc>.IndexKeys
// //         .Descending(s => s.PlayerScore)
// //         .Descending(s => s.LastSavedUtc);
// //         Saves.Indexes.CreateOne(new CreateIndexModel<SaveGameDoc>(scoreKeys));

// //     }

// // }

