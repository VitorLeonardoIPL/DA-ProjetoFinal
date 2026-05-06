using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iShopping.Models
{
    /// <summary>
    /// Representa uma lista de compras planeada.
    /// Pode estar "Aberta" (ainda a decorrer) ou "Fechada" (compra terminada).
    /// </summary>
    public class ShoppingList
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da compra é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
        [Display(Name = "Nome da Compra")]
        public string Name { get; set; }

        [MaxLength(500, ErrorMessage = "A descrição não pode ter mais de 500 caracteres.")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        // Estado da compra: true = Aberta, false = Fechada
        [Display(Name = "Estado (Aberta)")]
        public bool IsOpen { get; set; } = true;

        // Datas
        [Display(Name = "Data de Criação")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Data de Fecho")]
        public DateTime? ClosedAt { get; set; }

        // Chave estrangeira para o utilizador que criou
        [Required]
        [Display(Name = "Utilizador Criador")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        // Chave estrangeira para o utilizador que fechou (pode ser diferente)
        [Display(Name = "Utilizador que Fechou")]
        public int? ClosedByUserId { get; set; }

        [ForeignKey("ClosedByUserId")]
        public virtual User ClosedByUser { get; set; }

        // Relações: uma compra tem vários itens previstos e vários itens não previstos
        public virtual ICollection<ShoppingItem> Items { get; set; }
        public virtual ICollection<UnplannedItem> UnplannedItems { get; set; }
    }
}
