using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApi.Extensions
{
    public static class HttpContextExtensions
    {
        public static string GetOriginatingIp(this HttpContext context)
        {
            if (context.Request.Headers.ContainsKey("CF-Connecting-IP"))
            {
                return context.Request.Headers["CF-Connecting-IP"];
            }
            else
            {
                {
                    return context.Connection.RemoteIpAddress.ToString();
                }
            }
        }
    }
}
