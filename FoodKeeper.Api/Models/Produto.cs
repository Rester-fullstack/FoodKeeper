namespace FoodKeeper.Api.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataValidade { get; set; }
       

        // Relacionamento
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
