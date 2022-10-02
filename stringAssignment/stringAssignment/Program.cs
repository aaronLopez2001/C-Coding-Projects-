using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Where are you from?");
            string address = Console.ReadLine();
            string firstString = "Hello ";
            string secondString = "My name Is ";
            string thirdString = " and I am from ";
            Console.WriteLine($"{firstString}{secondString}{name}{thirdString}{address}");
            Console.WriteLine(name.ToUpper());
           
            StringBuilder lbrry = new StringBuilder();
            lbrry.Append($"My name Is {name}");
            Console.WriteLine(lbrry);
            Console.Read();
        }
    }
}
