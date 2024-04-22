using Microsoft.EntityFrameworkCore;
using WebSitesi.Models.Entities;

/*CodeFirst yaklaşımını test etme amaçlı kodlar. Projenin son halinde bir işlevleri yok.*/

namespace WebSitesi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<House> Houses { get; set; }
        public DbSet<Resident> Residents { get; set; }
    }
}
