using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Employee :Person, IQuittable
    {
        
        public override void SayName()
        {
            base.SayName();
            Console.WriteLine(firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + ": I don't like working here anymore");
        }

        
    }
}
