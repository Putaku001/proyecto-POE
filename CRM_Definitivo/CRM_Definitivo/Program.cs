using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using DataAccessLayer.DbSqlDataAccess;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.InterfacesRepositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PresentationLayer.Forms;

namespace CRM_Definitivo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    //FORMS
                    services.AddTransient<UsuariosForm>();
                    services.AddTransient<LoginForm>();
                    services.AddTransient<MenuForm>();
                    services.AddTransient<ProyectosForm>();
                    services.AddTransient<EditarUsuarioForm>();
                    services.AddTransient<AñadirUsuariosForm>();
                   

                    //BUSISNESSLAYER
                    services.AddScoped<IUsuarioServices, UsuariosServices>();
                    services.AddScoped<IRolServices, RolServices>();

                    //REPOR
                    services.AddScoped<IUsuarioRepositories, UsuarioRepositories>();
                    services.AddScoped<IRolRepositories,  RolRepositories>();

                    //SQLDATA
                    services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
                });
        }
    }
}