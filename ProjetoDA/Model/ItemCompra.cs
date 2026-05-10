namespace ProjetoDA.Model
{
    public class ItemCompra
    {
        public int Id { get; set; }
        public int CompraId { get; set; }
        public int ArtigoId { get; set; }
        public decimal QuantidadeAdquirida { get; set; }
        public decimal PrecoUnitario { get; set; }

        public Compra Compra { get; set; }
        public Artigo Artigo { get; set; }
        public ItemPrevisto ItemPrevisto { get; set; }
        public ItemNaoPrevisto ItemNaoPrevisto { get; set; }
    }
}
