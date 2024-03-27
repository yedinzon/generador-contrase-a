using Microsoft.EntityFrameworkCore;
using Servicio_generador.Models;


namespace Servicio_generador.Data
{
    public class GeneradorContext : DbContext
    {
        public GeneradorContext()
        {

        }
        public GeneradorContext(DbContextOptions<GeneradorContext> options) : base(options) { } 

        public DbSet<Password> Password { get; set; }
    }
}
