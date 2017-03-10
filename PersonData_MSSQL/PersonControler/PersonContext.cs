using System.Data.Entity;
using PersonModel;

namespace PersonControler
{
    public class PersonContext : DbContext
    {
      
        public PersonContext()
            : base("PersonContext")
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}