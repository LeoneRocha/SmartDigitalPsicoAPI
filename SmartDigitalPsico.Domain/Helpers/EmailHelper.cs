namespace SmartDigitalPsico.Domain.Helpers
{
    public static class EmailHelper
    {
        private const string TokenPattern = "{{{0}}}";

        public static string ReplaceTokens(string template, Dictionary<string, string> tokens)
        {
            foreach (var token in tokens)
            {
                template = template.Replace(string.Format(TokenPattern, token.Key), token.Value);
            }
            return template;
        } 
    }
}
