using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Pick a number between 1-5");
            int choice = Convert.ToInt32(Console.ReadLine());
            bool pick = choice == 5;
            do
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You've picked number 1");
                        Console.WriteLine("Please Pick a number between 1-5");
                         choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You've picked number 2");
                        Console.WriteLine("Please Pick a number between 1-5");
                         choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You've picked number 3");
                        Console.WriteLine("Please Pick a number between 1-5");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You've picked number 4");
                        Console.WriteLine("Please Pick a number between 1-5");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You've picked number 5");
                        Console.WriteLine("That is a good number.");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Please only pick a number between 1-5");
                        Console.WriteLine("Please Pick a number between 1-5");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            } while (!pick);
            Console.Read();



        }
    }
}
