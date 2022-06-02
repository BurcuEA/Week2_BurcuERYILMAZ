using EFCoreCRUD.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreCRUD.DataAccess
{
    public class DataBaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LENOVO\\SQLEXPRESS; Database=ProductDB;Integrated Security=true;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
