namespace ProjetoDA.Model
{
    public class ItemPrevisto
    {
        public int Id { get; set; }
        public int ArtigoId { get; set; }
        public decimal QuantidadePrevista { get; set; }

        public Artigo Artigo { get; set; }
        public ItemCompra ItemCompra { get; set; }
    }
}
