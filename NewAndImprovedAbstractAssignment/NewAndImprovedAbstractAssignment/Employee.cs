using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAndImprovedAbstractAssignment
{
    class Employee<T> : Person, IQuittable
    {

        public List<T> Things = new List<T>();
        public string Name { get; set; }
        public int id1 { get; set; }
        public int id2 { get; set; }



        public override void SayName()
        {
            Console.WriteLine("Hello my name is " + FirstName + " " + LastName);
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine(FirstName + " "+ LastName + " has quit his job");
        }

        public static bool operator==(Employee<T> emp1, Employee<T> emp2)
        {
            bool status = false;
            if(emp1.id1 == emp2.id2)
            {
                status = true;
            }
            return status;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public static bool operator !=(Employee<T> emp1, Employee<T> emp2)
        {
            bool status = false;
            if (emp1.id1 == emp2.id2)
            {
                status = false;
            }
            return status;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }





    }
}
