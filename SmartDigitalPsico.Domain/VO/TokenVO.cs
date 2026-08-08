namespace SmartDigitalPsico.Domain.VO
{
    /// <summary>
    /// Classe responsável por SmartDigitalPsico.Core.SDK.Domain.VO.TokenVO.
    /// Responsabilidade: value object / objeto de valor de resposta.
    /// Relação: retornado pelos Services para Controllers.
    /// </summary>
    public class TokenVO
    {
        /// <summary>
        /// Método SmartDigitalPsico.Core.SDK.Domain.VO.TokenVO: mapeia ou transforma dados entre modelos.
        /// </summary>
        public TokenVO()
        {
        } 
        /// <summary>
        /// Método SmartDigitalPsico.Core.SDK.Domain.VO.TokenVO: mapeia ou transforma dados entre modelos.
        /// </summary>
        public TokenVO(bool authenticated, string created, string expiration, string accessToken, string refreshToken)
        {
            Authenticated = authenticated;
            Created = created;
            Expiration = expiration;
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }

        public bool Authenticated { get; private set; }
        public string Created { get; private set; } = string.Empty;
        public string Expiration { get; private set; } = string.Empty;
        public string AccessToken { get; private set; } = string.Empty;
        public string RefreshToken { get; private set; } = string.Empty;
    }
}
