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
        public decimal Arithmetic(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        public string Arithmetic(string num1, string num2)
        {
            int.Parse(num1);
            int.Parse(num2);
            return num1+ num2;

        }

    }


}
