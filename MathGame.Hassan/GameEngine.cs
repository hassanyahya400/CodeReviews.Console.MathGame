using System;
using MathGame.Hassan.Models;

namespace MathGame.Hassan
{
	public class GameEngine
	{
        internal void MultiplicationOperation()
        {
            int score = 0;
            var random = new Random();

            for (int i = 1; i <= 5; ++i)
            {
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} x {secondNumber}");
                var answer = Console.ReadLine();
                answer = Helpers.ValidateUserAnswer(answer);

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

            Helpers.AddToGameHistory(score, GameType.Multiplication);

            Console.WriteLine($"Your total score is {score}pts.\nGame over. Press any key to go back to main menu");
            Console.ReadLine();
        }

        internal void DivisionOperation()
        {
            int score = 0;

            for (int i = 1; i <= 5; ++i)
            {
                int[] divisionNumbers = Helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} ÷ {secondNumber}");
                var answer = Console.ReadLine();
                answer = Helpers.ValidateUserAnswer(answer);

                if (int.Parse(answer) == firstNumber / secondNumber)
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

            Helpers.AddToGameHistory(score, GameType.Division);

            Console.WriteLine($"Your total score is {score}pts.\nGame over. Press any key to go back to main menu");
            Console.ReadLine();
        }

        internal void SubtractionOperation()
        {
            int score = 0;
            var random = new Random();

            for (int i = 1; i <= 5; ++i)
            {
                int firstNumber = random.Next(0, 9);
                int secondNumber = random.Next(0, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var answer = Console.ReadLine();
                answer = Helpers.ValidateUserAnswer(answer);

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

            Helpers.AddToGameHistory(score, GameType.Subtraction);

            Console.WriteLine($"Your total score is {score}pts.\nGame over. Press any key to go back to main menu");
            Console.ReadLine();
        }

        internal void AdditionOperation()
        {
            int score = 0;
            var random = new Random();

            for (int i = 1; i <= 5; ++i)
            {
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var answer = Console.ReadLine();
                answer = Helpers.ValidateUserAnswer(answer);

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

            Helpers.AddToGameHistory(score, GameType.Addition);

            Console.WriteLine($"Your total score is {score}pts.\nGame over. Press any key to go back to main menu");
            Console.ReadLine();
        }
    }
}

