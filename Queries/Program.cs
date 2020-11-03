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

            //way 1
            //var courses = context.Courses.Include("Author").ToList();
            //this is going to join Course and Author
            //problem is Author name is renamed to other then this code is going to break

            //way 2
            var courses = context.Courses.Include(c=>c.Author).ToList();
            //way 2 solves the problem of way 1


            foreach (var course in courses)
                Console.WriteLine(course.Name+" by "+course.Author.Name);



            Console.ReadLine();
        }
    }
}
