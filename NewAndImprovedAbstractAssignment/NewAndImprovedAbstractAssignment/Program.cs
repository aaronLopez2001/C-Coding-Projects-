using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAndImprovedAbstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj2 = new Employee();
            Console.WriteLine("What is your first name?");
            string myFirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string myLastName = Console.ReadLine();
            Console.WriteLine("What is your 4 digit pin?");
            int myPin = Convert.ToInt32(Console.ReadLine());

            List<string> people = new List<string>();

            obj2.Name = "Aaron Lopez";
            obj2.Name = "Bob Smith";
          
            IQuittable obj1 = new Employee();
            Employee obj = new Employee();
            obj.FirstName = "Aaron";
            obj.LastName = "Lopez";
            obj.id1 = 4204;
            obj.id2 = myPin;
            obj2.Name = "Aaron Lopez";
            bool status = obj.id1 == obj.id2;
            if(status == true)
            {
                Console.WriteLine("They have the same ID");
            }
            else
            {
                Console.WriteLine("They do not have the same ID");
            }

         
            foreach (string name in people)
            {
                if (name.Contains(obj.FirstName)&& name.Contains(obj.LastName) )
                {
                    Console.WriteLine("//");
                }
                else
                {
                    people.Add(name);
                }
                
            }

            



            obj.SayName();
            obj.Quit();
            Console.Read();
        }
    }
}
