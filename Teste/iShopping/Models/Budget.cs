using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iShopping.Models
{
    /// <summary>
    /// Representa o orçamento mensal de um utilizador.
    /// Cada utilizador pode ter um orçamento por mês.
    /// </summary>
    public class Budget
    {
        [Key]
        public int Id { get; set; }

        // Chave estrangeira para o utilizador
        [Required]
        [Display(Name = "Utilizador")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [Required(ErrorMessage = "O mês é obrigatório.")]
        [Display(Name = "Mês")]
        public int Month { get; set; }       // 1 a 12

        [Required(ErrorMessage = "O ano é obrigatório.")]
        [Display(Name = "Ano")]
        public int Year { get; set; }        // Ex: 2026

        [Required(ErrorMessage = "O valor do orçamento é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor deve ser superior a 0.")]
        [Display(Name = "Valor do Orçamento (€)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Data de Última Alteração")]
        public DateTime? UpdatedAt { get; set; }
    }
}
