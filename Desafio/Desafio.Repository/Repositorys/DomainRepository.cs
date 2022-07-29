using Desafio.Domain.Interfaces;
using Desafio.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Desafio.Repository.Repositorys
{
    public class DomainRepository<TEntidade> : RepositoryBase<TEntidade>, IDomainRepository<TEntidade> where TEntidade : class, IIdentityEntity
    {
        protected DomainRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
