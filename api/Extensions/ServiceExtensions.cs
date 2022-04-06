using Contracts;
using Logger;

namespace api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                // This CORS policy is wide open
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                                    .AllowAnyMethod()
                                    .AllowAnyHeader()
                );
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services){
            services.Configure<IISOptions>(options => {

            });
        }

        public static void ConfigureLoggerService(this IServiceCollection services){
            services.AddSingleton<ILoggerManger, Logger.LoggerManager>();
        }
    }
}