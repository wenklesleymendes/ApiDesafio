using Desafio.Domain.Models;

namespace Desafio.Service.Interfaces
{
    public interface IClienteService
    {
        Task<string> Inserir(Cliente model);
        Task<string> Alterar(int id, DtoCliente dadosCliente);
        Task<string> BuscarPorNome(string nome);
        Task<string> Excluir(int id);
    }
}
