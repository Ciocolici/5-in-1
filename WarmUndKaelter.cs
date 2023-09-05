using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _5in1
{
    internal class WarmUndKaelter
    {
        public static void Start()
        {
            Console.Clear();

            // Title Warm und Kälter
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\r\n.-.  .-.   .--.   .---.  .-.  .-.     .-. .-. .-. .-. .----.      .-..-.  {}--{}  .-.    .-----. .----. .---.  \r\n| {  } |  / {} \\  } }}_} }  \\/  {     | } { | |  \\{ | } {-. \\     | ' /   / {} \\  } |    `-' '-' } |__} } }}_} \r\n{  /\\  } /  /\\  \\ | } \\  | {  } |     \\ `-' / | }\\  { } '-} /     | . \\  /  /\\  \\ } '--.   } {   } '__} | } \\  \r\n`-'  `-' `-'  `-' `-'-'  `-'  `-'      `---'  `-' `-' `----'      `-'`-` `-'  `-' `----'   `-'   `----' `-'-'  \r\n                                                                                                               \r\n");
            Console.WriteLine("\n");
            Console.WriteLine("A number guessing game.");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Press ENTER to play.");
            Console.ReadLine();
            Console.Clear();

            // Variables
            int randomNumber;
            int userAnswer;
            string playAgainAnswer;
            bool check;
            bool wrong;
            bool playAgain;

            do
            {
                playAgain = false;
                wrong = true;

                // Randomazing a number from 1 to 100
                // Variables for number near the randomized one
                Random rng = new Random();
                randomNumber = rng.Next(1, 100);
                int minusTen = randomNumber - 10;
                int plusTen = randomNumber + 10;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Hmmmm... The PC is thinking...");
                Thread.Sleep(2000);
                Console.WriteLine($"....");
                Thread.Sleep(2000);
                Console.WriteLine($".... .... ....");
                Thread.Sleep(2000);

                // Game Loop inside a for-loop going through "i" 5 times, as chances of win
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Ok, the PC has chosen a number between 1 and 100.");
                Console.WriteLine("You have 5 tries.");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nGuess the number!");
                for (int i = 0; i < 5; i++)
                {
                    do
                    {
                        check = int.TryParse(Console.ReadLine(), out userAnswer);
                        if (check == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Only numbers, please, try again!");
                        }
                        else if (userAnswer >= minusTen && userAnswer <= plusTen && userAnswer != randomNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("WARM");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Try again!");
                        }
                        else if (userAnswer < minusTen || userAnswer > plusTen)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("COLD");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Try again!");
                        }
                        else if (userAnswer == randomNumber)
                        {
                            wrong = false;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\r\n╔═╗╦═╗╔═╗╔╦╗╔═╗      \r\n║ ╦╠╦╝╠═╣ ║ ╚═╗      \r\n╚═╝╩╚═╩ ╩ ╩ ╚═╝┘     \r\n╦ ╦╔═╗╦ ╦  ╦ ╦╔═╗╔╗╔┬\r\n╚╦╝║ ║║ ║  ║║║║ ║║║║│\r\n ╩ ╚═╝╚═╝  ╚╩╝╚═╝╝╚╝o\r\n");
                        }
                    } while (check == false);
                    if (wrong == false)
                    {
                        break;
                    }
                }

                if (wrong == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\r\n╔╗ ╔═╗╦ ╦               \r\n╠╩╗╠═╣╠═╣               \r\n╚═╝╩ ╩╩ ╩┘              \r\n╦ ╦╔═╗╦ ╦  ╦  ╔═╗╔═╗╔╦╗┬\r\n╚╦╝║ ║║ ║  ║  ║ ║╚═╗ ║ │\r\n ╩ ╚═╝╚═╝  ╩═╝╚═╝╚═╝ ╩ o\r\n");
                }

                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    check = false;
                    Console.WriteLine("\n\nWould you like to play again?yes/no");
                    playAgainAnswer = Console.ReadLine();
                    if (playAgainAnswer == "yes")
                    {
                        playAgain = true;
                        Console.Clear();
                    }
                    else if (playAgainAnswer == "no")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Sad..");
                    }
                    else
                    {
                        Console.Clear();
                        check = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please provide a valid answer with yes or no.");
                    }
                } while (check == true);
            } while (playAgain == true);
        }

    }
}
