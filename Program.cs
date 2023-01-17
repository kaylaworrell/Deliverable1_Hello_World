using System;

namespace Deliverable1_Hello_World
{
       internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Solution (1): Hello World!");
            Console.WriteLine(" ");

            string stg = "Hello, World! (2)";
            Console.WriteLine("Soluion (2): " + stg);
            Console.WriteLine(" ");

            Console.WriteLine("Enter a user's name: ");
            string username = Console.ReadLine();
            Console.WriteLine("The user's name is: " + username);
            Console.WriteLine(" ");

            Console.WriteLine("Enter the user's age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The user's age is: " + age);
        }
    }
}
