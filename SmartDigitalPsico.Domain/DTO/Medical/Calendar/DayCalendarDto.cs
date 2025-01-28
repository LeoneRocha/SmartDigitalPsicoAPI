﻿namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    public class DayCalendarDto
    {
        public DateTime Date { get; set; }
        public bool IsPast { get; set; }
        public TimeSlotDto[] TimeSlots { get; set; } = []; 
    }
}