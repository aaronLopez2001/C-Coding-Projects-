using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment1
{
     class TakesInteger
    {

        //First
        public  int Addition(int x,int y)
        {
            int sum = x + y;
            return sum;
        }

         public  int Subtraction(int x, int y)
        {
            int difference = x - y;
            return difference;
        }
        public int Division(int x, int y)
        {
            int quotient = x / y;
            return quotient;
        }
        public int Multiplication(int x, int y)
        {
            int product = x * y;
            return product;
        }
        //Second
        public decimal Modulus(decimal num1, decimal num2)
        {

            decimal rand = num1 % num2 ;
            int random = Convert.ToInt32(rand);
            return random;
        }
        public decimal Modulus(decimal number1, decimal number2 , decimal x = 0)
        {

            decimal rand = number1 % number2 + x;
           
            return rand;
        }
        //Third
        public string Modulus(string x,string y)
        {
            return x+ y;
        }


    }
}
