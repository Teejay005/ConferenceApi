using ConferenceApi.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApi.Attributes
{
    [AttributeUsage(validOn: AttributeTargets.Class)]
    public class SecurityAttribute : FlagsAttribute, IAsyncActionFilter
    {
        private const string APIKEYNAME = "X-API-KEY";
        private const string ALLOWED_IPS = "AllowedIps";
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var appSettings = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
            string env = context.HttpContext.Request.Query["env"].ToString();
            if (!appSettings.GetValue<bool>("DebugMode") && env != "test")
            {
                var allowedIps = appSettings.GetSection(ALLOWED_IPS).AsEnumerable();

                if (!(allowedIps.Where(x => x.Value == context.HttpContext.GetOriginatingIp()).Count() > 0))
                {
                    context.Result = new ContentResult()
                    {
                        StatusCode = 401,
                        Content = "Origin not allowed"
                    };
                    return;
                }

                if (!context.HttpContext.Request.Headers.TryGetValue(APIKEYNAME, out var extractedApiKey))
                {
                    context.Result = new ContentResult()
                    {
                        StatusCode = 401,
                        Content = "Api Key was not provided"
                    };
                    return;
                }


                var apiKey = appSettings.GetValue<string>(APIKEYNAME);

                if (!apiKey.Equals(extractedApiKey))
                {
                    context.Result = new ContentResult()
                    {
                        StatusCode = 401,
                        Content = "Api Key is not valid"
                    };
                    return;
                }
            }
            await next();
        }
    }
}
