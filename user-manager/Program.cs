using System;

namespace user_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            showMainMenu();

        }
        static int showMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to user manager");
            Console.WriteLine("1. Create user");
            Console.WriteLine("2. Show all users");
            Console.WriteLine("3. Mail user");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Select an option");

            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
