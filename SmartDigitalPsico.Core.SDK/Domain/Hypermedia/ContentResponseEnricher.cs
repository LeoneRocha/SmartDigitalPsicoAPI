using System.Collections.Concurrent;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Routing;
using SmartDigitalPsico.Core.SDK.Domain.AppException;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Core.SDK.Domain.Hypermedia
{
    /// <summary>
    /// Classe responsável por ContentResponseEnricher.
    /// </summary>
    public abstract class ContentResponseEnricher<T> : IResponseEnricher where T : ISupportsHyperMedia
    {
        public virtual bool CanEnrich(Type contentType)
        {
            bool isCanEnrich = contentType == typeof(T)
                || contentType == typeof(List<T>)
                || typeof(PagedSearchVO<T>).IsAssignableFrom(contentType)
                || contentType == typeof(ServiceResponse<T>)
                || contentType == typeof(ServiceResponse<List<T>>);

            return isCanEnrich;
        }

        protected abstract Task EnrichModel(T content, IUrlHelper urlHelper);

        bool IResponseEnricher.CanEnrich(ResultExecutingContext context)
        {
            if (context.Result is OkObjectResult okObjectResult)
            {
                if (okObjectResult.Value == null)
                {
                    throw new AppWarningException("EnrichModel Value cannot be null.");
                }
                var objValidate = okObjectResult.Value.GetType();
                return CanEnrich(objValidate);
            }
            return false;
        }

        public async Task Enrich(ResultExecutingContext context)
        {
            var urlHelper = new UrlHelperFactory().GetUrlHelper(context);
            if (context.Result is OkObjectResult okObjectResult)
            {
                await HandleOkObjectResult(okObjectResult, urlHelper);
            }
            await Task.CompletedTask;
        }

        private async Task HandleOkObjectResult(OkObjectResult okObjectResult, IUrlHelper urlHelper)
        {
            switch (okObjectResult.Value)
            {
                case ServiceResponse<T> serviceResponse:
                    await HandleServiceResponse(serviceResponse, urlHelper);
                    break;
                case ServiceResponse<List<T>> serviceResponseList:
                    HandleServiceResponseList(serviceResponseList, urlHelper);
                    break;
                case T model:
                    await EnrichModel(model, urlHelper);
                    break;
                case List<T> collection:
                    HandleCollection(collection, urlHelper);
                    break;
                case PagedSearchVO<T> pagedSearch when pagedSearch.List != null:
                    HandleCollection(pagedSearch.List.ToList(), urlHelper);
                    break;
            }
        }

        private async Task HandleServiceResponse(ServiceResponse<T> serviceResponse, IUrlHelper urlHelper)
        {
            if (serviceResponse.Data is T model)
            {
                await EnrichModel(model, urlHelper);
            }
        }

        private void HandleServiceResponseList(ServiceResponse<List<T>> serviceResponseList, IUrlHelper urlHelper)
        {
            if (serviceResponseList.Data is List<T> collection)
            {
                HandleCollection(collection, urlHelper);
            }
        }

        private void HandleCollection(List<T> collection, IUrlHelper urlHelper)
        {
            ConcurrentBag<T> bag = new ConcurrentBag<T>(collection);
            Parallel.ForEach(bag, element => EnrichModel(element, urlHelper));
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
