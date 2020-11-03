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
            
            
            var context = new PlutoContext();

            //create a new course
            var course = new Course {
                Name = "Flutter Course 3",
                Description = "flutter.dev",
                FullPrice = 120,
                Level = 1,
                AuthorId = 1
            };

            //add to the context it saves in local memory
            context.Courses.Add(course);
           

            //now make the changes into the database
            context.SaveChanges();

            Console.ReadLine();
        }
    }
}
