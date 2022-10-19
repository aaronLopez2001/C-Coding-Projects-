using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignmentPart6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            List<string> Vegetables = new List<string>();
           
            Vegetables.Add("Kale");
            Vegetables.Add("Cabbage");
            Vegetables.Add("Broccoli");
            Vegetables.Add("Carrot");
            Console.WriteLine("What vegetables do you like the most?");
            string favVeg = Convert.ToString(Console.ReadLine());
            

            foreach (string vegies in Vegetables)
            {
                Console.WriteLine(vegies +" // " +favVeg);
            }
            Console.WriteLine("----------------------------------------------------------------------");
            foreach (string vegies in Vegetables)
            {
                Console.WriteLine(vegies);
            }
            //End of Part 1
            //-------------------------------------------------------------------------------------------------
            //Part 2

            //foreach(string vegies in Vegetables)
            //{
            //    for (; ; ) 
            //    {
            //        Console.WriteLine("//");
            //    }
            //}

            //End of Part 2
            //-------------------------------------------------------------------------------------------------
            //Part 3
            int i = 1;
            for(i=1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------------------------------------------------------------------");
            int o = 1;
            for (o = 1; o <= 10; o++)
            {
                Console.WriteLine(o);
            }


            //End of Part 3
            //-------------------------------------------------------------------------------------------------
            //Part 4
            List<string> unique = new List<string>();
            unique.Add("Jeep");
            unique.Add("Van");
            unique.Add("Sedan");
            unique.Add("Truck");

            Console.WriteLine("What type of Vehicle would you like?");
            string myVehicle = Console.ReadLine();

      
                foreach (string car in unique)
                {
                    Console.WriteLine(unique.IndexOf(myVehicle));
                    if (myVehicle != car)
                    {
                        Console.WriteLine("That type of vehicle is not on the system!");
                    }
                    if(myVehicle == car)
                {
                    break;
                }
                }


            //End of Part 4
            //-------------------------------------------------------------------------------------------------
            //Part 5
            List<string> names = new List<string>();
            names.Add("Aaron");
            names.Add("John");
            names.Add("Erik");
            names.Add("Erik");
            names.Add("Dave");
            names.Add("John");
            Console.WriteLine("Type your name!");
            string myName = Console.ReadLine();
            foreach(string name in names)
            {
                Console.WriteLine(names.IndexOf(myName));
               

                 if(myVehicle != name)
                {
                    Console.WriteLine("That name isn't on our database!");
                    break;
                }
    
            }

            //End of Part 5
            //-------------------------------------------------------------------------------------------------
            Console.Read();
        }
    }
}
