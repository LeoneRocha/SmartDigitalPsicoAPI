using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Contracts
{ 
    public class Record<T>
    {
        public long UserIdLogged { get; set; }
        public User LoggedInUser { get; set; } = new User();        
        public T RecordEntity { get; set; } = default!; 
    }
}
