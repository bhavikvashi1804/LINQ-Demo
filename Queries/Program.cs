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


            Console.ReadLine();
        }
    }
}
