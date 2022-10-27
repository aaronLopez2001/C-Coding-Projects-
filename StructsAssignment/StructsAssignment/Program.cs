using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number obj = new Number();
            obj.Amount = 55.12m;
            Console.WriteLine("$"+ obj.Amount);
            Console.ReadLine();
        }

    }
}
