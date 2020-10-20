//1.0 predefined namespace
using System;

//1.1 custom defined namespace
namespace HelloWorld
{
    class Program
    {
        // execution starts here
                        //Commandline arguements
                        // vvv

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}");

        }
    }
}
