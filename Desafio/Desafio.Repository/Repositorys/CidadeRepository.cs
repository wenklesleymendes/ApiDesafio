using Desafio.Domain.Models;
using Desafio.Repository.Interfaces;

namespace Desafio.Repository.Repositorys
{
    public class CidadeRepository : DomainRepository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
