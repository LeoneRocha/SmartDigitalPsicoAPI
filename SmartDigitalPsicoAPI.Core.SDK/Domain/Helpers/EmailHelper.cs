namespace SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers
{
    /// <summary>
    /// Classe responsável por EmailHelper.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public static class EmailHelper
    {
        private const string TokenPattern = "[{{{0}}}]";
         
        /// <summary>
        /// Método ReplaceTokens: executa a operação ReplaceTokens.
        /// </summary>
        public static string ReplaceTokens(string template, Dictionary<string, string> tokens)
        {
            if (tokens != null && tokens.Count > 0)
            {
                foreach (var token in tokens)
                {
                    var tokenKey = string.Format(TokenPattern, token.Key);
                    if (template.Contains(tokenKey))
                    {
                        template = template.Replace(tokenKey, token.Value);
                    }
                }
            }
            return template;
        }
    }
}
