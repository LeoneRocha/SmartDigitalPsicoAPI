using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace SmartDigitalPsico.Domain.Helpers
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
            if (property.PropertyName is { } name && _propertiesToIgnore.Contains(name))
            {
                property.ShouldSerialize = _ => false;
            }
            return property;
        }
    }
}
