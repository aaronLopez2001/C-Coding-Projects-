using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File_IO_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints out the current date and time 

            DateTime present = DateTime.Now;
            Console.WriteLine("Date: "+ present);
            Console.WriteLine("Please write a number");
            int answer = Convert.ToInt32(Console.ReadLine());
            string answerToString = Convert.ToString(answer);
            string answr = string.Format(answerToString);
            using (StreamWriter file = new StreamWriter(@"C:\Users\azehu\OneDrive\Desktop\FileWriteAllText\assignment.txt", false))
            {
                file.Write(answr);
            }
           
            Console.WriteLine(present.AddHours(answer));
            Console.WriteLine(answr);
            Console.Read();
            

        }
    }
}
