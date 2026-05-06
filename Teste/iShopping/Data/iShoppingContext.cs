using System.Data.Entity;
using iShopping.Models;

namespace iShopping.Data
{
    /// <summary>
    /// DbContext é a classe principal do Entity Framework.
    /// Funciona como uma "ponte" entre as nossas classes (Models) e a base de dados SQL Server.
    /// Cada DbSet representa uma tabela na base de dados.
    /// </summary>
    public class iShoppingContext : DbContext
    {
        // O construtor usa a connection string definida no App.config
        // "name=iShoppingContext" indica qual a connection string a usar
        public iShoppingContext() : base("name=iShoppingContext")
        {
            // Se o modelo mudar (ex: adicionamos uma coluna), o EF recria a BD automaticamente.
            // Útil durante o desenvolvimento para evitar erros de "modelo mudou".
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<iShoppingContext>());
        }

        // Cada DbSet<> representa uma tabela na base de dados
        // O Entity Framework cria automaticamente estas tabelas

        /// <summary>
        /// Tabela de Utilizadores
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Tabela de Tipos de Artigo
        /// </summary>
        public DbSet<ArticleType> ArticleTypes { get; set; }

        /// <summary>
        /// Tabela de Artigos
        /// </summary>
        public DbSet<Article> Articles { get; set; }

        /// <summary>
        /// Tabela de Orçamentos Mensais
        /// </summary>
        public DbSet<Budget> Budgets { get; set; }

        /// <summary>
        /// Tabela de Listas de Compras
        /// </summary>
        public DbSet<ShoppingList> ShoppingLists { get; set; }

        /// <summary>
        /// Tabela de Itens Previstos nas Compras
        /// </summary>
        public DbSet<ShoppingItem> ShoppingItems { get; set; }

        /// <summary>
        /// Tabela de Itens Não Previstos nas Compras
        /// </summary>
        public DbSet<UnplannedItem> UnplannedItems { get; set; }

        /// <summary>
        /// OnModelCreating é chamado quando o modelo é criado.
        /// Aqui podemos configurar regras adicionais para a base de dados.
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar o nome único para o Username (não pode haver dois utilizadores com o mesmo username)
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            // Configurar nomes das tabelas (opcional, mas torna a BD mais clara)
            modelBuilder.Entity<ArticleType>().ToTable("ArticleTypes");
            modelBuilder.Entity<Article>().ToTable("Articles");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Budget>().ToTable("Budgets");
            modelBuilder.Entity<ShoppingList>().ToTable("ShoppingLists");
            modelBuilder.Entity<ShoppingItem>().ToTable("ShoppingItems");
            modelBuilder.Entity<UnplannedItem>().ToTable("UnplannedItems");
        }
    }
}
