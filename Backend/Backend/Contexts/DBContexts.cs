using Backend.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Context
{
    public class MyDBContext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Use Fluent API to configure  

            // Map entities to tables  
            modelBuilder.Entity<Empleado>().ToTable("Empleados");
            modelBuilder.Entity<OrdenProduccion>().ToTable("OrdenesProduccion");

            // Configure Primary Keys  
            modelBuilder.Entity<Empleado>().HasKey(u => u.Legajo).HasName("PK_Empleados");
            modelBuilder.Entity<OrdenProduccion>().HasKey(o => o.NroOrden);

            // Configure columns
            modelBuilder.Entity<Empleado>().Property(e => e.ApellidoYNombre).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Empleado>().Property(e => e.DNI).HasColumnType("nvarchar(8)").IsRequired();
            modelBuilder.Entity<Empleado>().Property(e => e.Contrasenia).HasColumnType("nvarchar(100)").IsRequired();

            modelBuilder.Entity<OrdenProduccion>().Property(o => o.FechaInicio).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<OrdenProduccion>().Property(o => o.FechaFin).HasColumnType("datetime").IsRequired();

            // Configure relationships  
            //modelBuilder.Entity<OrdenProduccion>().HasOne<Vendedor>().WithMany(v => v.Ordenes).HasPrincipalKey(ug => ug.Id).HasForeignKey(u => u.UserGroupId).OnDelete(DeleteBehavior.Cascade).HasConstraintName("FK_Users_UserGroups");
        }
    }
}