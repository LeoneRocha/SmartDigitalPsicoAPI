using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    public class NotificationRecordsService
      : EntityBaseService<NotificationRecords, AddNotificationRecordsDto, UpdateNotificationRecordsDto, GetNotificationRecordsDto, INotificationRecordsRepository>, INotificationRecordsService
    {
        public NotificationRecordsService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            INotificationRecordsRepository entityRepository,
            IApplicationLanguageRepository applicationLanguageRepository,
            IValidator<NotificationRecords> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {

        }
        public override async Task<ServiceResponse<GetNotificationRecordsDto>> Create(AddNotificationRecordsDto item)
        { 
            item.NextScheduledSendTime = AdjustNextScheduledSendTime(item);
            return await base.Create(item);
        }

        public override async Task<ServiceResponse<GetNotificationRecordsDto>> Update(UpdateNotificationRecordsDto item)
        {
            // Ajusta o NextScheduledSendTime antes de atualizar.
            item.NextScheduledSendTime = AdjustNextScheduledSendTime(item);
            return await base.Update(item);
        }

        #region private
         
        /// <summary>
        /// Calcula e ajusta o NextScheduledSendTime para NotificationRecords.
        /// 
        /// Regra:
        /// - Considera as notificações pendentes (IsSent == false) e seleciona a data agendada mínima entre elas.
        /// - Converte esse horário, que está no fuso horário do apontamento, para UTC.
        ///   Exemplo: Se o apontamento está no horário de Brasília (UTC-3) e o agendamento (local) é às 09:00,
        ///   a conversão para UTC será 09:00 + 3 = 12:00 UTC.
        /// </summary>
        /// <param name="dto">DTO que contém as informações da NotificationRecords.</param>
        /// <returns>Data ajustada em UTC para NextScheduledSendTime ou null se não houver notificações pendentes.</returns>
        private DateTime? AdjustNextScheduledSendTime(NotificationRecordsBaseDto dto)
        {
            if (dto.NotificationRules != null && dto.NotificationRules.Any(r => !r.IsSent))
            {
                // Encontra o ScheduledSendTime mínimo entre as notificações que ainda não foram enviadas.
                var minScheduledLocal = dto.NotificationRules
                    .Where(r => !r.IsSent)
                    .Min(r => r.ScheduledSendTime);

                // Obtém o offset do fuso horário para o appointment.
                // Exemplo: Para o horário de Brasília, o offset é -3.
                int timeZoneOffset = GetAppointmentTimeZoneOffset(dto.AppointmentId);

                // Converte o horário local para UTC.
                // Se, por exemplo, minScheduledLocal é 2025-02-20 09:00:00 (horário local) e o offset é -3,
                // então: NextScheduledSendTime = 09:00 + 3 = 12:00 UTC.
                DateTime adjustedUtc = minScheduledLocal.AddHours(-timeZoneOffset);
                return adjustedUtc;
            }
            return null;
        }
        /// <summary>
        /// Obtém o offset do fuso horário do appointment.
        /// Este método pode ser aprimorado para buscar o fuso real a partir de alguma fonte (como o próprio appointment).
        /// Exemplo: Se um appointmentId estiver presente, assume-se que o apontamento está no horário de Brasília (UTC-3).
        /// </summary>
        /// <param name="appointmentId">ID do appointment.</param>
        /// <returns>Offset em horas (exemplo: -3 para horário de Brasília); retorna 0 se não houver appointmentId.</returns>
        private int GetAppointmentTimeZoneOffset(long? appointmentId)
        {
            // Implementação simplificada: se houver appointmentId, assume fuso de Brasília (UTC-3).
            return appointmentId.HasValue ? -3 : 0;
        }
        #endregion private
    }
} 