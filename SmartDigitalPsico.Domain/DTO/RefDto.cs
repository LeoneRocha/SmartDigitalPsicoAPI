namespace SmartDigitalPsico.Domain.DTO
{
    /// <summary>
    /// Classe responsável por RefDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class RefDto<T>
    {
        public T Value { get; set; }
        /// <summary>
        /// Método RefDto: executa a operação RefDto.
        /// </summary>
        public RefDto(T value) => Value = value;
    } 
}
