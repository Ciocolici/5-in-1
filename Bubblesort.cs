using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5in1
{
    internal class Bubblesort
    {
        public static void Start()
        {
            Console.Clear();

            // Variables
            bool check;
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int fourthNumber;

            // Title Bubblesort
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\n   _     _     _     _     _     _     _     _     _     _  \r\n  / \\   / \\   / \\   / \\   / \\   / \\   / \\   / \\   / \\   / \\ \r\n ( B ) ( U ) ( B ) ( B ) ( L ) ( E ) ( S ) ( O ) ( R ) ( T )\r\n  \\_/   \\_/   \\_/   \\_/   \\_/   \\_/   \\_/   \\_/   \\_/   \\_/ \r\n");
            Console.WriteLine("\n");
            Console.WriteLine("A simple sorting algorithm.");
            Console.WriteLine("\n\n\n");

            // Loops ask for 4 numbers, repeating if given anything other than numbers
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Give the first number!");
                check = int.TryParse(Console.ReadLine(), out firstNumber);

                if (check == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only numbers, please.");
                }
            } while (check == false);

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Give the second number!");
                check = int.TryParse(Console.ReadLine(), out secondNumber);

                if (check == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only numbers, please.");
                }
            } while (check == false);

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Give the third number!");
                check = int.TryParse(Console.ReadLine(), out thirdNumber);

                if (check == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only numbers, please.");
                }
            } while (check == false);

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Give the fourth number!");
                check = int.TryParse(Console.ReadLine(), out fourthNumber);

                if (check == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only numbers, please.");
                }
            } while (check == false);

            // Array with the four numbers chosen
            int[] numberArray = { firstNumber, secondNumber, thirdNumber, fourthNumber };

            // Loop sorting from tiniest to biggest number
            // First "for" (i) is used only to give how many times the loop should repeat, in this case 4
            // Second "for" (j) uses j as index to change the index value inside the array: j is first index 0, and it checks with the other 3 indexes, but skip the index which i has at the present loop ( <3 - i )
            // If the value of the index j has at the present loop is bigger than the next one ( j + 1 ):
            // - it creates a temp (temporary) variable which has j's present value
            // - j's present index value gets changed with the next one ( j + 1 )
            // - j's next index value ( j + 1 ) gets changed with temp variable's value (which is the same value as the present index value had at the beginning)
            // - this way the two gets swapped
            // It then gets back to the for-loop and goes on with the second loop (up to 4) to check the next index value and repeat the same steps

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3 - i; j++)
                    if (numberArray[j] > numberArray[j + 1])
                    {
                        int temp = numberArray[j];
                        numberArray[j] = numberArray[j + 1];
                        numberArray[j + 1] = temp;
                    }
            }

            // Output of the numbers in the correct order
            // foreach creates a variable called "number" once for each index inside the "numberArray", each time running the WriteLine inside { } displaying its value.
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Here are the numbers in the correct order, from the tiniest to the biggest.");

            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (int number in numberArray)
            {
                Console.WriteLine($"\n\n\t\t\t\t{number}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
