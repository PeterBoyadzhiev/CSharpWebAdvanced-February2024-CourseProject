using ExploreUmami.Services.Data;
using ExploreUmami.Services.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExploreUmami.Web.Infrastructure.Extensions
{
    public static class WebApplicationBuilderExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
        {
            Assembly? serviceAssembly = Assembly.GetAssembly(serviceType);
            if (serviceAssembly == null)
            {
                throw new InvalidOperationException("Invalid service type");
            }

            Type[] types = serviceAssembly
                .GetTypes()
                .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
                .ToArray();

            foreach (Type type in types)
            {
                Type? interfaceType = type
                    .GetInterfaces()
                    .FirstOrDefault(i => i.Name == "I" + type.Name);

                if (interfaceType == null)
                {
                    throw new InvalidOperationException($"Interface for {type.Name} not found");
                }

                services.AddScoped(interfaceType, type);
            }

            services.AddScoped<IBusinessService, BusinessService>();
        }
    }
}
