using Contracts;
using LoggerService;

namespace ProjectManagment.Extensions
{
    public static  class ServicesExtensions
    {
        public static void ConfigureCors(this IServiceCollection services )
        {

            services.AddCors(
                options =>
                {
                    options.AddPolicy("CorsPolicy",
                        builder =>
                        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
                });
        }



        public static void ConfigureLoggerManagger (this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }





    }
}
