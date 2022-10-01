using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is 5 * 5 ?");
            int answer = Convert.ToInt32(Console.ReadLine());
            bool correct = answer == 25;
            while (!correct)
            {
                switch (answer)
                {
                    case 25:
                        Console.WriteLine("That is correct!");
                        Console.Read();
                        break;
                    case 35:
                        Console.WriteLine($"{answer} is incorrect please try again!");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 41:
                        Console.WriteLine($"{answer} is incorrect please try again!");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine($"{answer} is incorrect please try again!");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine($"{answer} is incorrect please try again!");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            Console.Read();

        }
    }
}
