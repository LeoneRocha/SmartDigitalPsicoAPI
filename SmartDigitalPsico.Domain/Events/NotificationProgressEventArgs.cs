﻿namespace SmartDigitalPsico.Domain.Events
{
    public class NotificationProgressEventArgs : EventArgs
    {
        public int Processed { get; set; }
        public int Total { get; set; }
        public double Percentage => Total == 0 ? 0 : (double)Processed / Total * 100;
    }
}