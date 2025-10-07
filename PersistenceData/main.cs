// using System;
// using System.IO;
// using System.Text.Json;

// public class Programme
// {
//     public static void Main()
//     {
//         Saves saves = new Saves();

//         // Load player or create new
//         Player player;
//         string folder = "Saves";
//         string filePath = Path.Combine(folder, "Saves.json");

//         //Console.Write("Hash Password : ");
//         //string pwd = Console.ReadLine() ?? "";
//         // var (hash, salt) = PasswordService.HashPassword(pwd);
//         // Console.WriteLine($"Hash : {hash}");
//         // Console.WriteLine($"Salt : {salt}");

//         // Console.Write("\n Verificaton Test - Retype the password: ");
//         // string input = Console.ReadLine() ?? "";

//         // bool ok = PasswordService.VerifyPassword(input, hash, salt);
//         // Console.WriteLine(ok ? "Correct password" : "Incorrect password");


//         if (File.Exists(filePath))
//         {
//             string content = File.ReadAllText(filePath);
//             player = JsonSerializer.Deserialize<Player>(content) ?? new Player { Name = "Coralie", Level = 1, Score = 0 };
//             Console.WriteLine($"Game loaded for {player.Name}");
//         }
//         else
//         {
//             player = new Player { Name = "Coralie", Level = 1, Score = 0 };
//             saves.Save(player);
//             Console.WriteLine("New saved game created");
//         }


//         Game game = new Game(player, saves);
//         game.Run();

     
//     }
// }
