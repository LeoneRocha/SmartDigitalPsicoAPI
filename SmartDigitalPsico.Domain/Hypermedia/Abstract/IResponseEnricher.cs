﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace SmartDigitalPsico.Domain.Hypermedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutingContext context);
        Task Enrich(ResultExecutingContext context);
    }
}
