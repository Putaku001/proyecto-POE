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
using PresentationLayer.Forms.Admin;
using PresentationLayer.Forms.Cliente;
using PresentationLayer.Forms.Empleados;
using PresentationLayer.Reports;
using QuestPDF.Infrastructure;

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
            QuestPDF.Settings.License = LicenseType.Community;

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
                    services.AddTransient<UsersForm>();
                    services.AddTransient<LoginForm>();
                    services.AddTransient<MenuForm>();
                    services.AddTransient<ProyectsForm>();
                    services.AddTransient<EditUsersForm>();
                    services.AddTransient<AddUsersForm>();
                    services.AddTransient<ProfileUserAccountForm>();
                    services.AddTransient<ImageViewerForm>();
                    services.AddTransient<ChangePasswordProfileForm>();
                    services.AddTransient<ProjectsHistoric>();
                    services.AddTransient<SettingsUserForm>();
                    services.AddTransient<ConfigurationUserEmployeeForm>();
                    services.AddTransient<ConfigurationUserClientForm>();
                    services.AddTransient<PermissionForm>();
                    services.AddTransient<HomeUserClientForm>();
                    services.AddTransient<HomeUserEmployeeForm>();


                    //BUSISNESSLAYER
                    services.AddScoped<IUsersServices, UsersServices>();
                    services.AddScoped<IPermisoServices, PermissionServices>();
                    services.AddScoped<IRolServices, RolServices>();
                    services.AddScoped<IListProyectsServices, ListProyectsServices>();

                    //REPOSITORIES
                    services.AddScoped<IUsersRepositories, UsersRepositories>();
                    services.AddScoped<IPermissionRepositories, PermissionRepositories>();
                    services.AddScoped<IRolRepositories,  RolRepositories>();
                    services.AddScoped<IListProyectsRepositories, ListProyectsRepositories>();

                    //REPORTS
                    services.AddScoped<IUserReports, UserReports>();

                    //SQLDATA
                    services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
                    services.AddSingleton<User>();
                });
        }
    }
}