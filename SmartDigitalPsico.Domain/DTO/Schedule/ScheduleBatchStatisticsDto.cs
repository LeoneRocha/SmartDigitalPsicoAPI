using System;

namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public class ScheduleBatchStatisticsDto
    {
        public int TotalItems { get; set; }
        public DayCountDto[] ItemsByDay { get; set; }
        public MonthCountDto[] ItemsByMonth { get; set; }
        public double AverageItemsPerDay { get; set; }
        public DateTime EarliestDate { get; set; }
        public DateTime LatestDate { get; set; }
    }
}
