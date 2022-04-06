using Contracts;
using data_access;
using domain;
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

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManger, Logger.LoggerManager>();
        }

        public static void ConfigureCatalogueDomain(this IServiceCollection services)
        {
            services.AddSingleton<ICatalogue, Catalogue>();
        }
        public static void ConfigureDataAccessLayer(this IServiceCollection services)
        {
            services.AddSingleton<IDataOperations, FakeDataOperations>();
        }
    }
}