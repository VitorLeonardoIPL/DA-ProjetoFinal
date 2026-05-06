using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iShopping.Models
{
    /// <summary>
    /// Representa um artigo/producto que pode ser comprado.
    /// Cada artigo pertence a um Tipo de Artigo.
    /// Exemplo: "Arroz Basmati" pertence ao tipo "Alimentação".
    /// </summary>
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do artigo é obrigatório.")]
        [MaxLength(150, ErrorMessage = "O nome não pode ter mais de 150 caracteres.")]
        [Display(Name = "Nome do Artigo")]
        public string Name { get; set; }

        // Chave estrangeira para ArticleType
        [Required(ErrorMessage = "O tipo de artigo é obrigatório.")]
        [Display(Name = "Tipo de Artigo")]
        public int ArticleTypeId { get; set; }

        // Propriedade de navegação: permite aceder ao tipo diretamente
        [ForeignKey("ArticleTypeId")]
        public virtual ArticleType ArticleType { get; set; }
    }
}
