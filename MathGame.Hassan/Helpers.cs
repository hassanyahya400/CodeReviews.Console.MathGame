using System;
using MathGame.Hassan.Models;

namespace MathGame.Hassan
{
	public class Helpers
	{

        static List<Game> gameHistory = new List<Game>
        {
            //new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            //new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            //new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
        };

        internal static void printDivider()
        {
            Console.WriteLine("|--------------------------------------------------------------------------|");
        }


        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            int[] numbers = new int[2];
            int firstNumber = random.Next(1, 99);
            int secondNumber = random.Next(1, 99);

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            numbers[0] = firstNumber;
            numbers[1] = secondNumber;

            return numbers;
        }



        internal static void PrintGameHistory()
        {
            IEnumerable<Game> gamesToPrint;
            GameType? filter = filterGameType();

            if (filter is null)
            {
                gamesToPrint = gameHistory;
            }
            else
            {
                gamesToPrint = gameHistory.Where(f => f.Type == filter);
            }

            Console.Clear();
            printDivider();

            foreach (Game game in gamesToPrint)
            {
                Console.WriteLine($"{game.Date} - {game.Type} : {game.Score}pts");
            }

            printDivider();
            Console.WriteLine($"Press any key to go back to main menu");
            Console.ReadLine();

        }

        internal static void AddToGameHistory(int gameScore, GameType gameType)
        {
            gameHistory.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }

        internal static GameType? filterGameType()
        {
            string? filter = Console.ReadLine();

            if (filter is null)
            {
                return GameType.All;
            }
            else if (filter.ToUpper() == "A")
            {
                return GameType.Addition;
            }
            else if (filter.ToUpper() == "S")
            {
                return GameType.Subtraction;
            }
            else if (filter.ToUpper() == "M")
            {
                return GameType.Multiplication;
            }
            else if (filter.ToUpper() == "D")
            {
                return GameType.Division;
            }
            else
            {
                return null;
            }
        }

        internal static string? ValidateUserAnswer(string answer)
        {
            while (string.IsNullOrEmpty(answer) || !Int32.TryParse(answer, out _))
            {
                Console.WriteLine("Kindly enter a valid integer\n");
                answer = Console.ReadLine();
            }

            return answer;
        }

        internal static string GetName()
        {
            string? name = Console.ReadLine();

            while (string.IsNullOrEmpty(name.Trim()))
            {
                Console.WriteLine("\nKindly enter a valid name\n");
                name = Console.ReadLine();
            }

            return name;
        }
    }
}

