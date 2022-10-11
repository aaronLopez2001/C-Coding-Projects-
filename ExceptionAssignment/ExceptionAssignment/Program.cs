using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //No error messages when typing 0 in the console.
                List<int> numbers = new List<int>();
                numbers.Add(2);
                numbers.Add(4);
                numbers.Add(6);
                numbers.Add(8);
                numbers.Add(10);
                Console.WriteLine("Please pick a number that is greater than 1.");
                int dividend = Convert.ToInt32(Console.ReadLine());
                if (dividend == 0)
                {
                    Console.WriteLine("Please do not enter zero! ");
                    return;
                }
                foreach (int divisor in numbers)
                {
                
                    int total = dividend / divisor;
                    Console.WriteLine(total);
                }
                Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero ");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Make sure to put in a whole number!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
