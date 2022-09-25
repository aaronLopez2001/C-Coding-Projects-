using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome insert a number and we will multiply it by 50!");
            string input = Console.ReadLine();
            int anotherInput = Convert.ToInt32(input);


            int total = anotherInput * 50;
            Console.WriteLine("The result is: " + total);
            Console.ReadLine();

            //Addition
            Console.WriteLine("Welcome insert a number and we will add 25 to it!");
            string add = Console.ReadLine();
            int number = Convert.ToInt32(add);
            int sum = number + 25;
            Console.WriteLine("The total is: " + sum);
            Console.ReadLine();

            //Division
            Console.WriteLine("And now insert a number and we are going to divide it by 12.5!");
            string dividend = Console.ReadLine();
            double div = Convert.ToDouble(dividend);
            double quotient = div / 12.5;
            Console.WriteLine("The total is: " + quotient);
            Console.ReadLine();

            //Comparison
            Console.WriteLine("insert a number and we will see if it is greater than 50!");
            string numb = Console.ReadLine();
            int comparison = Convert.ToInt32(numb);
            bool great = comparison > 50;

            Console.WriteLine(great);
            Console.ReadLine();

            //Remainder
            Console.WriteLine("Insert a number and we will divide it by 7 and return a remainder!");
            string rem = Console.ReadLine();
            int remain = Convert.ToInt32(rem);
            int remainder = remain % 7;
            Console.WriteLine("The remainder is: " + remainder);
            Console.ReadLine();

        }
    }
}
