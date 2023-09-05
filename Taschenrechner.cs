using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5in1
{
    internal class Taschenrechner
    {
        public static void Start()
        {
            Console.Clear();

            // Title Taschenrechner
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\r\n\"\"8\"\"                                                                            \r\n  8   eeeee eeeee eeee e   e eeee eeeee eeeee  eeee eeee e   e eeeee eeee eeeee  \r\n  8e  8   8 8   \" 8  8 8   8 8    8   8 8   8  8    8  8 8   8 8   8 8    8   8  \r\n  88  8eee8 8eeee 8e   8eee8 8eee 8e  8 8eee8e 8eee 8e   8eee8 8e  8 8eee 8eee8e \r\n  88  88  8    88 88   88  8 88   88  8 88   8 88   88   88  8 88  8 88   88   8 \r\n  88  88  8 8ee88 88e8 88  8 88ee 88  8 88   8 88ee 88e8 88  8 88  8 88ee 88   8 \r\n                                                                                 \r\n");
            Console.WriteLine("\n");
            Console.WriteLine("Just a basic calculator");
            Console.WriteLine("\n\n\n");


            // Variables
            bool replay;
            bool check;
            string wantToReplay;
            double number1;
            double number2;
            string ecuation;
            double ergebnis;

            // Start Loop for Replay 
            // Inside it it a loop for checking if the answer for number 1 is a number starts
            // Then a loop for the ecuation
            // Then a loop for the second number
            // In the end the Ecuation is displayed and the user gets in another loop being asked if he wants to do a new ecuation

            do
            {
                replay = false;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Which number do you want to calculate?\t");
                    check = double.TryParse(Console.ReadLine(), out number1);

                    if (check == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only numbers, please.");
                    }
                } while (check == false);
                do
                {
                    check = true;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\nWhat type of an ecuation would you like? + - / *\t");
                    ecuation = Console.ReadLine();

                    if (ecuation == "+" || ecuation == "-" || ecuation == "/" || ecuation == "*")
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong answer. Please choose one of the four: + - / *");
                        Console.WriteLine($"Your first number chosen was {number1}.");
                        check = false;
                    }
                } while (check == false);
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Which is the second number you want to calculate?\t");
                    check = double.TryParse(Console.ReadLine(), out number2);

                    if (check == false)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Only numbers, please.");
                        Console.WriteLine($"Your first number chosen was {number1}, and want calculate it using {ecuation}.");
                    }
                } while (check == false);

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                if (ecuation == "+")
                {
                    ergebnis = number1 + number2;
                    Console.WriteLine($"\n{number1} + {number2} = {ergebnis}");
                }
                else if (ecuation == "-")
                {
                    ergebnis = number1 - number2;
                    Console.WriteLine($"\n{number1} - {number2} = {ergebnis}");
                }
                if (ecuation == "/")
                {
                    ergebnis = number1 / number2;
                    Console.WriteLine($"\n{number1} / {number2} = {ergebnis}");
                }
                if (ecuation == "*")
                {
                    ergebnis = number1 * number2;
                    Console.WriteLine($"\n{number1} * {number2} = {ergebnis}");
                }

                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    check = true;
                    Console.WriteLine("\n\n\nWould you like to calculate something else? yes/no");
                    wantToReplay = Console.ReadLine();
                    if (wantToReplay == "yes")
                    {
                        replay = true;
                        Console.Clear();
                    }
                    else if (wantToReplay == "no")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sad..");
                    }
                    else
                    {
                        Console.Clear();
                        check = false;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("yes/no. Any other answer is not accepted.");
                    }
                } while (check == false);
            } while (replay == true);

            Console.WriteLine("\n\n\n");

        }
    }
}
