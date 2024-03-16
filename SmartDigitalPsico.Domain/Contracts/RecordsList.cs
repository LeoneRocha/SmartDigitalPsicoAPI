using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Contracts
{
    public class RecordsList<T>
    {
        public long UserIdLogged { get; set; }
        public User LoggedInUser { get; set; }
        public List<T> Records { get; set; }
    }

    public class Record<T>
    {
        public long UserIdLogged { get; set; }
        public User LoggedInUser { get; set; }
        public T RecordEntity { get; set; }
    }
}
