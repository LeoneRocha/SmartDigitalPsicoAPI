﻿using SmartDigitalPsico.Data.ConfigureFluentAPI.Mock;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.DataMock
{
    public class GenderMockHelper
    {
        public static Gender[] GetMock()
        {
            return GenderMockData.GetMock();
        }
    }
}
