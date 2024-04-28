using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MathGame.Hassan
{
	public class Menu
	{
        internal void ShowMenu(string? name, DateTime date)
        {
            GameEngine engine = new GameEngine();
            bool isGameOn = true;
            Helpers.printDivider();
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

                Helpers.printDivider();

                var operationSelected = Console.ReadLine();

                switch (operationSelected.Trim().ToUpper())
                {
                    case "V":
                        Console.WriteLine("What filter would you like to use?\n" +
                                 "N - No Filter " +
                                 "A - Addition " +
                                 "S - Subtration " +
                                 "D - Division " +
                                 "M - Multiplication"
                                );
                        Helpers.PrintGameHistory();
                        break;
                    case "A":
                        engine.AdditionOperation();
                        break;
                    case "S":
                        engine.SubtractionOperation();
                        break;
                    case "D":
                        engine.DivisionOperation();
                        break;
                    case "M":
                        engine.MultiplicationOperation();
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
    }
}

