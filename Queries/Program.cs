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

            var author = new Author
            {
                Id = 1,
                Name = "Mosh Hamedani"
            };

            var context = new PlutoContext();
            context.Authors.Attach(author);

            //create a new course
            var course = new Course {
                Name = "Flutter Course 4",
                Description = "flutter.dev",
                FullPrice = 120,
                Level = 1,
                Author = author
            };

            //add to the context it saves in local memory
            context.Courses.Add(course);
           

            //now make the changes into the database
            context.SaveChanges();

            Console.ReadLine();
        }
    }
}
