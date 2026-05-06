using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iShopping.Models
{
    /// <summary>
    /// Representa um item previsto numa lista de compras.
    /// Exemplo: Na compra "Supermercado Semanal", prevê-se comprar 2x "Leite Meio-Gordo".
    /// </summary>
    public class ShoppingItem
    {
        [Key]
        public int Id { get; set; }

        // Chave estrangeira para a lista de compras
        [Required]
        public int ShoppingListId { get; set; }

        [ForeignKey("ShoppingListId")]
        public virtual ShoppingList ShoppingList { get; set; }

        // Chave estrangeira para o artigo
        [Required(ErrorMessage = "O artigo é obrigatório.")]
        [Display(Name = "Artigo")]
        public int ArticleId { get; set; }

        [ForeignKey("ArticleId")]
        public virtual Article Article { get; set; }

        // Quantidade planeada
        [Required(ErrorMessage = "A quantidade é obrigatória.")]
        [Range(1, 999, ErrorMessage = "A quantidade deve ser entre 1 e 999.")]
        [Display(Name = "Quantidade Prevista")]
        public int PlannedQuantity { get; set; }

        // Quantidade adquirida (preenchida durante o modo compra)
        [Display(Name = "Quantidade Adquirida")]
        public int? AcquiredQuantity { get; set; }

        // Preço unitário pago (preenchido durante o modo compra)
        [Display(Name = "Preço Unitário (€)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? UnitPrice { get; set; }
    }
}
