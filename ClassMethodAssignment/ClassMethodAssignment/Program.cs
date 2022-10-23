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
            Console.WriteLine("Type in another number!");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in a third number!");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            obj.Operation(ref myNum);
            obj.Output(out int x);
            obj.Output(numero1,numero2, out int b);
            
           
         
            Console.WriteLine(x);
            Console.WriteLine($"Your number divided by {StaticClass.num1} is = " + myNum);
            Console.WriteLine(b);
            Console.ReadLine();
 
      
        }

    }
}
