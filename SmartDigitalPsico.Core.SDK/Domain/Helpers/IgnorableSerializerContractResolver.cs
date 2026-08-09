using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers
{
    /// <summary>
    /// Classe responsável por IgnorableSerializerContractResolver.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public class IgnorableSerializerContractResolver : DefaultContractResolver
    {
        private readonly HashSet<string> _propertiesToIgnore;

        /// <summary>
        /// Método IgnorableSerializerContractResolver: executa a operação IgnorableSerializerContractResolver.
        /// </summary>
        public IgnorableSerializerContractResolver(IEnumerable<string> propertiesToIgnore)
        {
            _propertiesToIgnore = new HashSet<string>(propertiesToIgnore);
        }

        /// <summary>
        /// Método CreateProperty: cria ou persiste um novo registro/recurso.
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
        public void ApplyIgnoreRulesForTests(JsonProperty property)
        {
            if (_propertiesToIgnore.Contains(property.PropertyName!))
            {
                property.ShouldSerialize = _ => false;
            }
        }
    }
}
