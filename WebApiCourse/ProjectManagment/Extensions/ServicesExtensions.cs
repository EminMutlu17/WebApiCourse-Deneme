using Contracts;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service;
using Service.Contracts;

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

  



       public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            // Lazy<IProjectRepository> ve Lazy<IEmployeeRepository> ekleme
            services.AddScoped<Lazy<IProjectRepository>>(provider =>
                new Lazy<IProjectRepository>(() => provider.GetRequiredService<IProjectRepository>()));

            services.AddScoped<Lazy<IEmployeeRepository>>(provider =>
                new Lazy<IEmployeeRepository>(() => provider.GetRequiredService<IEmployeeRepository>()));

            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }





        public static void ConfiugreServiceManager(this IServiceCollection services)
        {

            // ServiceManager ve ilgili servisleri ekliyoruz
            services.AddScoped<IServiceManager, ServiceManager>();

            // Project Service ve Lazy yükleme mantığı
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<Lazy<IProjectService>>(provider =>
                new Lazy<IProjectService>(() => provider.GetRequiredService<IProjectService>()));

            // Employee Service ve Lazy yükleme mantığı
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<Lazy<IEmployeeService>>(provider =>
                new Lazy<IEmployeeService>(() => provider.GetRequiredService<IEmployeeService>()));

        }


    }
}
