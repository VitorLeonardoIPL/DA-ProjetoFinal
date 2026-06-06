namespace ProjetoDA.Model
{
    public class ItemNaoPrevisto
    {
        public int Id { get; set; }
        public string Observacoes { get; set; }

        public ItemCompra ItemCompra { get; set; }
    }
}
