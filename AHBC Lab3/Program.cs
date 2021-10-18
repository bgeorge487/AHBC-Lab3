using System;

namespace AHBC_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beginning of lab 3

            bool shutdown = false;

            //Ask them for their name, use the variable to refer to them throughout the below prints
            while (!shutdown)
            {
                string userName = "";
            Console.WriteLine("Hello, please enter your name: ");
            userName = Console.ReadLine();

            //Prompt the user to enter a number between 1 and 100

            BeginCode:
            
            Console.WriteLine($"Hello {userName}, please enter an integer between 1 and 100: ");
            string numberEntered = Console.ReadLine();

            int numberValue = int.Parse(numberEntered);

                if (numberValue % 2 > 0) //IF the int is ODD
                {
                    Console.WriteLine($"{userName}, the number is odd.");
                }
                else if (numberValue % 2 == 0 && numberValue > 2 && numberValue < 25) //if the int is EVEN AND between 2 and 25
                {
                    Console.WriteLine($"{userName}, the int is even and less than 25");
                }
                else if (numberValue % 2 == 0 && numberValue > 26 && numberValue < 60) //if the int is EVEN AND between 26 and 60
                {
                    Console.WriteLine($"{userName}, the int is even.");
                }
                else if (numberValue % 2 == 0 && numberValue > 60) //if the int is EVEN and GREATER THAN 60 print the number and "it is Even"
                {
                    Console.WriteLine($"{userName}, {numberValue} is even.");
                } else if (numberValue % 2 > 0 && numberValue > 60) //if the int is ODD and GREATER THAN 60 print the numeber and "it is Odd"
                {
                    Console.WriteLine($"{userName}, {numberValue} is Odd");
                }

                Console.WriteLine($"Would you like to continue, {userName}? (y/n)");
                string userContinue = Console.ReadLine();

                if (userContinue == "y") //Ask if they want to continue, if they do, goto BeginningCode: if not, close.
                {
                    goto BeginCode;
                } else if (userContinue == "n")
                {
                    Console.WriteLine("Good Bye!");
                    return;
                }
                
            }
        }
    }
}
