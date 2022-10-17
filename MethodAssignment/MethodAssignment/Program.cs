using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
         public static void Main(string[] args)
        {
            Math obj1 = new Math();
            

            Console.WriteLine("Type in a number!");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type in another number!");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type: 1 for addition, 2 for subraction, and 3 for multiplication");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice == 1)
            {
                Console.WriteLine("Your number combined together = " + obj1.Addition(num1, num2));
                Console.ReadLine();
            } else if(choice == 2)
            {
                Console.WriteLine("Your number Subtracted = " + obj1.Subtraction(num1, num2));
                Console.ReadLine();
            } else if(choice == 3)
            {
                Console.WriteLine("Your number Multiplied together = " + obj1.Multiplication(num1, num2));
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Please only type in number between 1 to 3");
                Console.Read();
            }
          

        }
 
    }

}
