using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {

            //get the context
            var context = new PlutoContext();
           
            //get the course with ID==4
            var course = context.Courses.Find(4);
            
            //update the course
            course.Name = "JS Course";
            course.AuthorId = 1;
            

            //now make the changes into the database
            context.SaveChanges();

            Console.ReadLine();
        }
    }
}
