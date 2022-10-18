using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodAssignment1
{
    public class Math
    {
        //First method takes in an Integer
        public int Arithmetic(int num1, int num2)
        {
            return num1 + num2;
        }
        //Second method that takes in decimal
        public int Arithmetic(decimal num1, decimal num2)
        {
            int number = Convert.ToInt32(num1);
            int number2 = Convert.ToInt32(num2);
            return number * number2;
        }
        public int Arithmetic(string num1, string num2)
        {
            int number1 = Convert.ToInt32(num1);
            int number2 = Convert.ToInt32(num2);

            return number1 + number2 ;

        }

    }


}
