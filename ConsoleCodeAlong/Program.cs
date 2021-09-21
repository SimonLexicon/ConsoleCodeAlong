using System;

namespace ConsoleCodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int number = 0;
            int userInput;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to my ConsoleApp");
            while(running)
            {
                Console.WriteLine("What do you want to do next?\n 0 for-loop\n 1 for calculate age");
                number = GetNumberFromUser();
                switch(number)
                {
                    case 0:
                        Console.WriteLine("Write how many times for-loop will run:");
                        userInput = GetNumberFromUser();
                        Console.WriteLine(userInput);
                        for (int i = 0; i < userInput; i++)
                        {
                            Console.WriteLine("#{0}", i);
                        }
                        break;
                        // Do not use "Goto:"
                    case 1:
                        Console.WriteLine("Calculate age, input a birth-year");
                        int birthYear = GetNumberFromUser();
                        Console.WriteLine(2021 - birthYear);
                        Console.ReadKey();
                        break;

                    case 2:

                        break;

                    case 3:

                        break;
                    default:
                        Console.WriteLine("Invalid input, try again.");
                        break;

                }
                
                Console.WriteLine("Do you want to quit? 1 for yes");
                
                userInput = GetNumberFromUser();
                if (userInput == 1)
                {
                    running = false;
                }
            }
        }
        static int GetNumberFromUser()
        {
            int userInput = 0;
            bool succeeded = false;
            while (!succeeded)
            {
                succeeded = int.TryParse(Console.ReadLine(), out userInput);
            }
            return userInput;
        }
        /*Everything inside "* *" will be commented out!*/

        // Comment
        //Ctrl + K -> C

        // Uncomment
        //Ctrl + K -> U 

        //Multi cursor
        // Ctrl + Alt -> mouseclick where.

        //static int GetNumberFromUser(string message)
        //{
        //    return 0;
        //}
    }
}
