using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAndImprovedAbstractAssignment
{
     class Person
    {
        List<Person> Persons { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        

        public virtual void SayName()
        {

        }
      
    }
}
