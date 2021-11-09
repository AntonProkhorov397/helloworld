using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ask the user to enter their first name
            //programm greets the user using their first name
            Console.WriteLine("enter yourfirst name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Hello" + firstName + "!" );


            Console.Read();
        }
    }
}
