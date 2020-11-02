using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            //LINQ Syntax
            var query = from c
                        in context.Courses
                        where c.Name.Contains("C#")
                        orderby c.Name
                        select c;

            foreach(Course c in query)
            {
                Console.WriteLine(c.Name);
            }

            //Extension Method
            var courses = context.Courses.Where(c=>c.Name.Contains("C#")).OrderBy(c=>c.Name);
            foreach (Course course in courses)
            {
                Console.WriteLine(course.Name);
            }


            Console.ReadLine();
        }
    }
}
