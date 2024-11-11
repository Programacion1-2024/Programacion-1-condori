using CEntidades.Entitis;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;


namespace CDatos.Context
{
    public partial class BancoContext : DbContext
    {
        public BancoContext()
        {
        }
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<CuentaBancaria> CuentaBancarias { get; set; }
        public virtual DbSet<TarjetaCredito> TarjetaCreditos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-BRM4J6A3\\SQLEXPRESS;Initial Catalog=BancoProg;Integrated Security=True;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                      .HasName("PK_ID_CLIENTE");
                      
                entity.HasMany(e => e.CuentaBancarias)
                      .WithOne(e => e.Cliente)
                      .HasForeignKey("IdCliente")
                      .IsRequired();


                entity.HasMany(e => e.TarjetaCreditos)
                      .WithOne(e => e.Cliente)
                      .HasForeignKey("IdCliente")
                      .IsRequired();
            });

            modelBuilder.Entity<TarjetaCredito>(entity =>
            {
                entity.HasKey(e => e.IdTarjeta)
                      .HasName("PK_ID_TARJETA");

            });

            modelBuilder.Entity<CuentaBancaria>(entity =>
            {
                entity.HasKey(e => e.IdCuenta)
                      .HasName("PK_ID.CUENTA");
                entity.Property(e => e.IdCuenta)
                      .ValueGeneratedOnAdd();

            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
