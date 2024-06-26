﻿using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class GenderRepository : GenericRepositoryEntityBase<Gender>, IGenderRepository
    {
        public GenderRepository(SmartDigitalPsicoDataContext context) : base(context) { }
    }
}
