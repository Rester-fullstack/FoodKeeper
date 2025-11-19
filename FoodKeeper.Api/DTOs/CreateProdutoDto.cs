namespace FoodKeeper.Api.Dtos
{
    public class CreateProdutoDto
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataValidade { get; set; }
        public string Categoria { get; set; } = string.Empty;
    }
}
