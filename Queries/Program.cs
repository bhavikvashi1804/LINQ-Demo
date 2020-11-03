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


            //add a new object
            context.Authors.Add(new Author { 
                Name="Bhavik Vashi"
            });


            //update the object
            var author1 = context.Authors.Find(3);
            author1.Name = "Bhavik Vashi";


            //remove the object
            var author2 = context.Authors.Find(4);
            context.Authors.Remove(author2);

            var entries = context.ChangeTracker.Entries<Author>();

            foreach(var entry in entries)
            {
                entry.Reload();
                Console.WriteLine(entry.State);

            }
               

            Console.ReadLine();
        }
    }
}
