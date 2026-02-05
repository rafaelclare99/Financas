using System.ComponentModel.DataAnnotations;

namespace Teste.Models
{
    public class Transacao
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Descricao { get; set; } = null!;

        [Required]
        public decimal Valor { get; set; }

        [Required]
        public TipoTransacao Tipo { get; set; }

        public int PessoaId { get; set; }

        public int CategoriaId { get; set; }


    }
}
