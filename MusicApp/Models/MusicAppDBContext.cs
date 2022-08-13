using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MusicApp.Models
{
    public partial class MusicAppDBContext : DbContext
    {
        public MusicAppDBContext()
        {
        }

        public MusicAppDBContext(DbContextOptions<MusicAppDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cancione> Canciones { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:musicappcom.database.windows.net,1433;Initial Catalog=MusicAppDB;Persist Security Info=False;User ID=Asura;Password=MusicApp.comAdmin;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cancione>(entity =>
            {
                entity.HasKey(e => e.IdCancion)
                    .HasName("PK__Cancione__14F1523ABAC895DB");

                entity.Property(e => e.IdCancion).HasColumnName("Id_Cancion");

                entity.Property(e => e.Año).HasMaxLength(4);

                entity.Property(e => e.Genero).HasMaxLength(30);

                entity.Property(e => e.Grupo).HasMaxLength(30);

                entity.Property(e => e.Titulo).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
