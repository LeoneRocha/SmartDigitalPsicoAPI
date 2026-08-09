using AutoMapper;
using SmartDigitalPsico.Domain.DTO.Medical.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.DTO.Medical.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.Common;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.UPDATE;
using SmartDigitalPsico.Domain.DTO.Patient.GET;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Mapper
{
    public class MedicalProfile : Profile
    {
        public MedicalProfile()
        {
            #region Medical
            CreateMap<Medical, GetMedicalDto>();
            CreateMap<GetMedicalDto, Medical>();
            CreateMap<AddMedicalDto, Medical>();
            CreateMap<UpdateMedicalDto, Medical>();
            #endregion Medical

            #region MedicalFile
            CreateMap<AddMedicalFileDtoService, AddMedicalFileDto>();

            CreateMap<MedicalFile, GetMedicalFileDto>();
            CreateMap<GetPatientFileDto, MedicalFile>();

            CreateMap<AddMedicalFileDto, MedicalFile>();
            CreateMap<UpdateMedicalFileDto, MedicalFile>();
            #endregion MedicalFile

            #region MedicalCalendar
            CreateMap<MedicalCalendar, AddMedicalCalendarDto>();
            CreateMap<AddMedicalCalendarDto, MedicalCalendar>();

            CreateMap<MedicalCalendar, UpdateMedicalCalendarDto>();
            CreateMap<UpdateMedicalCalendarDto, MedicalCalendar>();

            CreateMap<MedicalCalendar, GetMedicalCalendarDto>();
            CreateMap<GetMedicalCalendarDto, MedicalCalendar>();

            CreateMap<MedicalCalendar, GetMedicalCalendarTimeSlotDto>();

            CreateMap<MedicalCalendar, AppointmentDto>()
                .ForMember(dest => dest.MedicalName, opt => opt.MapFrom(src => src.Medical!.Name));
            #endregion MedicalCalendar
        }
    }
}
