using Desafio.Domain.Interfaces;

namespace Desafio.Repository.Interfaces
{
    public interface IRepositoryBase<TEntidade> : IDisposable where TEntidade : class, IIdentityEntity
    {
        Task<TEntidade> AddAsync(TEntidade obj);
        Task<TEntidade> GetByIdAsync(object id);
        Task<IEnumerable<TEntidade>> GetAllAsync();
        Task<int> UpdateAsync(TEntidade obj);
        Task<bool> RemoveAsync(object id);
        Task<int> RemoveAsync(TEntidade obj);
    }
}
