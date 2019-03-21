using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new PersonDB())
            {
                db.Blogs.Add(new Person { Name = "Ali" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var person in db.Blogs)
                {
                    Console.WriteLine("{0} - {1}", person.Id, person.Name);
                }
            }
        }
    }
}
