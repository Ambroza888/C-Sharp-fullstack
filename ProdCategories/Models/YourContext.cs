using Microsoft.EntityFrameworkCore;

namespace ProdCategories.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products {get;set;}
        public DbSet<Catergory> Catergories {get;set;}
        public DbSet<Association> Associations {get;set;}
	// "public DbSet<User>Users {get;set;}
	// "public DbSet<User>Users {get;set;}
	// "public DbSet<User>Users {get;set;} etc.
    }
}