using Microsoft.EntityFrameworkCore;
using Proje_OOP_01.Entity;

namespace Proje_OOP_01.ProjeContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BT\\SQLEXPRESS;database=DbNewOoPCore;integrated security=true;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
