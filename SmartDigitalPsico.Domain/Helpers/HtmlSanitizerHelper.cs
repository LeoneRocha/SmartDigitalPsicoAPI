using Ganss.Xss;

namespace SmartDigitalPsico.Domain.Helpers
{
    public static class HtmlSanitizerHelper
    {
        private static readonly HtmlSanitizer _sanitizer = new HtmlSanitizer();

        private static void ConfigureSanitizer(HtmlSanitizer sanitizer)
        {
            // Permitir atributos de estilo
            sanitizer.AllowedAttributes.Add("style");

            // Permitir tags específicas
            sanitizer.AllowedTags.Add("div");
            sanitizer.AllowedTags.Add("span");
            sanitizer.AllowedTags.Add("h1");
            sanitizer.AllowedTags.Add("h2");
            sanitizer.AllowedTags.Add("h3");
            sanitizer.AllowedTags.Add("h4");
            sanitizer.AllowedTags.Add("h5");
            sanitizer.AllowedTags.Add("h6");
            sanitizer.AllowedTags.Add("p");
            sanitizer.AllowedTags.Add("a");
            sanitizer.AllowedTags.Add("strong");
            sanitizer.AllowedTags.Add("em");
            sanitizer.AllowedTags.Add("ul");
            sanitizer.AllowedTags.Add("li");
            sanitizer.AllowedTags.Add("ol");
            sanitizer.AllowedTags.Add("br");
            sanitizer.AllowedTags.Add("font");
            sanitizer.AllowedTags.Add("b");
            sanitizer.AllowedTags.Add("i");
        }

        public static string Sanitize(string input)
        {
            ConfigureSanitizer(_sanitizer);
            return _sanitizer.Sanitize(input);
        }
    }
}
