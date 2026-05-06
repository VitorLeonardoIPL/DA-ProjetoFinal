using System.Collections.Generic;
using System.Linq;
using iShopping.Data;
using iShopping.Models;

namespace iShopping.Controllers
{
    /// <summary>
    /// Controlador de Artigos.
    /// Responsável pela gestão de artigos (produtos).
    /// Cada artigo pertence a um Tipo de Artigo (categoria).
    /// 
    /// Funcionalidades:
    /// - CRUD completo de artigos
    /// - Filtragem de artigos por tipo de artigo
    /// - Obter artigos de um tipo específico (útil para dropdowns)
    /// </summary>
    public class ArticleController
    {
        /// <summary>
        /// Lista todos os artigos existentes na base de dados.
        /// Inclui também o Tipo de Artigo associado (Include).
        /// </summary>
        public List<Article> GetAllArticles()
        {
            using (var context = new iShoppingContext())
            {
                // Include carrega também o tipo de artigo associado
                return context.Articles
                    .Include("ArticleType")
                    .ToList();
            }
        }

        /// <summary>
        /// Lista todos os artigos de um determinado tipo.
        /// Útil para quando o utilizador seleciona um tipo e quer ver só os artigos desse tipo.
        /// </summary>
        public List<Article> GetArticlesByType(int articleTypeId)
        {
            using (var context = new iShoppingContext())
            {
                return context.Articles
                    .Include("ArticleType")
                    .Where(a => a.ArticleTypeId == articleTypeId)
                    .ToList();
            }
        }

        /// <summary>
        /// Procura um artigo pelo seu ID.
        /// </summary>
        public Article GetArticleById(int id)
        {
            using (var context = new iShoppingContext())
            {
                return context.Articles
                    .Include("ArticleType")
                    .FirstOrDefault(a => a.Id == id);
            }
        }

        /// <summary>
        /// Cria um novo artigo na base de dados.
        /// Retorna true se a criação foi bem-sucedida.
        /// </summary>
        public bool CreateArticle(string name, int articleTypeId)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            using (var context = new iShoppingContext())
            {
                // Verificar se já existe um artigo com o mesmo nome neste tipo
                bool exists = context.Articles.Any(a => 
                    a.Name.ToLower() == name.ToLower() && 
                    a.ArticleTypeId == articleTypeId);
                
                if (exists)
                {
                    return false;
                }

                var newArticle = new Article
                {
                    Name = name.Trim(),
                    ArticleTypeId = articleTypeId
                };

                context.Articles.Add(newArticle);
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Atualiza os dados de um artigo existente.
        /// Retorna true se a atualização foi bem-sucedida.
        /// </summary>
        public bool UpdateArticle(int id, string newName, int newArticleTypeId)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                return false;
            }

            using (var context = new iShoppingContext())
            {
                var article = context.Articles.FirstOrDefault(a => a.Id == id);
                if (article == null)
                {
                    return false;
                }

                // Verificar se o nome já existe noutro artigo do mesmo tipo
                bool nameExists = context.Articles.Any(a => 
                    a.Name.ToLower() == newName.ToLower() && 
                    a.ArticleTypeId == newArticleTypeId && 
                    a.Id != id);
                
                if (nameExists)
                {
                    return false;
                }

                article.Name = newName.Trim();
                article.ArticleTypeId = newArticleTypeId;
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Elimina um artigo da base de dados.
        /// Retorna true se a eliminação foi bem-sucedida.
        /// </summary>
        public bool DeleteArticle(int id)
        {
            using (var context = new iShoppingContext())
            {
                var article = context.Articles.FirstOrDefault(a => a.Id == id);
                if (article == null)
                {
                    return false;
                }

                context.Articles.Remove(article);
                context.SaveChanges();
                return true;
            }
        }
    }
}
