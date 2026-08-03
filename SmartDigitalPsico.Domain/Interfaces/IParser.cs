namespace SmartDigitalPsico.Domain.Interfaces
{
    /// <summary>
    /// Interface (contrato) responsável por IParser.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IParser<O, D>
    {
        /// <summary>
        /// Método Parse: executa a operação Parse.
        /// </summary>
        D Parse(O origin);
        /// <summary>
        /// Método Parse: executa a operação Parse.
        /// </summary>
        List<D> Parse(List<O> origin);
    }
}
