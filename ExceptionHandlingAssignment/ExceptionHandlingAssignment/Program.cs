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



            try
            {

                int age = Convert.ToInt32(Console.ReadLine());

                int year = DateTime.Now.Year;
                
                
                if (age < 0)
                {
                    Console.WriteLine("Please type in  a valit age!");
                }
                else
                {
                    int yearBorn = year - age;
                    Console.WriteLine("You were born in the year {0}", yearBorn);
                }
                
                


            }
            catch  (FormatException e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadLine();










        } } }
