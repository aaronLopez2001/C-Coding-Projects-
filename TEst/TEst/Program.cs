using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEst
{
    enum DayOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What day is it today?");
                string todayDate = Console.ReadLine();
                DayOfTheWeek getParse;
                bool checkParse = Enum.TryParse(todayDate, out getParse);
                Console.WriteLine(getParse);
                Console.WriteLine(checkParse);
                

                if(checkParse == false)
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }
                Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

        

            
        }
    }
}
