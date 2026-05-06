using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iShopping.Models
{
    /// <summary>
    /// Representa um item NÃO previsto adicionado durante a compra.
    /// Exemplo: Durante a compra, o utilizador decide comprar algo que não estava na lista.
    /// Este item é registado diretamente como adquirido.
    /// </summary>
    public class UnplannedItem
    {
        [Key]
        public int Id { get; set; }

        // Chave estrangeira para a lista de compras
        [Required]
        public int ShoppingListId { get; set; }

        [ForeignKey("ShoppingListId")]
        public virtual ShoppingList ShoppingList { get; set; }

        // Nome do artigo não previsto (escrito manualmente pelo utilizador)
        [Required(ErrorMessage = "O nome do artigo é obrigatório.")]
        [MaxLength(150, ErrorMessage = "O nome não pode ter mais de 150 caracteres.")]
        [Display(Name = "Nome do Artigo")]
        public string ArticleName { get; set; }

        // Observações sobre o item
        [MaxLength(300, ErrorMessage = "A observação não pode ter mais de 300 caracteres.")]
        [Display(Name = "Observações")]
        public string Observations { get; set; }

        // Quantidade adquirida
        [Required(ErrorMessage = "A quantidade é obrigatória.")]
        [Range(1, 999, ErrorMessage = "A quantidade deve ser entre 1 e 999.")]
        [Display(Name = "Quantidade")]
        public int Quantity { get; set; }

        // Preço unitário pago
        [Required(ErrorMessage = "O preço unitário é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser superior a 0.")]
        [Display(Name = "Preço Unitário (€)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
    }
}
