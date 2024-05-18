using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Contracts
{
    public class RecordsList<T>
    {
        public long UserIdLogged { get; set; }
        public User LoggedInUser { get; set; } = new User();
        public List<T> Records { get; set; } = new List<T>();
    } 
}
