using Desafio.Domain.Models;

namespace Desafio.Service.Interfaces
{
    public interface ICidadeService
    {
        Task<string> Cadastrar(Cidade model);
        Task<string> Alterar(int id, string nome);
        Task<string> BuscarPorNome(string nome);
        Task<string> Excluir(int id);
    }
}
