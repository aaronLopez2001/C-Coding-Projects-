using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            int year = DateTime.Now.Year;
            int yearBorn = year - age;

            Console.WriteLine(yearBorn);
            Console.Read();

            
             

        }
    }
}
