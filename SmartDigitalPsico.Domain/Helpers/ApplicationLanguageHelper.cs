namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Classe responsável por ApplicationLanguageHelper.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public static class ApplicationLanguageHelper
    {

        /// <summary>
        /// Método ReplaceTokensInMessage: executa a operação ReplaceTokensInMessage.
        /// </summary>
        public static string ReplaceTokensInMessage(string message)
        {
            var parts = message.Split('|');
            if (parts.Length > 2)
            {
                var template = parts[1]; 
                var values = parts.Skip(2).ToArray(); // Incluindo chave e mensagem principal
                var replacedMessage = ReplaceTokens(template, values);
                var result = $"{parts[0]}|{replacedMessage}";
                return result; // Retornando chave e mensagem com tokens substituídos
            }
            return message;
        }

        /// <summary>
        /// Método ReplaceTokens: executa a operação ReplaceTokens.
        /// </summary>
        public static string ReplaceTokens(string template, params string[] values)
        {
            string result = template;

            for (int i = 0; i < values.Length; i++)
            {
                string placeholder = $"{{{i}}}";
                if (result.Contains(placeholder))
                {
                    result = result.Replace(placeholder, values[i]);
                }
            } 
            return result;
        }
    }
}
