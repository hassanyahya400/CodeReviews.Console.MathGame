using System.Linq.Expressions;
using MathGame.Hassan;
using static System.Formats.Asn1.AsnWriter;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Please enter your name:  ");

        var gameHistory = new List<string>();
        var date = DateTime.UtcNow;
        var name = Helpers.GetName();
        var menu = new Menu();

        menu.ShowMenu(name, date);
    }
}
