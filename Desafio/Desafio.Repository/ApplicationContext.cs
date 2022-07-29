using Desafio.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Repository
{
    public class ApplicationContext : DbContext
    {     

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cidade> Cidades { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
    }
}
