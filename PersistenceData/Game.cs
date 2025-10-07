// using System;
// using System.Threading;

// public class Game
// {
//     private Player player;
//     private Saves saves;

//     public Game(Player player, Saves saves)
//     {
//         this.player = player;
//         this.saves = saves;
//     }

//     public void Run()
//     {
//         bool replay;

//         do
//         {
//             Console.Clear();
//             Console.WriteLine($"Welcome {player.Name}! Level: {player.Level}, Score: {player.Score}");
//             Console.WriteLine("Press Left/Right arrows to simulate playing, Esc to quit and save.");

//             int score = 0;
//             int level = player.Level;

//             bool running = true;

//             while (running)
//             {
//                 if (Console.KeyAvailable)
//                 {
//                     var key = Console.ReadKey(true).Key;
//                     if (key == ConsoleKey.LeftArrow)
//                     {
//                         score += 10;
//                         Console.WriteLine($"Moved left. Score: {score}");
//                     }
//                     else if (key == ConsoleKey.RightArrow)
//                     {
//                         score += 10;
//                         Console.WriteLine($"Moved right. Score: {score}");
//                     }
//                     else if (key == ConsoleKey.Escape)
//                     {
//                         running = false;
//                         ShowGameOver();
//                     }
//                 }

//                 if (score >= 3000)
//                 {
//                     running = false;
//                     ShowYouWin();
//                 }

//                 Thread.Sleep(100);
//             }

//             // Save player progress
//             player.Score = score;
//             player.Level = level;
//             saves.Save(player);

//             replay = WaitForReplay();

//         } while (replay);
//     }

//     private void ShowGameOver()
//     {
//         Console.Clear();
//         Console.WriteLine("Game Over!");
//     }

//     private void ShowYouWin()
//     {
//         Console.Clear();
//         Console.WriteLine("You Win!");
//     }

//     // Nouvelle m�thode qui attend un appui pour rejouer ou quitter
//     private bool WaitForReplay()
//     {
//         Console.WriteLine();
//         Console.WriteLine("Press R to replay or A to quit.");

//         while (true)
//         {
//             var key = Console.ReadKey(true).Key;

//             if (key == ConsoleKey.R)
//             {
//                 return true; // rejouer
//             }
//             else if (key == ConsoleKey.A)
//             {
//                 return false; // quitter
//             }
//         }
//     }
// }
