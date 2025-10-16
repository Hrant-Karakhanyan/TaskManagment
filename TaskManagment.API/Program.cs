using TaskManagment.Application.DependencyInjection;
using TaskManagment.Infrastructure.DependencyInjection;

namespace TaskManagment.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ✅ 1. Добавляем DI из Application и Infrastructure
            builder.Services.AddApplicationServices();
            builder.Services.AddInfrastructureServices(builder.Configuration);

            // ✅ 2. Добавляем контроллеры и Swagger
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // ✅ 3. Конфигурация middleware
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();

            // ✅ 4. Маршрутизация контроллеров
            app.MapControllers();

            app.Run();
        }
    }
}
