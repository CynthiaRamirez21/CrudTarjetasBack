using BKTarjeta.Models;
using Microsoft.EntityFrameworkCore;

namespace BKTarjeta
{
    public class AplicationDbContext : DbContext
    {
       public DbSet<TarjetaCredito> TarjetaCredito { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

    }
}
