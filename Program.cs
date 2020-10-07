using System;

namespace PI_Travisci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Yousr Name is " + name);
            Console.WriteLine("Enter your lastname: ");
            var lname = Console.ReadLine();
            Console.WriteLine("Yousr lastname is " + lname);
        }
    }
}
