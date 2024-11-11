using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using Entities;

namespace DATOS.Context
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        //CREACION DBSETS
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Compra> Compras { get; set; }
        public virtual DbSet<DetalleCompra> DetalleCompras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-BRM4J6A3\\SQLEXPRESS;Initial Catalog=BaseDeDatosParcial3;Integrated Security=True;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                      .HasName("PK_ID_PRODUCTO");
                entity.HasMany(e => e.DetalleCompras)
                 .WithOne(e => e.Producto)
                 .HasForeignKey("IdProducto")
                 .IsRequired();
            });
            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.IdCompra)
                      .HasName("PK_ID_COMPRA");
                entity.HasMany(e => e.DetalleCompras)
                     .WithOne(e => e.Compra)
                     .HasForeignKey("IdCompra")
                     .IsRequired();

            });
            modelBuilder.Entity<DetalleCompra>(entity =>
            {
                entity.HasKey(e => e.IdDetalleCompra)
                      .HasName("PK_ID_DETALLECOMPRA");
            

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
