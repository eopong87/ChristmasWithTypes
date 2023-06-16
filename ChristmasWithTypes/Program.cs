using System;

namespace ChristmasWithTypes
{
    class Program
    {
        private const string V = "xbox, iphone x, Nintendo Switch";

        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.Thursday;

            //Done set Santa's name to Kris Kringle
            xmas.Santa = "Kris Kringle";

            //Done Insert 3 presents you would like for xmas.  They must be strings
            xmas.Presents = new string[3] { "xbox", "Nintendo Switch", "Iphone x" };

            //Done Set the TreeHeight to 10
            xmas.TreeHeight = 10;

            Console.WriteLine($"This year christmas falls on {xmasDay} \n");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            Console.WriteLine("Here are the presents we would like:");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"\n We like to call Santa, {xmas.Santa}");
        }
    }
}
