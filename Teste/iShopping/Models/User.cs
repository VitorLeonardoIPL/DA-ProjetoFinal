using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iShopping.Models
{
    /// <summary>
    /// Representa um utilizador do sistema.
    /// Cada utilizador tem username único e password.
    /// </summary>
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O username é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O username não pode ter mais de 50 caracteres.")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "A password é obrigatória.")]
        [MaxLength(100, ErrorMessage = "A password não pode ter mais de 100 caracteres.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        // Relações: um utilizador pode criar vários registos
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<ShoppingList> ShoppingLists { get; set; }
    }
}
