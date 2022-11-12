using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProyProveedor.Models
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Proveedores> Proveedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proveedores>()
                .Property(e => e.Razon_social)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.Rfc)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.Estatus)
                .IsUnicode(false);
        }
    }
}
