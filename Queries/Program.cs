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
           
            //get the course with ID==6
            var course = context.Courses.Find(6);

            //delete the course
            context.Courses.Remove(course);
            

            //now make the changes into the database
            context.SaveChanges();

            Console.ReadLine();
        }
    }
}
