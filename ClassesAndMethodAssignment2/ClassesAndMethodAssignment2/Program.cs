using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Class arithmetic = new Class();
           
            Console.WriteLine("Type in a number!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in a second number!(This one is optional)");
            string num2 = Console.ReadLine();
            
            if (num2 == "")
            {
                Console.WriteLine(arithmetic.Math(num1));
            }
            else
            {
                int number2 = Convert.ToInt32(num2);
                Console.WriteLine(arithmetic.Math(num1,number2));
            }
          

            
            Console.Read();
        }
    }
}
