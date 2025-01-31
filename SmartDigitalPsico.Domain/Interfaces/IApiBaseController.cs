namespace SmartDigitalPsico.Domain.Interfaces
{
    public interface IApiBaseController
    {
        void setUserIdCurrent();

        Task setUserCurrentCulture(long userId);

    }
}
