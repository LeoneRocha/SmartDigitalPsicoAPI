using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Classe responsÃ¡vel por SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.IgnorableSerializerContractResolver.
    /// Responsabilidade: utilitÃ¡rio auxiliar do domÃ­nio.
    /// RelaÃ§Ã£o: usado por Services e Domain para regras compartilhadas.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class IgnorableSerializerContractResolver : DefaultContractResolver
    {
        private readonly HashSet<string> _propertiesToIgnore;

        /// <summary>
        /// MÃ©todo SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.IgnorableSerializerContractResolver: executa a operaÃ§Ã£o SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.IgnorableSerializerContractResolver.
        /// </summary>
        public IgnorableSerializerContractResolver(IEnumerable<string> propertiesToIgnore)
        {
            _propertiesToIgnore = new HashSet<string>(propertiesToIgnore);
        }

        /// <summary>
        /// MÃ©todo CreateProperty: cria ou persiste um novo registro/recurso.
        /// </summary>
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            ApplyIgnoreRulesForTests(property);
            return property;
        }

        /// <summary>
        /// Applies ignore rules for coverage of null PropertyName paths.
        /// </summary>
        internal void ApplyIgnoreRulesForTests(JsonProperty property)
        {
            if (_propertiesToIgnore.Contains(property.PropertyName!))
            {
                property.ShouldSerialize = _ => false;
            }
        }
    }
}
