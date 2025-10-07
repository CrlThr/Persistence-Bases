using System;
using System.IO;
using System.Text.Json;

public class Saves
{
    private readonly string folder = "Saves";
    private readonly string fileName = "Saves.json";

    public void LoadOrCreate()
    {
        Directory.CreateDirectory(folder);

        string filePath = Path.Combine(folder, fileName);

        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            var player = JsonSerializer.Deserialize<Player>(content);
            Console.WriteLine($"Game loaded for {player?.Name}");
        }
        else
        {
            var newPlayer = new Player { Name = "Coralie", Level = 1, Score = 0 };
            string json = JsonSerializer.Serialize(newPlayer, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
            Console.WriteLine("New saved game created");
        }
    }

    public void Save(Player player)
    {
        Directory.CreateDirectory(folder);
        string filePath = Path.Combine(folder, fileName);
        string json = JsonSerializer.Serialize(player, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }
}
