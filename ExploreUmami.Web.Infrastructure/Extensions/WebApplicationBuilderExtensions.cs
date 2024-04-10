using ExploreUmami.Data.Models;
using ExploreUmami.Services.Data;
using ExploreUmami.Services.Data.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ExploreUmami.Web.Infrastructure.Extensions
{
    using static ExploreUmami.Common.AppConstantsGeneral;

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

        public static IApplicationBuilder SeedAdministrator(this IApplicationBuilder app, string email)
        {
            using IServiceScope serviceScope = app.ApplicationServices.CreateScope();
            IServiceProvider serviceProvider = serviceScope.ServiceProvider;

            UserManager<ApplicationUser> userManager =
                serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            RoleManager<IdentityRole<Guid>> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

            Task.Run(async () =>
            {
                if(await roleManager.RoleExistsAsync(AdminRoleName))
                {
                    return;
                }

                await roleManager.CreateAsync(new IdentityRole<Guid>(AdminRoleName));

                ApplicationUser user = await userManager.FindByEmailAsync(email);

                await userManager.AddToRoleAsync(user, AdminRoleName);
            })
                .GetAwaiter()
                .GetResult();

            return app;
        }
    }
}
