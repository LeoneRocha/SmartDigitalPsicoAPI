namespace SmartDigitalPsico.Domain.DTO.Domains
{
    public abstract class EmailTemplateBaseDto
    {
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public string Language { get; set; } = "en";
    }
}
