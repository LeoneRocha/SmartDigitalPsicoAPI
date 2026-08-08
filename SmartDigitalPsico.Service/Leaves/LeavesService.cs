using SmartDigitalPsico.Service.Common;
using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.EntityModels.Schedule;

using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Leaves;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Leaves
{
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;
                                        /// <summary>
    /// Classe responsável por LeavesService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class LeavesService
      : SmartDigitalPsico.Service.Common.EntityBaseService<Leaves, GetLeavesDto>, ILeavesService
    {
        /// <summary>
        /// Método LeavesService: executa a operação LeavesService.
        /// </summary>
        public LeavesService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            ILeavesRepository entityRepository,
            IApplicationLanguageRepository applicationLanguageRepository,
            IValidator<Leaves> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        { 
        }  
    }
}
