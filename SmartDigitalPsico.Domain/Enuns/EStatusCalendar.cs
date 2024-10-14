using System.ComponentModel;

namespace SmartDigitalPsico.Domain.Enuns
{
    public enum EStatusCalendar
    { 
        [Description("Active")]
        Active = 0, 
        
        [Description("Scheduled")]
        Scheduled = 1,

        [Description("Confirmed")]
        Confirmed = 2,
       
        [Description("Refused")]
        Refused = 8,  
        
        [Description("Canceled")]
        Canceled = 9,    
    }
}
