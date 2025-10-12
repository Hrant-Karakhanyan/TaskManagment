using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace TaskManagment.Application.DependencyInjection
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Регистрируем MediatR — автоматически находит все команды, запросы и хендлеры
            services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            return services;
        }
    }
}
