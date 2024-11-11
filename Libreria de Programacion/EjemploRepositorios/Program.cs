using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CLogica.Implementations;
using CLogica.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using CDatos.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using CPresentacion;
using CEntidades.Entidades;
using CPresentacion.Empleado;
using CPresentacion.Cliente;

namespace EjemploRepositorios
{
    internal static class Program
    {
        public static IServiceProvider _serviceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            _serviceProvider = host.Services;

            Application.Run(_serviceProvider.GetRequiredService<Menu>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {

                    services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
                    services.AddScoped<IAutorLogic, AutorLogic>();
                    services.AddScoped<IEmpleadoLogic, EmpleadoLogic>();
                    services.AddScoped<IPersonaLogic, PersonaLogic>();
                    services.AddScoped<ILibroLogic, LibroLogic>();
                    services.AddScoped<IClienteLogic, ClienteLogic>();
                    services.AddScoped<IEditorialLogic, EditorialLogic>();
                    services.AddScoped<ICopiaLogic, CopiaLogic>();
                    services.AddScoped<IAutorRepository, AutorRepository>();
                    services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();
                    services.AddScoped<IPersonaRepository, PersonaRepository>();
                    services.AddScoped<ILibroRepository, LibroRepostry>();
                    services.AddScoped<IClienteRepository, ClienteRepository>();
                    services.AddScoped<IEditorialRepository, EditorialRepository>();
                    services.AddScoped<ICopiaRepository, CopiaRepository>();
                    services.AddTransient<Menu>();
                    services.AddTransient<ABMAutor>();
                    services.AddTransient<FrmEmpleado>();
                    services.AddTransient<FrmCliente>();


                    services.AddDbContext<LibreriaContext>(options => options.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LibreriaProg2024;Integrated Security=True;TrustServerCertificate=true"), ServiceLifetime.Scoped);
                });
        }
    }
}