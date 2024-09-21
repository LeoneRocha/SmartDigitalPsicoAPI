using System.ComponentModel;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SmartDigitalPsico.Domain.Helpers
{
    public class EnumDescriptionConverter<T> : JsonConverter<T> where T : Enum
    {
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

        private bool TryGetEnumValueFromDescription(FieldInfo field, string description, out T value)
        {
            if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute &&
                attribute.Description == description)
            {
                var objR = field.GetValue(null);
                if (objR != null)
                {
                    value = (T)objR;
                    return true;
                }
            }
            value = default!;
            return false;
        }

        private bool TryGetEnumValueFromName(FieldInfo field, string name, out T value)
        {
            if (field.Name == name)
            {
                var objR = field.GetValue(null);
                if (objR != null)
                {
                    value = (T)objR;
                    return true;
                }
            }
            value = default!;
            return false;
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            var field = value.GetType().GetField(value.ToString());
            if (field != null && Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
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
