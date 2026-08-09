namespace SmartDigitalPsico.Domain.Events
{
    /// <summary>
    /// Classe responsável por NotificationProgressEventArgs.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class NotificationProgressEventArgs : EventArgs
    {
        public int Processed { get; set; }
        public int Total { get; set; }
        public double Percentage => Total == 0 ? 0 : (double)Processed / Total * 100;
    }
}
