using System.ComponentModel;

namespace SmartDigitalPsico.Domain.Enuns
{
    public enum EStatusCalendar
    { 
        [Description("Ativo")]
        Active = 0,

        [Description("Cancelado")]
        Canceled = 1, 
    }
}
