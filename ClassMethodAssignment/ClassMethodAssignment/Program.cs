using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidClass obj = new VoidClass();
            Console.WriteLine("Type in a number!");
            int myNum = Convert.ToInt32(Console.ReadLine());
            Operation(ref myNum);
            obj.Output(out int x);
            obj.Output(myNum,myNum, out int b);
            
           
         
            Console.WriteLine(x);
            Console.WriteLine("Your number divided by 2 is = " + myNum);
            Console.WriteLine(b);
            Console.ReadLine();
 
      
        }
        //Declare a class to be static
        public static void Operation(ref int myNum)
        {
            myNum /= 2;

        }
    }
}
