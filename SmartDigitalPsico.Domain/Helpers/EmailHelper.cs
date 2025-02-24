namespace SmartDigitalPsico.Domain.Helpers
{
    public static class EmailHelper
    {
        private const string TokenPattern = "[{{{0}}}]";
         
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