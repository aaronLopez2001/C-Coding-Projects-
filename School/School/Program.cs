using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Aaron" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
          
        }
    }
}
