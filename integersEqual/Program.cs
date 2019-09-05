using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integersEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "This Program Determines Whether or Not Two Integers are Equal");

            Console.WriteLine("Please Enter Your First Integer");

            string firstInt = Console.ReadLine();

            Console.WriteLine("You Entered " + firstInt + ".");

            Console.WriteLine("Please Enter Your Second Integer");

            string secondInt = Console.ReadLine();

            Console.WriteLine("You Entered " + secondInt + ".");

            if (firstInt == secondInt)
            {
                Console.WriteLine("Your Integers are Equal!");
            }
            else {
                Console.WriteLine("Your Integers are Not Equal!");
            }
            
        }
    }
}
