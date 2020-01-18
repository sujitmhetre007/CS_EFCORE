using System;
using System.Linq;

namespace CS_EFCORE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //ManageDatabase();
                using(var ctx=new Models.PersonDBContext())
                {
                    var p = new Models.PersonInfo() { age = 10, gender = "Male", PersonName = "Mahesh" };
                    ctx.Person.Add(p);
                    ctx.SaveChanges();
                    Console.WriteLine("Added Person");

                    foreach(var p1 in ctx.Person.ToList())
                    { 
                        Console.WriteLine($"{p1.PersonId} {p1.PersonName} {p1.age} {p1.gender}");

                    }



                }

              
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}{ex.InnerException}");
              
            }
            Console.ReadLine();

        }

        public static void ManageDatabase()
        {
            using(var ctx =new Models.PersonDBContext())
            {
                ctx.Database.EnsureDeleted();
                ctx.Database.EnsureCreated();
            }
        }
    }
}
