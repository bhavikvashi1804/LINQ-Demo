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

            //all authors
            var authors = context.Authors.ToList();
            //author with ID == 1
            var author = context.Authors.SingleOrDefault(a => a.Id == 1);

            //create a new course
            var course = new Course {
                Name = "Flutter Course 2",
                Description = "flutter.dev",
                FullPrice = 120,
                Level = 1,
                Author = author
            };

            context.Courses.Add(course);
            //add to the context it saves in local memory

            //now make the changes into the database
            context.SaveChanges();

            Console.ReadLine();
        }
    }
}
