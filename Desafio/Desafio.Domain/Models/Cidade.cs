using Desafio.Domain.Interfaces;

namespace Desafio.Domain.Models
{
    public class Cidade : IIdentityEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
    }
}
