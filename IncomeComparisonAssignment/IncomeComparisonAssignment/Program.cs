using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            //Person 1
            Console.WriteLine("Employee 1 please fill up the following data!");
            Console.WriteLine("Hourly Rate: ");
            string hourlyrate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week: ");
            string hrsworkedperweek1 = Console.ReadLine();
            Console.ReadLine();

            double hrlyrate1double = Convert.ToDouble(hourlyrate1);
            double hrsworkedperweek1double = Convert.ToDouble(hrsworkedperweek1);
            double annualsalary1 = hrlyrate1double * hrsworkedperweek1double * 52;

            

            //Person 2 
            Console.WriteLine("Employee 2 please fill up the following data!");
            Console.WriteLine("Hourly Rate: ");
            string hourlyrate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week: ");
            string hrsworkedperweek2 = Console.ReadLine();
            Console.ReadLine();

            double hrlyrate2double = Convert.ToDouble(hourlyrate2);
            double hrsworkedperweek2double = Convert.ToDouble(hrsworkedperweek2);
            double annualsalary2 = hrlyrate2double * hrsworkedperweek2double * 52;


            //Boolean
            bool compare = annualsalary1 > annualsalary2;

            Console.WriteLine("Annual salary of Person 1: $" + annualsalary1);
            Console.WriteLine("Annual salary of Person 2: $" + annualsalary2);
            Console.WriteLine("Person 1 makes more money than Person 2");
            Console.WriteLine(compare);
            Console.ReadLine();

            




        }
    }
}
