using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment1
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            TakesInteger obj = new TakesInteger();
            decimal o = 0.00m;

            // 1 & 2
            Console.WriteLine("Welcome to my basic calculator!");
            Console.WriteLine("Please select which operators you will be using! \n Type \n 1 for Addition \n 2 for Subtraction \n 3 for Division \n 4 for Multiplication");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in the first number!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in the second number!");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your two number Added is = " + obj.Addition(num1, num2));
                break;

                case 2:
                    Console.WriteLine("Your two number Subtracted is = " + obj.Subtraction(num1, num2));
                    break;

                case 3:
                    Console.WriteLine("Your two number Divided is = " + obj.Division(num1, num2));
                    break;

                case 4:
                    Console.WriteLine("Your two number Multiplied is = " + obj.Multiplication(num1, num2));
                    break;
            }
            Console.ReadLine();


            
            Console.WriteLine("Type in a decimal");
            decimal numb1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Type in another decimal");
            decimal numb2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("The remainder in integer is = " + obj.Modulus(numb1, numb2));
           
            Console.WriteLine("Type in a decimal number");
            decimal x = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Type in another decimal number");
            decimal y = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("The remainder in integer is = " + obj.Modulus(x, y, o));
            Console.WriteLine("Type in either a string or an integer");
            string input = Console.ReadLine();
            Console.WriteLine("Type in another string or integer");
            string input2 = Console.ReadLine();
            Console.WriteLine("We're going to add either the string or the integer " + obj.Modulus(input,input2) );
            Console.ReadLine();

        }
   

    }
}
