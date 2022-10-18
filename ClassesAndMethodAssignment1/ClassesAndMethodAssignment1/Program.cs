using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Math obj1 = new Math();
            //Integer is a whole number
            Console.WriteLine("Type in an integer number!");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in another integer number!");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + " + " + y + " = " + obj1.Arithmetic(x,y));
            //Same Method different parameters
           
             Console.WriteLine("Type in a decimal number!");
             decimal i = Convert.ToDecimal(Console.ReadLine());
             Console.WriteLine("Type in another decimal number!");
             decimal o = Convert.ToDecimal(Console.ReadLine());
             Console.WriteLine(i + " x " + o + " = " + obj1.Arithmetic(i, o));
             Console.Read();
                //Third method with string parameters
                Console.WriteLine("Type in a number, the program will interpret it as a string");
                Console.Read();
                string a = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Type in a second number");
                string b = Convert.ToString(Console.ReadLine());

                Console.WriteLine(a + " + " + b + " = " + obj1.Arithmetic(a, b));
            }
            catch(Exception)
            {
                Console.WriteLine("Wrong data type please try again!");
            }
            Console.Read();

        }
    }
}
