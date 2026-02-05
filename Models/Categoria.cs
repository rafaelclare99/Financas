namespace Teste.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Descricao { get; set; } = null!;

        public FinalidadeCategoria Finalidade { get; set; }
    }
}
