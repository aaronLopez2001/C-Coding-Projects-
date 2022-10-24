using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.firstName = "Sample";
            obj.lastName = "Student";
            obj.SayName();
            Console.ReadLine();
        }
    }
}
