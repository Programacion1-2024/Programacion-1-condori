using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using CDatos.Context;
using Microsoft.EntityFrameworkCore;
using Application = System.Windows.Forms.Application;
using CDatos.Repositorios.Contracts;
using CDatos.Repositorios;
using CLogica.Contract;
using CLogica.Implementación;


namespace CPresentacion
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
                    services.AddScoped<IClienteLogic, ClienteLogic>();
                    services.AddScoped<IClienteRepository, ClienteRepository>();
                    services.AddScoped<ICuentaLogic, CuentaLogic>();
                    services.AddScoped<ICuentaRepository, CuentaRepository>();

                    services.AddTransient<Form1>();
                    services.AddTransient<Cuenta>();


                    services.AddDbContext<BancoContext>(options => options.UseSqlServer("Data Source=LAPTOP-BRM4J6A3\\SQLEXPRESS;Initial Catalog=BancoProg;Integrated Security=True;TrustServerCertificate=true"), ServiceLifetime.Transient);
                });
        }
    }
}
