﻿using Contracts;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Repository;

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



       public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {


         services.AddDbContext<RepositoryContext>(options =>
         options.UseSqlServer(configuration.GetConnectionString("sqlConnection"),
         project=> project.MigrationsAssembly("ProjectManagment")));


        }



    }
}
