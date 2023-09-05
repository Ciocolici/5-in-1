using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5in1
{
    internal class Fibonacci
    {
        public static void Start()
        {
            Console.Clear();

            // Title Fibonacci
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\r\n    ____    __     _                                                               __ \r\n   F ___J   LJ    FJ___       ____      _ ___       ___ _      ____       ____     LJ \r\n  J |___:        J  __ J     F __ J    J '__ J     F __` L    F ___J.    F ___J.      \r\n  | _____|  FJ   | |--| |   | |--| |   | |__| |   | |--| |   | |---LJ   | |---LJ   FJ \r\n  F |____J J  L  F L__J J   F L__J J   F L  J J   F L__J J   F L___--.  F L___--. J  L\r\n J__F      J__L J__,____/L J\\______/F J__L  J__L J\\____,__L J\\______/F J\\______/F J__L\r\n |__|      |__| J__,____F   J______F  |__L  J__|  J____,__F  J______F   J______F  |__|\r\n                                                                                      \r\n");
            Console.WriteLine("\n");
            Console.WriteLine("In the Fibonacci sequence each number is the sum of the two preceding ones.");
            Console.WriteLine("\n\n\n");


            // Variables
            bool check;
            int number;
            int first = 0;
            int second = 2;

            // User Prompt for the number of fibonacci terms
            // Loop checks if the user gave a number, otherwise it repeats and asks for the right answer
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter the number of Fibonacci terms to generate: ");
                check = int.TryParse(Console.ReadLine(), out number);

                if (check == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only numbers, please.");
                }
            } while (check == false);

            // Here is the fibonacci code
            // The "first" and "second" variables, being the first two numbers (0 and 1), get printed
            // With "for" a loop starts, going through i, with i first being 2, and ending as the last number before the value of "number" (given by the user)
            // Each time, the variable "next" is created, being the sum of the variables "first" and "second"
            // next's actual value gets printed
            // "first"'s value changes to "second"'s, and "second"'s value changes to "next"'s
            // Then the loop repeats itself until the last number before the value of "number"
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n");
            Console.Write(first + " " + second + " ");

            for (int i = 2; i < number; i++)
            {
                int next = first + second;
                Console.Write(next + " ");

                first = second;
                second = next;
            }

            Console.WriteLine("\n\n\n");

        }
    }
}
