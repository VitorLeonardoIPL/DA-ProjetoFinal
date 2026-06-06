using System;
using System.Data.Entity;
using System.Linq;

namespace ProjetoDA.Model
{
    internal class AppDbInitializer : DropCreateDatabaseIfModelChanges<ProjetoDAContext>
    {
        protected override void Seed(ProjetoDAContext context)
        {
            // --- Utilizadores ---
            var admin = context.Utilizadores.Add(new Utilizador
            {
                Username = "admin",
                Email = "admin@ipl.pt",
                Password = "admin123",
                DataCriacao = DateTime.Now
            });
            var user1 = context.Utilizadores.Add(new Utilizador
            {
                Username = "ana",
                Email = "ana@ipl.pt",
                Password = "ana123",
                DataCriacao = DateTime.Now
            });
            context.SaveChanges();

            // --- Tipos de Artigo ---
            var tipoMercearia = context.TiposArtigo.Add(new TipoArtigo { Nome = "Mercearia" });
            var tipoLaticinios = context.TiposArtigo.Add(new TipoArtigo { Nome = "Laticínios" });
            var tipoBebidas = context.TiposArtigo.Add(new TipoArtigo { Nome = "Bebidas" });
            var tipoHigiene = context.TiposArtigo.Add(new TipoArtigo { Nome = "Higiene" });
            var tipoLimpeza = context.TiposArtigo.Add(new TipoArtigo { Nome = "Limpeza" });
            context.SaveChanges();

            // --- Artigos ---
            context.Artigos.Add(new Artigo { Nome = "Arroz", Preco = 1.29, DataCriacao = DateTime.Now, TipoArtigoId = tipoMercearia.Id });
            context.Artigos.Add(new Artigo { Nome = "Massa", Preco = 0.89, DataCriacao = DateTime.Now, TipoArtigoId = tipoMercearia.Id });
            context.Artigos.Add(new Artigo { Nome = "Azeite", Preco = 4.50, DataCriacao = DateTime.Now, TipoArtigoId = tipoMercearia.Id });
            context.Artigos.Add(new Artigo { Nome = "Leite", Preco = 0.99, DataCriacao = DateTime.Now, TipoArtigoId = tipoLaticinios.Id });
            context.Artigos.Add(new Artigo { Nome = "Queijo", Preco = 3.20, DataCriacao = DateTime.Now, TipoArtigoId = tipoLaticinios.Id });
            context.Artigos.Add(new Artigo { Nome = "Iogurte", Preco = 2.50, DataCriacao = DateTime.Now, TipoArtigoId = tipoLaticinios.Id });
            context.Artigos.Add(new Artigo { Nome = "Água", Preco = 1.10, DataCriacao = DateTime.Now, TipoArtigoId = tipoBebidas.Id });
            context.Artigos.Add(new Artigo { Nome = "Sumo", Preco = 1.80, DataCriacao = DateTime.Now, TipoArtigoId = tipoBebidas.Id });
            context.Artigos.Add(new Artigo { Nome = "Refrigerante", Preco = 1.50, DataCriacao = DateTime.Now, TipoArtigoId = tipoBebidas.Id });
            context.Artigos.Add(new Artigo { Nome = "Sabonete", Preco = 1.20, DataCriacao = DateTime.Now, TipoArtigoId = tipoHigiene.Id });
            context.Artigos.Add(new Artigo { Nome = "Shampoo", Preco = 3.00, DataCriacao = DateTime.Now, TipoArtigoId = tipoHigiene.Id });
            context.Artigos.Add(new Artigo { Nome = "Pasta Dentes", Preco = 2.00, DataCriacao = DateTime.Now, TipoArtigoId = tipoHigiene.Id });
            context.Artigos.Add(new Artigo { Nome = "Detergente", Preco = 2.80, DataCriacao = DateTime.Now, TipoArtigoId = tipoLimpeza.Id });
            context.Artigos.Add(new Artigo { Nome = "Lixívia", Preco = 1.60, DataCriacao = DateTime.Now, TipoArtigoId = tipoLimpeza.Id });
            context.Artigos.Add(new Artigo { Nome = "Esponja", Preco = 0.75, DataCriacao = DateTime.Now, TipoArtigoId = tipoLimpeza.Id });
            context.SaveChanges();

            // --- Orcamentos ---
            context.Orcamentos.Add(new Orcamento { Nome = "Orçamento Maio", Valor = 300, DataInicio = new DateTime(2026, 5, 1), DataFim = new DateTime(2026, 5, 31), UtilizadorCriadoId = admin.Id });
            context.Orcamentos.Add(new Orcamento { Nome = "Orçamento Junho", Valor = 350, DataInicio = new DateTime(2026, 6, 1), DataFim = new DateTime(2026, 6, 30), UtilizadorCriadoId = admin.Id });
            context.Orcamentos.Add(new Orcamento { Nome = "Orçamento Julho", Valor = 400, DataInicio = new DateTime(2026, 7, 1), DataFim = new DateTime(2026, 7, 31), UtilizadorCriadoId = admin.Id });
            context.SaveChanges();

            // --- Compras (2 fechadas + 2 abertas) ---
            var compra1 = context.Compras.Add(new Compra
            {
                Nome = "Compras Maio Semana 1",
                Descricao = "Compras da primeira semana",
                Fechada = true,
                DataCriacao = new DateTime(2026, 5, 4),
                DataFechada = new DateTime(2026, 5, 4),
                UtilizadorCriadoId = admin.Id,
                UtilizadorFechouId = admin.Id
            });
            var compra2 = context.Compras.Add(new Compra
            {
                Nome = "Compras Maio Semana 2",
                Descricao = "Compras da segunda semana",
                Fechada = true,
                DataCriacao = new DateTime(2026, 5, 11),
                DataFechada = new DateTime(2026, 5, 11),
                UtilizadorCriadoId = admin.Id,
                UtilizadorFechouId = admin.Id
            });
            var compra3 = context.Compras.Add(new Compra
            {
                Nome = "Lista para esta semana",
                Descricao = "Compras ainda em aberto",
                Fechada = false,
                DataCriacao = DateTime.Now,
                UtilizadorCriadoId = admin.Id
            });
            var compra4 = context.Compras.Add(new Compra
            {
                Nome = "Compras de fim de semana",
                Descricao = "Para o churrasco",
                Fechada = false,
                DataCriacao = DateTime.Now,
                UtilizadorCriadoId = user1.Id
            });
            context.SaveChanges();

            // ---- Itens da Compra 1 (Arroz, Leite, Água) ----
            var item1 = context.ItensCompra.Add(new ItemCompra
            {
                CompraId = compra1.Id,
                ArtigoId = 1, // Arroz
                QuantidadeAdquirida = 2,
                PrecoUnitario = 1.29m
            });
            context.SaveChanges();
            context.ItensPrevisto.Add(new ItemPrevisto { Id = item1.Id, ArtigoId = 1, QuantidadePrevista = 2 });
            context.SaveChanges();

            var item2 = context.ItensCompra.Add(new ItemCompra
            {
                CompraId = compra1.Id,
                ArtigoId = 4, // Leite
                QuantidadeAdquirida = 3,
                PrecoUnitario = 0.99m
            });
            context.SaveChanges();
            context.ItensPrevisto.Add(new ItemPrevisto { Id = item2.Id, ArtigoId = 4, QuantidadePrevista = 3 });
            context.SaveChanges();

            var item3 = context.ItensCompra.Add(new ItemCompra
            {
                CompraId = compra1.Id,
                ArtigoId = 7, // Água
                QuantidadeAdquirida = 6,
                PrecoUnitario = 1.10m
            });
            context.SaveChanges();
            context.ItensNaoPrevisto.Add(new ItemNaoPrevisto { Id = item3.Id, ArtigoId = 7, QuantidadeAdquirida = 6 });
            context.SaveChanges();

            // ---- Itens da Compra 3 (em aberto, previstos) ----
            var item4 = context.ItensCompra.Add(new ItemCompra
            {
                CompraId = compra3.Id,
                ArtigoId = 5, // Queijo
                QuantidadeAdquirida = 0,
                PrecoUnitario = 0
            });
            context.SaveChanges();
            context.ItensPrevisto.Add(new ItemPrevisto { Id = item4.Id, ArtigoId = 5, QuantidadePrevista = 1 });
            context.SaveChanges();

            var item5 = context.ItensCompra.Add(new ItemCompra
            {
                CompraId = compra3.Id,
                ArtigoId = 3, // Azeite
                QuantidadeAdquirida = 0,
                PrecoUnitario = 0
            });
            context.SaveChanges();
            context.ItensPrevisto.Add(new ItemPrevisto { Id = item5.Id, ArtigoId = 3, QuantidadePrevista = 1 });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
