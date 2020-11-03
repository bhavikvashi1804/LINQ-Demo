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


            var author = context.Authors.Single(a=>a.Id==1);
            //way 1 MSDN way
            //this only works for single Entity
            //here we have only one author object
            //if author contains list of authors then this is going to break
            context.Entry(author).Collection(a => a.Courses).Load();
            //way 1 with filter
            context.Entry(author).Collection(a => a.Courses).Query().Where(c=>c.FullPrice>50).Load();


            //way 2 Mosy Way
            context.Courses.Where(c => c.AuthorId == author.Id).Load();
            //way 2 with Filer
            context.Courses.Where(c => c.AuthorId == author.Id && c.FullPrice >50).Load();


            foreach (var course in author.Courses)
                Console.WriteLine(course.Name);




            Console.ReadLine();
        }
    }
}
