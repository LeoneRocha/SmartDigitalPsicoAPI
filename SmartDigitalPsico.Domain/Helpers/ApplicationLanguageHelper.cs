namespace SmartDigitalPsico.Domain.Helpers
{
    public static class ApplicationLanguageHelper
    {

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