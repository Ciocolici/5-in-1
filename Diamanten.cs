using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5in1
{
    internal class Diamanten
    {
        public static void Start()
        {
            Console.Clear();

            // Title DIAMANTEN
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\r\n/\\\\\\\\\\    /\\\\      /\\       /\\\\       /\\\\      /\\       /\\\\\\     /\\\\/\\\\\\ /\\\\\\\\\\\\/\\\\\\\\\\\\\\\\/\\\\\\     /\\\\\r\n/\\\\   /\\\\ /\\\\     /\\ \\\\     /\\ /\\\\   /\\\\\\     /\\ \\\\     /\\ /\\\\   /\\\\     /\\\\    /\\\\      /\\ /\\\\   /\\\\\r\n/\\\\    /\\\\/\\\\    /\\  /\\\\    /\\\\ /\\\\ / /\\\\    /\\  /\\\\    /\\\\ /\\\\  /\\\\     /\\\\    /\\\\      /\\\\ /\\\\  /\\\\\r\n/\\\\    /\\\\/\\\\   /\\\\   /\\\\   /\\\\  /\\\\  /\\\\   /\\\\   /\\\\   /\\\\  /\\\\ /\\\\     /\\\\    /\\\\\\\\\\\\  /\\\\  /\\\\ /\\\\\r\n/\\\\    /\\\\/\\\\  /\\\\\\\\\\\\ /\\\\  /\\\\   /\\  /\\\\  /\\\\\\\\\\\\ /\\\\  /\\\\   /\\ /\\\\     /\\\\    /\\\\      /\\\\   /\\ /\\\\\r\n/\\\\   /\\\\ /\\\\ /\\\\       /\\\\ /\\\\       /\\\\ /\\\\       /\\\\ /\\\\    /\\ \\\\     /\\\\    /\\\\      /\\\\    /\\ \\\\\r\n/\\\\\\\\\\    /\\\\/\\\\         /\\\\/\\\\       /\\\\/\\\\         /\\\\/\\\\      /\\\\     /\\\\    /\\\\\\\\\\\\\\\\/\\\\      /\\\\\r\n                                                                                                     \r\n");
            Console.WriteLine("\n");
            Console.WriteLine("Create your own diamond.");
            Console.WriteLine("\n\n\n");

            // Variables
            int stars;
            bool check;

            // Loop asking for the number of *, if the user gives something else other than a number it is prompted to answer again
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Input the number of * the half of the diamond should have:");
                check = int.TryParse(Console.ReadLine(), out stars);

                if (check == false)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Only numbers, please.");
                }
            } while (check == false);

            Console.WriteLine("\n\n\n");

            // Output of the top half of the diamond
            // "for" starts the loop going through every "i", starting with 1 ( i = 1 ) and ending with the value number of "stars", the number given by the user ( <= stars )
            // - in each loop a new loop starts with "for" going through every "j", starting with 1 ( j = 1 ), and ending with the number given by the user, ignoring the number which is "i" in the present loop ( stars - i ), every time writing a space ( " " )
            // - it goes to the second loop inside the loop, only now "j" starts as 1, but ends with 2 times what number "i" is in the present loop, minus 1 ( 2 * i - 1 ), every time writing a * ( " * " )
            // It then goes back to the loop and goes forward with the number the next "i" has and repeats everything
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 1; i <= stars; i++)
            {
                for (int j = 1; j <= stars - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            // Output of the bottom half of the diamond
            // "for" starts the loop going through every "i", starting with 1 ( i = 1 ) and ending with the value number of "stars", the number given by the user, - 1 ( <= stars - 1 )
            // - in each loop a new loop starts with "for" going through every "j", starting with 1 ( j = 1 ), and ending with the number given by the user, ignoring the number which is "i" in the present loop ( stars - i ), every time writing a space ( " " )
            // - it goes to the second loop inside the loop, only now "j" starts as 1, but ends with 2 times what number "i" is in the present loop, minus 1 ( 2 * i - 1 ), every time writing a * ( " * " )
            // It then goes back to the loop and goes forward with the number the next "i" has and repeats everything
            for (int i = stars - 1; i >= 1; i--)
            {
                for (int j = 1; j <= stars - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine("\n\n\n");
        }
    }
}
