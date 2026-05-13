using ProjetoDA.Model;

namespace ProjetoDA.Controller
{
    /// <summary>
    /// Guarda o utilizador que fez login durante a sessão atual.
    /// Usado pelos controllers para registar quem criou/alterou cada registo.
    /// </summary>
    public static class SessaoAtual
    {
        public static Utilizador UtilizadorLogado { get; set; }



    }
}
