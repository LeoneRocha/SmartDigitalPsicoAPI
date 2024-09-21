using System.ComponentModel;
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
                if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    if (attribute.Description == description && field != null)
                    {
                        var objR = field.GetValue(null);
                        if (objR != null)
                            return (T)objR;
                    }
                }
                else
                {
                    if (field.Name == description)
                    {
                        var objR = field.GetValue(null);
                        if (objR != null)
                            return (T)objR;
                    }
                }
            }
            throw new ArgumentException("Not found.");
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
