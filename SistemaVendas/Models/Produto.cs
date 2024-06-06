namespace SistemaVendas.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string? TituloProduto { get; set; }
        public string? DescricaoProduto { get; set; }
        public int AvaliacaoProduto { get; set; }
        public double PrecoProduto { get; set; }
        public Boolean statusEntrega { get; set; }
        public Boolean ExibirAnuncio { get; set; }
        public string? UrlImagem { get; set; }
    }
}
