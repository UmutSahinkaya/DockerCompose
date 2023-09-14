using Microsoft.EntityFrameworkCore;

namespace MicroService1.API.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions opt):base(opt)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
