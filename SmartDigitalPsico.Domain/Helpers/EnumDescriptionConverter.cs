using System.ComponentModel;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Classe responsÃ¡vel por SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.EnumDescriptionConverter.
    /// Responsabilidade: utilitÃ¡rio auxiliar do domÃ­nio.
    /// RelaÃ§Ã£o: usado por Services e Domain para regras compartilhadas.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class EnumDescriptionConverter<T> : JsonConverter<T> where T : Enum
    {
        /// <summary>
        /// MÃ©todo Read: consulta e retorna dados.
        /// </summary>
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var description = reader.GetString();
            foreach (var field in typeToConvert.GetFields())
            {
                if (!string.IsNullOrEmpty(description) &&
                    (TryGetEnumValueFromDescription(field, description, out T value) ||
                    TryGetEnumValueFromName(field, description, out value)
                    ))
                {
                    return value;
                }
            }
            throw new ArgumentException("Not found.");
        }

        private static bool TryGetEnumValueFromDescription(FieldInfo field, string description, out T value)
        {
            if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute &&
                attribute.Description == description &&
                field.GetValue(null) is T enumValue)
            {
                value = enumValue;
                return true;
            }
            value = default!;
            return false;
        }

        private static bool TryGetEnumValueFromName(FieldInfo field, string name, out T value)
        {
            if (field.Name == name && field.GetValue(null) is T enumValue)
            {
                value = enumValue;
                return true;
            }
            value = default!;
            return false;
        }

        /// <summary>
        /// MÃ©todo Write: executa a operaÃ§Ã£o Write.
        /// </summary>
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            var field = value.GetType().GetField(value.ToString())!;
            if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
            {
                writer.WriteStringValue(attribute.Description);
            }
            else
            {
                writer.WriteStringValue(value.ToString());
            }
        }
    }
}
