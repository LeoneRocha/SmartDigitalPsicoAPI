﻿using SmartDigitalPsico.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Domain.DTO.SMTP
{
    public class SmtpSettingsDto : ISmtpSettingsDto
    {
        public string Server { get; set; } = string.Empty;
        public int Port { get; set; }
        public string SenderName { get; set; } = string.Empty;
        public string SenderEmail { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
} 