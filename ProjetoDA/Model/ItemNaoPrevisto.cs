namespace ProjetoDA.Model
{
    public class ItemNaoPrevisto
    {
        public int Id { get; set; }
        public int ArtigoId { get; set; }
        public decimal QuantidadeAdquirida { get; set; }

        public Artigo Artigo { get; set; }
        public ItemCompra ItemCompra { get; set; }
    }
}
