using Microsoft.EntityFrameworkCore;

namespace DesafioReval.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>options) : base (options)
        {

        }

        public DbSet<ClienteModel> Cliente { get; set; }

    }
}
