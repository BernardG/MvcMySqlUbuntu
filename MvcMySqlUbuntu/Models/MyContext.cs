using System.Data.Entity;

namespace MvcMySqlUbuntu.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
       public DbSet<Phone> Phones { get; set; }        
    }    
}