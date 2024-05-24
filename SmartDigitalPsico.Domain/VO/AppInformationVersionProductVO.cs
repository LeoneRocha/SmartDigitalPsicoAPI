﻿namespace SmartDigitalPsico.Domain.VO
{
    public class AppInformationVersionProductVO
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public string EnvironmentName { get; set; } = string.Empty;
        public string Message { get; internal set; } = string.Empty;
    }
}
