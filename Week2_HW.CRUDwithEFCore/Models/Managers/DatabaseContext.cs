using Microsoft.EntityFrameworkCore;

namespace Week2_HW.CRUDwithEFCore.Models.Managers
{
    public class DatabaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LENOVO\\SQLEXPRESS; Database=ProductDB;Integrated Security=true;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
