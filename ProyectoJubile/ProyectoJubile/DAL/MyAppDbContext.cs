using Microsoft.EntityFrameworkCore;
using ProyectoJubile.Models;

namespace ProyectoJubile.DAL
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Cliente> Cliente { get; set; } = null!;
    }
}
