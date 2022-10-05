using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysANDList
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Select an Array between 0, 1, 2");
            int arrayAnswer = Convert.ToInt32(Console.ReadLine());

            string[] stringArray = new string[3];
            stringArray[0] = "You've pressed the veryFirst Array";
            stringArray[1] = "This is the second";
            stringArray[2] = "And this is the third";

           

            int[] intArray = new int[3];
            intArray[0] = 2;
            intArray[1] = 4;
            intArray[2] = 6;

            if (arrayAnswer == 0)
            {
                Console.WriteLine(stringArray[0]);
                Console.Read();
            }
            else if (arrayAnswer == 1)
            {
                Console.WriteLine(stringArray[1]);
                Console.Read();
            }
            else if (arrayAnswer == 2)
            {
                Console.WriteLine(stringArray[2]);
                Console.Read();
            }
            else 
            {
                Console.WriteLine("Please select only from the given value!");
                Console.Read();
            }
            //-----------------------------INTEGERS ARRAY----------------------------//
            Console.WriteLine("Please select an index from 0-2");
            Console.Read();

            int intArrayAnswer = Convert.ToInt32(Console.ReadLine());

            if (intArrayAnswer == 0)
            {
                Console.WriteLine(intArray[0]);
                Console.Read();
            }
            else if (intArrayAnswer == 1)
            {
                Console.WriteLine(intArray[1]);
                Console.Read();
            }
            else if (intArrayAnswer == 2)
            {
                Console.WriteLine(intArray[2]);
                Console.Read();
            }
            else
            {
                Console.WriteLine("Please select only from the given value!");
                Console.Read();
            }

            Console.Read();

            //--------------LIST OF STRINGS ------------------------------//

            Console.WriteLine("Pick a number between 0-3");
            int stringListAnswer = Convert.ToInt32(Console.ReadLine());
            List<string> stringList = new List<string>();
            stringList.Add("You typed 0");
            stringList.Add("You typed 1");
            stringList.Add("You typed 2");
            stringList.Add("You typed 3");

            switch (stringListAnswer) 
            {
                case 0:
                    Console.WriteLine(stringList[0]);
                    break;
                case 1:
                    Console.WriteLine(stringList[1]);
                    break;
                case 2:
                    Console.WriteLine(stringList[2]);
                    break;
                case 3:
                    Console.WriteLine(stringList[3]);
                    break;
                default:
                    Console.WriteLine("Please select only from the given value!");
                    break;
            }

            Console.Read();






            ////Array
            ////int[] numArray = new int[5];
            ////numArray[0] = 5;
            ////numArray[1] = 2;
            ////numArray[2] = 10;
            ////numArray[3] = 200;
            ////numArray[4] = 5000;

            ////int[] numArray1 = new int[] {5,2,10,200, 5000};
            ////int[] numArray2 = { 5, 2, 10, 200, 5000, 500, 600, 2300 };
            ////Console.WriteLine(numArray2[5]);
            ////Console.Read();

            ////Lists
            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //Console.WriteLine(intList[0]);
            //Console.Write
        }
    }
}
