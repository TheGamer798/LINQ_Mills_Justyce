using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LINQ_Mills_Justyce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game[] games = new Game[]//an array of Games called games, initialized with 10 games
            {
            new Game("Minecraft", 'E', "Action-Adventure"),
            new Game("Warframe", 'M', "Sci-fi Looter-Shooter"),
            new Game("Elsword", 'T', "Action-Adventure"),
            new Game("Titanfal 2", 'M', "FPS"),
            new Game("Battlefield 1", 'M', "FPS"),
            new Game("Undertale", 'E', "Action-Adventure"),
            new Game("BorderLands 2", 'M', "FPS Looter-Shooter"),
            new Game("Call of Duty: Black Ops 2", 'M', "FPS"),
            new Game("Skate 3", 'T', "Skate Boarding"),
            new Game("Colin McRae: Dirt", 'E', "Simcade Racing")
            };

            var shortGames = from game in games//a LINQ Query to get all games with less than 9 characters in the title and assigns it to a var called shortGames
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";//select to print "Game Title: <game.Title.ToUpper>"

            foreach (var game in shortGames)//Loops through and prints each element in shortGames
            {
                Console.WriteLine(game);
            }

            var mineCraft = games.Where(game => game.Title == "Minecraft")//a LINQ method query to find the game "Minecraft" from the games array and assigns it to a var called mineCraft
                             .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre: {game.Genre}");

            Console.WriteLine(mineCraft.FirstOrDefault());//Print all the game properties of mineCraft to console using the FirstOrDefault method

            var tRated = from game in games//Create a var named tRated and select the titles where the esrb rating is 'T'
                         where game.Esrb == 'T'
                         select game.Title;

            Console.WriteLine("T Rated Games:");//Print to console, "T Rated Games:"
            foreach(var game in tRated)//Loop through tRated and print each element to console
            {
                Console.WriteLine(game);
            }

            var eRatedAction = from game in games//Create a var called eRatedAction and select the titles where the esrb rating is 'E' and genre is "Action"
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                                            select game.Title;

            Console.WriteLine("E Rated Action Games:");//Print to console, "E Rated Action Games:"
            foreach (var game in eRatedAction)//Loop through eRatedAction and print each element to console
            {
                Console.WriteLine(game);
            }
        }
    }
}