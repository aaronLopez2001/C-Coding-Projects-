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
            IQuittable obj1 = new Employee();
            Employee obj = new Employee();
            obj.firstName = "Sample";
            obj.lastName = "Student";
            obj.SayName();
            obj.Quit();
            Console.ReadLine();
        }
    }
}
