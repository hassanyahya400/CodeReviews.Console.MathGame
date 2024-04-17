using System.Linq.Expressions;
using static System.Formats.Asn1.AsnWriter;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Please enter your name:  ");

        var gameHistory = new List<string>();
        var date = DateTime.UtcNow;
        var name = Console.ReadLine();

        Menu(name);

        void Menu(string? name)
        {
            bool isGameOn = true;
            printDivider();
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek} today 😃. Welcome to the maths game!\n");

            do
            {
                Console.Clear();
                Console.WriteLine("What operation would you like to do?\n" +
                                   "V - View history " +
                                   "A - Addition " +
                                   "S - Subtration " +
                                   "D - Division " +
                                   "M - Multiplication " +
                                   "Q - Quit game "
               );

                printDivider();

                var operationSelected = Console.ReadLine();

                switch (operationSelected.Trim().ToUpper())
                {
                    case "V":
                        GetHistory();
                        break;
                    case "A":
                        AdditionOperation();
                        break;
                    case "S":
                        SubtractionOperation();
                        break;
                    case "D":
                        DivisionOperation();
                        break;
                    case "M":
                        MultiplicationOperation();
                        break;
                    case "Q":
                        Console.WriteLine("GOODBYE 👋 ");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected ❌");
                        Environment.Exit(1);
                        break;
                }

            } while (isGameOn);
        }

        void MultiplicationOperation()
        {
            int score = 0;
            var random = new Random();

            for (int i = 1; i <= 5; ++i)
            {
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} x {secondNumber}");
                var answer = Console.ReadLine();

                if (int.Parse(answer) == firstNumber * secondNumber)
                {
                    score++;
                    Console.WriteLine("Congratulations! Your answer is correct. Press any key to go see the next question");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Ooops! Your answer is wrong. Press any key to go see the next question");
                    Console.ReadLine();
                }

            }

            AddHistory(score, "Multiplication");

            Console.WriteLine($"Your total score is {score}pts.\nGame over. Press any key to go back to main menu");
            Console.ReadLine();
        }

        void DivisionOperation()
        {
            int score = 0;

            for (int i = 1; i <= 5; ++i)
            {
                int[] divisionNumbers = GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} ÷ {secondNumber}");
                var answer = Console.ReadLine();

                if (int.Parse(answer) == firstNumber/secondNumber)
                {
                    score++;
                    Console.WriteLine("Congratulations! Your answer is correct. Press any key to go see the next question");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Ooops! Your answer is wrong. Press any key to go see the next question");
                    Console.ReadLine();
                }

            }

            AddHistory(score, "Division");

            Console.WriteLine($"Your total score is {score}pts.\nGame over. Press any key to go back to main menu");
            Console.ReadLine();
        }

        void SubtractionOperation()
        {
            int score = 0;
            var random = new Random();

            for (int i = 1; i <= 5; ++i)
            {
                int firstNumber = random.Next(0, 9);
                int secondNumber = random.Next(0, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var answer = Console.ReadLine();

                if (int.Parse(answer) == firstNumber - secondNumber)
                {
                    score++;
                    Console.WriteLine("Congratulations! Your answer is correct. Press any key to go see the next question");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Ooops! Your answer is wrong. Press any key to go see the next question");
                    Console.ReadLine();
                }

            }

            AddHistory(score, "Subtraction");

            Console.WriteLine($"Your total score is {score}pts.\nGame over. Press any key to go back to main menu");
            Console.ReadLine();
        }

        void AdditionOperation()
        {
            int score = 0;
            var random = new Random();

            for (int i = 1; i <=5; ++i)
            {
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var answer = Console.ReadLine();

                if (int.Parse(answer) == firstNumber + secondNumber)
                {
                    score++;
                    Console.WriteLine("Congratulations! Your answer is correct. Press any key to go see the next question");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Ooops! Your answer is wrong. Press any key to go see the next question");
                    Console.ReadLine();
                }

            }

            AddHistory(score, "Addition");

            Console.WriteLine($"Your total score is {score}pts.\nGame over. Press any key to go back to main menu");
            Console.ReadLine();
        }

        int[] GetDivisionNumbers()
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

        static void printDivider()
        {
            Console.WriteLine("|--------------------------------------------------------------------------|");
        }

        void GetHistory()
        {
            Console.Clear();
            printDivider();

            foreach (string game in gameHistory)
            {
                Console.WriteLine(game);
            }

            printDivider();
            Console.WriteLine($"Press any key to go back to main menu");
            Console.ReadLine();

        }

        void AddHistory(int gameScore, string gameType)
        {
            gameHistory.Add($"{date} | {gameType} | score: {gameScore}pts");
        }


    }
}
