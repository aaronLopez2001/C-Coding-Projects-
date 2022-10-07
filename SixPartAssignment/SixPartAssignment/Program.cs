using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4];
            names[0] = "Jenny";
            names[1] = "John";
            names[2] = "Josh";
            names[3] = "Jake";

            Console.WriteLine("Please type your name: ");
            string userName = Console.ReadLine();
            
            Console.WriteLine("The names are: " + names[0] +" "+ names[1] +" "+ names[2] +" "+ names[3]);

            Console.WriteLine(names[0] +" "+userName);
            Console.WriteLine(names[1] +" "+userName);
            Console.WriteLine(names[2] +" "+userName);
            Console.WriteLine(names[3] +" "+userName);

            for (int i = 0; i <= 2; i++)
            {
                if (names[i] == "Jake")
                {
                    Console.WriteLine("Hello, I am Josh!");
                }
                else
                {
                    Console.WriteLine("//");
                }
            }
            for (int j = 0; j < names.Length; j++)
            {
                if (names[j] == "Josh")
                {
                    Console.WriteLine("Hello, I am Josh");
                }
                else
                {
                    Console.WriteLine("//");
                }
            }

            //for(; ; )
            //{
            //    Console.WriteLine("Is this right?");
            //}





            // Part 4

            List<String> fruits = new List<String>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Oranges");
            fruits.Add("Kiwi");
            Console.WriteLine("What is your favorite fruit?");
            String myFavfruit = Console.ReadLine();
         
            foreach(string Items in fruits)
            {
                if(myFavfruit == Items)
                {
                    Console.WriteLine(Items);
                }
                else if (myFavfruit != Items)
                {
                    Console.WriteLine("//");
                }

                if (myFavfruit == Items)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
                if (myFavfruit == Items)
                {
                    
                    break;
                }
                Console.WriteLine("Try again");
            }
            List<string> identicalStrings = new List<string>();
            identicalStrings.Add("Hello");
            identicalStrings.Add("World");
            identicalStrings.Add("Hello");
            identicalStrings.Add("Test");
            Console.WriteLine("----------------------------------------------");

            foreach (string identt in identicalStrings)
            {
                Console.WriteLine(identt);
                if (identt.Contains("Hello"))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                    Console.WriteLine("------------------------------------------");
                }
            }



            Console.Read();




        }
    }
}
