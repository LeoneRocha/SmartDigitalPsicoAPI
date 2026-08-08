
using System.ComponentModel;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Classe responsável por SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.ReflectionHelpers.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class ReflectionHelpers
    {
        /// <summary>
        /// Método GetProperties: consulta e retorna dados.
        /// </summary>
        public static IOrderedEnumerable<System.Reflection.PropertyInfo> GetProperties(object dataObject, List<string> propertiesToIgnore)
        {
            return dataObject.GetType().GetProperties()
                        .Where(p => !propertiesToIgnore.Contains(p.Name))
                        .OrderBy(p => p.GetCustomAttributes(typeof(OrderAttribute), false)
                        .Cast<OrderAttribute>().FirstOrDefault()?.Order ?? int.MaxValue);
        }

        /// <summary>
        /// Método GetLabelProperty: consulta e retorna dados.
        /// </summary>
        public static string GetLabelProperty(System.Reflection.PropertyInfo property)
        {
            var label = property.Name;
            var descriptionAttribute = property.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;
            if (descriptionAttribute != null)
            {
                label = descriptionAttribute.Description;
            }
            return label;
        }
    }
}
