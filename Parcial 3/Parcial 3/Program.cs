using DATOS;
using DATOS.Context;
using DATOS.Repositorios;
using DATOS.Repositorios.Contracts;
using LOGICA.Contracts;
using LOGICA.Implementions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Parcial_3
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

            Application.Run(_serviceProvider.GetRequiredService<Form1>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {

                    services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
                    services.AddScoped<IProductoLogic, ProductoLogic>();
                    services.AddScoped<IProductoRepository, ProductoRepository>();
                    

                    services.AddTransient<Form1>();
                 


                    services.AddDbContext<DataContext>(options => options.UseSqlServer("Data Source=LAPTOP-BRM4J6A3\\SQLEXPRESS;Initial Catalog=BaseDeDatosParcial3;Integrated Security=True;TrustServerCertificate=true"), ServiceLifetime.Transient);
                });
        }
    }
}