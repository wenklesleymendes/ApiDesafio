using Desafio.Domain.Models;
using Desafio.Repository.Interfaces;
using Desafio.Service.Interfaces;
using System.Text.Json;

namespace Desafio.Service.Services
{
    public class CidadeService : ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;

        public CidadeService(ICidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

        public async Task<string> Cadastrar(Cidade cidade)
        {
            await _cidadeRepository.AddAsync(cidade);

            return $"\"Sucesso\":1,\"Mensagem\":\"Cadastrado com sucesso\"";
        }

        public async Task<string> Alterar(int id, string nome)
        {
            var cidade = await _cidadeRepository.GetByIdAsync(id);

            if (cidade is null)
                return $"\"Sucesso\":0,\"Mensagem\":\"Cidade não encontrada.\"";

            if (nome != null)
            {
                cidade.Nome = nome;
            }

            await _cidadeRepository.UpdateAsync(cidade);

            return $"\"Sucesso\":1,\"Mensagem\":\"Alterado com sucesso.\"";
        }

        public async Task<string> BuscarPorNome(string nome)
        {
            var cidades = await _cidadeRepository.GetAllAsync();

            if (!cidades.Any())
                return $"\"Sucesso\":0,\"Mensagem\":\"Cidade não encontrada.\"";

            var cidadesSelecionadas = cidades.Where(c => c.Nome.Contains(nome));

            var json = JsonSerializer.Serialize(cidadesSelecionadas);

            return $"\"Sucesso\":1,\"Mensagem\":\"Retorno com sucesso\",\"Data\":{json}";
        }

        public async Task<string> Excluir(int id)
        {
            var retorno = await _cidadeRepository.RemoveAsync(id);

            if (retorno)
            {
                return $"\"Sucesso\":1,\"Mensagem\":\"Excluido com sucesso\"";
            }
            else
            {
                return $"\"Sucesso\":0,\"Mensagem\":\"Cidade não Encontrada.\"";
            }
        }
    }
}
