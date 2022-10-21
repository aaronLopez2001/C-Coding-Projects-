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
            List<string> nameDuplicate = new List<string>();
            foreach(string name in names)
            {
                if (nameDuplicate.Contains(name))
                {
                    Console.WriteLine(name + " (Duplicate)");
                }
                else
                {
                    Console.WriteLine(name);
                    nameDuplicate.Add(name);
                }
    
            }

            //End of Part 5
            //-------------------------------------------------------------------------------------------------
            //Part 6
            List<string> myCountry = new List<string>();
            myCountry.Add("Canada");
            myCountry.Add("Thailand");
            myCountry.Add("Philippines");
            myCountry.Add("Canada");
            myCountry.Add("United States");
            myCountry.Add("Laos");

            List<string> duplicates = new List<string>();
         
            foreach(string countries in myCountry)
            {
                if (duplicates.Contains(countries))
                {
                    Console.WriteLine(countries+" (Duplicate)");
                }else
                {
                    Console.WriteLine(countries);
                    duplicates.Add(countries);
                }
        
               
            }




            //End of Part 6

            Console.Read();
        }
    }
}
