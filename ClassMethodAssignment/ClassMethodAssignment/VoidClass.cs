using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
      class VoidClass 
    {
      

        public void Output(out int x)
        {
            x = 0;
            while(x != 100)
            {
                Console.WriteLine(x+=10);
            }
         
        }
        //Overload a method
        public void Output(int num2, int y, out int b)
        {
            b = num2 + y;

        }
      
        public void Operation(ref int myNum)
        {
            myNum /= StaticClass.num1;

        }


    }

    public static class StaticClass
    {
        public static int num1 = 25;
    }
}
