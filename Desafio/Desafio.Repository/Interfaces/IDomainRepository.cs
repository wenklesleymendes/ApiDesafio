using Desafio.Domain.Interfaces;

namespace Desafio.Repository.Interfaces
{
    public interface IDomainRepository<TEntidade> : IRepositoryBase<TEntidade> where TEntidade : class, IIdentityEntity
    {
    }
}
