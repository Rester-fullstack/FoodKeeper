namespace FoodKeeper.Api.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        // Relacionamento 1:N → Uma categoria tem muitos produtos
        public List<Produto>? Produtos { get; set; }
    }
}
