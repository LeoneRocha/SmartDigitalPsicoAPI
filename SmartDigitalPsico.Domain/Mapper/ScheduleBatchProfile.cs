using AutoMapper;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.DTO.Schedule.UpdateDTOs;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Service.Mapper
{
    public class ScheduleBatchProfile : Profile
    {
        public ScheduleBatchProfile()
        {
            // ScheduleItem mappings
            CreateMap<ScheduleItem, GetScheduleItemDto>();
            CreateMap<AddScheduleItemDto, ScheduleItem>();
            CreateMap<UpdateScheduleItemDto, ScheduleItem>();

            // ScheduleBatch mappings
            CreateMap<ScheduleBatch, GetScheduleBatchDto>()
                .ForMember(dest => dest.ScheduleItems, opt => opt.MapFrom(src => src.ScheduleData))
                .ForMember(dest => dest.MedicalName, opt => opt.MapFrom(src => src.Medical != null ? src.Medical.Name : string.Empty))
                .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => src.Patient != null ? src.Patient.Name : string.Empty));

            CreateMap<AddScheduleBatchDto, ScheduleBatch>()
                .ForMember(dest => dest.ScheduleData, opt => opt.MapFrom(src => src.ScheduleItems));

            CreateMap<UpdateScheduleBatchDto, ScheduleBatch>()
                .ForMember(dest => dest.ScheduleData, opt => opt.MapFrom(src => src.ScheduleItems));

            // Summary mappings
            CreateMap<ScheduleBatch, ScheduleBatchSummaryDto>()
                .ForMember(dest => dest.ItemCount, opt => opt.MapFrom(src => src.ScheduleData.Length));

            // Export mappings
            CreateMap<ScheduleItem, ScheduleItemExportDto>()
                .ForMember(dest => dest.Start, opt => opt.MapFrom(src => src.StartDateTime.ToString("o")))
                .ForMember(dest => dest.End, opt => opt.MapFrom(src => src.EndDateTime.HasValue ? src.EndDateTime.Value.ToString("o") : string.Empty))
                .ForMember(dest => dest.AllDay, opt => opt.MapFrom(src => src.IsAllDay))
                .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.ColorCategoryHexa))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));
        }
    }
}
