using System;
using System.Configuration;

namespace DailyReportAolcc
{
    class Program
    {
        
        static void Main()
        {

            string logo = @"                        _                               __   _                           _                _____                                 _____      _ _                 
     /\                | |                             / _| | |                         (_)              / ____|                               / ____|    | | |                
    /  \   ___ __ _  __| | ___ _ __ ___  _   _    ___ | |_  | |     ___  __ _ _ __ _ __  _ _ __   __ _  | |     __ _ _ __ _ __ ___  ___ _ __  | |     ___ | | | ___  __ _  ___ 
   / /\ \ / __/ _` |/ _` |/ _ \ '_ ` _ \| | | |  / _ \|  _| | |    / _ \/ _` | '__| '_ \| | '_ \ / _` | | |    / _` | '__| '__/ _ \/ _ \ '__| | |    / _ \| | |/ _ \/ _` |/ _ \
  / ____ \ (_| (_| | (_| |  __/ | | | | | |_| | | (_) | |   | |___|  __/ (_| | |  | | | | | | | | (_| | | |___| (_| | |  | | |  __/  __/ |    | |___| (_) | | |  __/ (_| |  __/
 /_/    \_\___\__,_|\__,_|\___|_| |_| |_|\__, |  \___/|_|   |______\___|\__,_|_|  |_| |_|_|_| |_|\__, |  \_____\__,_|_|  |_|  \___|\___|_|     \_____\___/|_|_|\___|\__, |\___|
                                          __/ |                                                   __/ |                                                              __/ |     
                                         |___/                                                   |___/                                                              |___/      ";
            Console.WriteLine(logo);
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you in?");
            string studentCourse = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int  number = Convert.ToInt32(pageNumber);
            Console.Clear();
            Console.WriteLine("Do you need any help with anything? Please answer with true or false");
            string myBool = Console.ReadLine();
            bool b = Convert.ToBoolean(myBool);

          





            if (b == true)
            {
                Console.Clear();
                Console.WriteLine("Please Contact our facility");
                Console.WriteLine("Email:admissions@academyoflearning.com");
                Console.WriteLine("Or");
                Console.WriteLine("Phone: 1-333-444-5555");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("Please fill the following data!");
                Console.ReadLine();
            
            };






            //if (choice == 1)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Please Contact our facility");
            //    Console.WriteLine("Email:admissions@academyoflearning.com");
            //    Console.WriteLine("Or");
            //    Console.WriteLine("Phone: 1-333-444-5555");
            //    Console.ReadLine();
            //}
            //else if (choice > 2)
            //{
            //    Console.WriteLine("Please select a valid option!");
            //    Console.ReadLine();
            //}





            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string myExperience = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string myFeedback = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int myHours = Convert.ToInt32(studyHours);
            Console.Clear();

            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day! ");
            Console.WriteLine("Please review your answers in the meantime ");
            Console.WriteLine("You're taking: " + studentCourse);
            Console.WriteLine("Your Experience: " + myExperience);
            Console.WriteLine("Your Feedback: " + myFeedback);
            Console.WriteLine("Hours you have been studying: " + myHours);

            Console.ReadLine();




            
        }
    
    }
}
