using System.Reflection;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddApplicationServices(
           this IServiceCollection services
        )
        {

            //add Automapper 
            services.AddAutoMapper(Assembly.GetCallingAssembly()    
            );
          services.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            services.AddValidatorsFromAssembly
            (
                Assembly.GetCallingAssembly()
            );
            return services;
        }
        

    }
}