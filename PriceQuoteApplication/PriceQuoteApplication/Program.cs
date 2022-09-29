using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceQuoteApplication
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Whelcome to Package Express. Please follow the instruction below.");
            Console.WriteLine("How heavy is the package that you are sending?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("What is the package width?");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the package height?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the package length?");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            if (packageWidth > 50 && packageHeight > 50 && packageLength > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express");
                Console.ReadLine();
                return;
            }

            int packageDimension = packageWidth * packageLength * packageHeight;
            int priceQuote = packageDimension / 100;
            decimal priceQdec = Convert.ToDecimal(priceQuote);
            Console.WriteLine($"Your estimated total for shipping this package is: ${priceQdec}");
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
