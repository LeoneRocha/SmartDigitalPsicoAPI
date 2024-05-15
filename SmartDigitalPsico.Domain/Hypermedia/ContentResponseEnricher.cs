using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Routing;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using System.Collections.Concurrent;
using System.Text;

namespace SmartDigitalPsico.Domain.Hypermedia
{
    public abstract class ContentResponseEnricher<T> : IResponseEnricher where T : ISupportsHyperMedia
    { 
        public virtual bool CanEnrich(Type contentType)
        {
            bool isCanEnrich = contentType == typeof(T) || contentType == typeof(List<T>) || contentType == typeof(PagedSearchVO<T>)
                || contentType == typeof(ServiceResponse<T>) || contentType == typeof(ServiceResponse<List<T>>);

            return isCanEnrich;
        }

        protected abstract Task EnrichModel(T content, IUrlHelper urlHelper);

        bool IResponseEnricher.CanEnrich(ResultExecutingContext context)
        {
            if (context.Result is OkObjectResult okObjectResult)
            {
                var objValidate = okObjectResult.Value.GetType();

                return CanEnrich(objValidate);
            }
            return false;
        }
        public async Task Enrich(ResultExecutingContext context)
        {
            var urlHelper = new UrlHelperFactory().GetUrlHelper(context);
            //SIngle 
            if (context.Result is OkObjectResult okObjectResult)
            {
                if (okObjectResult.Value is ServiceResponse<T> serviceResponse)
                {
                    if (serviceResponse.Data is T model)
                    {
                        await EnrichModel(model, urlHelper);
                    }
                    else if (serviceResponse.Data is List<T> collection)
                    {
                        ConcurrentBag<T> bag = new ConcurrentBag<T>(collection);
                        Parallel.ForEach(bag, (element) =>
                        {
                            EnrichModel(element, urlHelper);
                        });
                    }
                }
                //LIST
                else if (okObjectResult.Value is ServiceResponse<List<T>> serviceResponse2)
                {
                    if (serviceResponse2.Data is List<T> collection)
                    {
                        ConcurrentBag<T> bag = new ConcurrentBag<T>(collection);
                        Parallel.ForEach(bag, (element) =>
                        {
                            EnrichModel(element, urlHelper);
                        });
                    }

                }
                else if (okObjectResult.Value is T model)
                {
                    await EnrichModel(model, urlHelper);
                }
                else if (okObjectResult.Value is List<T> collection)
                {
                    ConcurrentBag<T> bag = new ConcurrentBag<T>(collection);
                    Parallel.ForEach(bag, (element) =>
                    {
                        EnrichModel(element, urlHelper);
                    });
                }
                else if (okObjectResult.Value is PagedSearchVO<T> pagedSearch)
                {
                    Parallel.ForEach(pagedSearch.List.ToList(), (element) =>
                    {
                        EnrichModel(element, urlHelper);
                    });
                }
            }
            await Task.FromResult<object>(new { });
        }

        protected readonly object _lock = new object();
        protected string GetLink(long id, IUrlHelper urlHelper, string path)
        {
            lock (_lock)
            {
                var url = new { controller = path, id };
                return new StringBuilder(urlHelper.Link("DefaultApi", url)).Replace("%2F", "/").ToString();
            }
        }
    }
}
