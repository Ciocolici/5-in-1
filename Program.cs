namespace _5in1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bubblesort
            // Diamanten
            // Fibonacci
            // Taschenrechner
            // Warm und kälter
            
            
            // Title 5 in 1: Choose Your Game
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\r\n########    #### ##    ##       ##   \r\n##           ##  ###   ##     ####   \r\n##           ##  ####  ##       ##   \r\n#######      ##  ## ## ##       ##   \r\n      ##     ##  ##  ####       ##   \r\n##    ##     ##  ##   ###       ##   \r\n ######     #### ##    ##     ###### \r\n");
            Console.WriteLine("\n\n\n");

            // Variables
            int program;
            bool check;
            bool repeat;
            bool askYesOrNoAgain;

            // Loop for repeat
            // Loop inside the loop, asking for the program, if the user gives something else other than the number of the game he is prompted to answer again
            // It also checks which of the 5 programs has been chosen, if any other number has been given, the User is asked to choose again
            // Starts the Method with the program the user has chosen
            // After the program has ended, it starts a loop asking the user if he wants to start another program or the same program again, with yes/no as answers, anything else restarts the loop.

            do
            {
                repeat = false;
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Input the number representing the program you wish to run:");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\n1.Bubblesort");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("2.Diamanten");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("3.Fibonacci");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("4.Taschenrechner");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("5.Warm und Kälter");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    check = int.TryParse(Console.ReadLine(), out program);

                    if (check == false)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Only the number of the program, please.");
                    }
                    else if (program == 1)
                    {
                        Bubblesort.Start();
                    }
                    else if (program == 2)
                    {
                        Diamanten.Start();
                    }
                    else if (program == 3)
                    {
                        Fibonacci.Start();
                    }
                    else if (program == 4)
                    {
                        Taschenrechner.Start();
                    }
                    else if (program == 5)
                    {
                        WarmUndKaelter.Start();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        check = false;
                        Console.WriteLine("Please choose one of the 5 programs, any other number is wrong.");
                    }
                } while (check == false);

                do
                {
                    askYesOrNoAgain = false;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Would you like to run another program again? yes/no");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        repeat = true;
                        Console.Clear();
                    }
                    else if (answer == "no")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("I see, good bye! :(");
                    }
                    else
                    {
                        Console.Clear();
                        askYesOrNoAgain = true;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("yes/no. Any other answer is not accepted.");
                    }
                } while (askYesOrNoAgain == true);

            } while (repeat == true);


        }
    }
}