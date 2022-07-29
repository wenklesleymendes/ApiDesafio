using Desafio.Domain.Interfaces;

namespace Desafio.Domain.Models
{
    public class Cliente : IIdentityEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Id_Cidade { get; set; }
        public string Apelido { get; set; }
        public DateTime Data_Nascimento { get; set; }
    }
}
