using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class obj = new Class();
            Console.WriteLine("How old are you?");
            int myAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the day of your bithday?");
            int bornDay = Convert.ToInt32(Console.ReadLine());
            


            obj.Practice(myAge,bornDay);
            obj.Practice(myAge = 10, bornDay = 16);

           


            Console.ReadKey();
        }

    }
}
