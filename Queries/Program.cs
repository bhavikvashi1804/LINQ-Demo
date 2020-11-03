using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            
            var course = context.Courses.Single(c => c.Id == 2);
            //there are 3 query to the DB
            //1: course with id =2
            //2: author for that course
            //3: tags for that course
            //and this is called as Lazy Loading


            foreach(var tag in course.Tags)
                Console.WriteLine(tag.Name);



            Console.ReadLine();
        }
    }
}
