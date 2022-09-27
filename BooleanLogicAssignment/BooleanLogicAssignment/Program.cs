using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome please answer the following question!");
            Console.WriteLine("What is your age?");
            string strAge = Console.ReadLine();
            int age = Convert.ToInt32(strAge);
            Console.WriteLine("Have you ever had a DUI? please answer with True or False");
            string StrDUI = Console.ReadLine();
            bool DUI = Convert.ToBoolean(StrDUI);
            Console.WriteLine("How many speeding tickets do you have?");
            string strTicket = Console.ReadLine();
            int Ticket = Convert.ToInt32(strTicket);
            Console.WriteLine("Please wait while we review your application!");
            bool approved = (age > 15 && DUI == false && Ticket <= 3);


            Console.WriteLine("Age: " + age);
            Console.WriteLine("Dui: " + DUI);
            Console.WriteLine("Speeding tickets: " + Ticket);
            Console.WriteLine("Qualified? " + approved);
            Console.ReadLine();





        }
    }
}
