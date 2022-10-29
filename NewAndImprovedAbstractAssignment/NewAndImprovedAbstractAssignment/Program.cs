using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace NewAndImprovedAbstractAssignment
{

    class Program
    {
        static void Main(string[] args)
        {
            //Lambda
            Employee<string> workerFirstName = new Employee<string>();
            Employee<string> workerLastName = new Employee<string>();
            Employee<int> workerID = new Employee<int>();
            //Lambda Expression
            //I'm creating 10 employees here.
            //1
            workerFirstName.workers.Add("Joe");
            workerLastName.workers.Add("Smith");
            workerID.workers.Add(1111);
            //2
            workerFirstName.workers.Add("Joe");
            workerLastName.workers.Add("Clarkson");
            workerID.workers.Add(2222);
            //3
            workerFirstName.workers.Add("Erika");
            workerLastName.workers.Add("White");
            workerID.workers.Add(3333);
            //4
            workerFirstName.workers.Add("Harold");
            workerLastName.workers.Add("Lopez");
            workerID.workers.Add(4444);
            //5
            workerFirstName.workers.Add("Aaron");
            workerLastName.workers.Add("Polaski");
            workerID.workers.Add(5555);
            //6
            workerFirstName.workers.Add("Walter");
            workerLastName.workers.Add("Holts");
            workerID.workers.Add(6666);
            //7
            workerFirstName.workers.Add("Amy");
            workerLastName.workers.Add("Santiago");
            workerID.workers.Add(7777);
            //8
            workerFirstName.workers.Add("Jeff");
            workerLastName.workers.Add("Higgins");
            workerID.workers.Add(8888);
            //9
            workerFirstName.workers.Add("Sway");
            workerLastName.workers.Add("Lee");
            workerID.workers.Add(9999);
            //10
            workerFirstName.workers.Add("Jin");
            workerLastName.workers.Add("Miyamoto");
            workerID.workers.Add(1010);
            //foreach loop that searches  for the name "Joe"
            List<string> DuplicatesName = new List<string>();
            

            //

            foreach (string name in workerFirstName.workers)
            {


                if (name == "Joe")
                {
                    DuplicatesName.Add(name);
                }


            }
            foreach (string x in DuplicatesName)
            {
                Console.WriteLine(x);
            }
            //Using lambda Expressions
            List<int> employeeWithIDabove5 = new List<int>();
            workerID.workers.ForEach(x => { if (x > 5) { employeeWithIDabove5.Add(x); } }  );
            employeeWithIDabove5.ForEach(x => { Console.WriteLine(x); });


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
