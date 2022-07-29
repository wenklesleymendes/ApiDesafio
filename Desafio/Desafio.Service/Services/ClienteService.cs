using Desafio.Domain.Models;
using Desafio.Repository.Interfaces;
using Desafio.Service.Interfaces;
using System.Text.Json;

namespace Desafio.Service.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<string> Inserir(Cliente model)
        {
            await _clienteRepository.AddAsync(model);

            return $"\"Sucesso\":1,\"Mensagem\":\"Cadastrado com sucesso\"";
        }

        public async Task<string> Alterar(int id, DtoCliente dadosCliente)
        {
            var cliente = await _clienteRepository.GetByIdAsync(id);

            if (cliente == null)
                return $"\"Sucesso\":0,\"Mensagem\":\"Cliente não encontrado.\"";

            if (dadosCliente.Nome != null)
            {
                cliente.Nome = dadosCliente.Nome;
            }
            else if (dadosCliente.Telefone != null)
            {
                cliente.Telefone = dadosCliente.Telefone;
            }
            else
            {
                return $"\"Sucesso\":0,\"Mensagem\":\"Informe um nome ou telefone!\""; ;
            }

            await _clienteRepository.UpdateAsync(cliente);

            return $"\"Sucesso\":1,\"Mensagem\":\"Alterado com sucesso.\"";
        }

        public async Task<string> BuscarPorNome(string nome)
        {
            var clientes = await _clienteRepository.GetAllAsync();

            var clientesSelecionados = clientes.Where(c => c.Nome.Contains(nome));

            if (!clientesSelecionados.Any())
                return $"\"Sucesso\":0,\"Mensagem\":\"Nome não encontrado.\"";

            var json = JsonSerializer.Serialize(clientesSelecionados);

            return $"\"Sucesso\":1,\"Mensagem\":\"Retorno com sucesso.\",\"Dados\":{json}";
        }

        public async Task<string> Excluir(int id)
        {
            var retorno = await _clienteRepository.RemoveAsync(id);

            if (retorno)
            {
                return $"\"Sucesso\":1,\"Mensagem\":\"Excluido com sucesso.\"";
            }
            else
            {
                return $"\"Sucesso\":0,\"Mensagem\":\"Cliente não Encontrado.\"";
            }
        }
    }
}
