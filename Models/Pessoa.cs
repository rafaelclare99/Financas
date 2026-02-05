using System.ComponentModel.DataAnnotations;

namespace Teste.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Nome { get; set; }

        [Required]
        public  int idade { get; set; }

        public ICollection<Transacao> Transacoes { get; set; } = new List<Transacao>();
    }
}
