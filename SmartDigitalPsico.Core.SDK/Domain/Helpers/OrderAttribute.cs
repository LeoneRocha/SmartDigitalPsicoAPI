namespace SmartDigitalPsico.Core.SDK.Domain.Helpers
{
    [AttributeUsage(AttributeTargets.Property)]
    /// <summary>
    /// Classe responsável por OrderAttribute.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public class OrderAttribute : Attribute
    {
        public int Order { get; }
        /// <summary>
        /// Método OrderAttribute: executa a operação OrderAttribute.
        /// </summary>
        public OrderAttribute(int order)
        {
            Order = order;
        }
    }
}
