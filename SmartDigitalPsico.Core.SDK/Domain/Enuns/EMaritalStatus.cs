using System.ComponentModel;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns
{
    /// <summary>
    /// Estado civil genérico.
    /// </summary>
    public enum EMaritalStatus
    {
        [Description("Single")]
        Single = 0,

        [Description("Married")]
        Married = 1,

        [Description("Divorced")]
        Divorced = 2,

        [Description("Other")]
        Other = 10,
    }
}
