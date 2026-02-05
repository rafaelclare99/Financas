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
        public Pessoa Pessoa { get; set; } = null!;

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } = null!;

    }
}
