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
            Employee<string> obj5 = new Employee<string>();
            Employee<int> values = new Employee<int>();
            obj5.Things.Add("Car");
            obj5.Things.Add("Window");
            obj5.Things.Add("Mug");
            values.Things.Add(25000);
            values.Things.Add(300);
            values.Things.Add(10);

            Employee<string> obj2 = new Employee<string>();
            Console.WriteLine("What is your first name?");
            string myFirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string myLastName = Console.ReadLine();
            Console.WriteLine("What is your 4 digit pin?");
            int myPin = Convert.ToInt32(Console.ReadLine());

            List<string> people = new List<string>();

            obj2.Name = "Aaron Lopez";
            obj2.Name = "Bob Smith";
          
            IQuittable obj1 = new Employee<string>();
            Employee<string> obj = new Employee<string>();
            Employee<int> value = new Employee<int>();
            obj.Things.Add("Car");
            obj.Things.Add("Window");
            obj.Things.Add("Mug");
            value.Things.Add(25000);
            value.Things.Add(300);
            value.Things.Add(10);


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
            //Generics Assignment

            //String items
            
         
            foreach (string item in obj5.Things)
            {
                Console.WriteLine(item);
            }
            foreach(int item in values.Things)
            {
                Console.WriteLine(item);
            }





            obj.SayName();
            obj.Quit();
            Console.Read();
        }
    }
}
