using Desafio.Domain.Models;
using Desafio.Repository.Interfaces;

namespace Desafio.Repository.Repositorys
{
    public class ClienteRepository : DomainRepository<Cliente> , IClienteRepository
    {
        public ClienteRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
