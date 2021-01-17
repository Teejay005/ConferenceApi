using ConferenceApi.Interfaces;
using ConferenceApi.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApi.Middleware
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {

            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddScoped<ISessionService, SessionService>();
            services.AddScoped<IValidationService, ValidationService>();
            return services;
        }
    }
}
