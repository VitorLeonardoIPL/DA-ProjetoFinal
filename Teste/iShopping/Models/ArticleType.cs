using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iShopping.Models
{
    /// <summary>
    /// Representa um tipo/categoria de artigo.
    /// Exemplos: Alimentação, Limpeza, Higiene, Congelados, etc.
    /// </summary>
    public class ArticleType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do tipo é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
        [Display(Name = "Tipo de Artigo")]
        public string Name { get; set; }

        // Relação: um tipo de artigo pode ter vários artigos
        public virtual ICollection<Article> Articles { get; set; }
    }
}
