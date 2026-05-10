using System.Data.Entity;

namespace ProjetoDA.Model
{
    public class ProjetoDAContext : DbContext
    {
        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<TipoArtigo> TiposArtigo { get; set; }
        public DbSet<Artigo> Artigos { get; set; }
        public DbSet<Orcamento> Orcamentos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<ItemCompra> ItensCompra { get; set; }
        public DbSet<ItemPrevisto> ItensPrevisto { get; set; }
        public DbSet<ItemNaoPrevisto> ItensNaoPrevisto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Compra tem 3 relacoes para Utilizador (cria, fechou, editou)
            // O EF nao consegue descobrir sozinho qual FK corresponde a qual
            modelBuilder.Entity<Compra>()
                .HasRequired(c => c.UtilizadorCriado)
                .WithMany()
                .HasForeignKey(c => c.UtilizadorCriadoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Compra>()
                .HasOptional(c => c.UtilizadorFechou)
                .WithMany()
                .HasForeignKey(c => c.UtilizadorFechouId);

            modelBuilder.Entity<Compra>()
                .HasOptional(c => c.UtilizadorEditou)
                .WithMany()
                .HasForeignKey(c => c.UtilizadorEditouId);

            // Orcamento tem 2 relacoes para Utilizador (criou, editou)
            modelBuilder.Entity<Orcamento>()
                .HasRequired(o => o.UtilizadorCriado)
                .WithMany()
                .HasForeignKey(o => o.UtilizadorCriadoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orcamento>()
                .HasOptional(o => o.UtilizadorEditou)
                .WithMany()
                .HasForeignKey(o => o.UtilizadorEditouId);

            // ItemCompra -> ItemPrevisto: relacao 1 para 0..1
            // ItemPrevisto.Id = FK para ItemCompra.Id (chave partilhada)
            modelBuilder.Entity<ItemPrevisto>()
                .HasRequired(ip => ip.ItemCompra)
                .WithOptional(ic => ic.ItemPrevisto);

            // ItemCompra -> ItemNaoPrevisto: relacao 1 para 0..1
            // ItemNaoPrevisto.Id = FK para ItemCompra.Id (chave partilhada)
            modelBuilder.Entity<ItemNaoPrevisto>()
                .HasRequired(inp => inp.ItemCompra)
                .WithOptional(ic => ic.ItemNaoPrevisto);

            base.OnModelCreating(modelBuilder);
        }
    }
}
