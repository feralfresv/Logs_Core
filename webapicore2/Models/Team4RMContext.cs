using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace webapicore2.Models
{
    public partial class Team4RMContext : DbContext
    {
        public Team4RMContext()
        {
        }

        public Team4RMContext(DbContextOptions<Team4RMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Log> Log { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=microservicessttk2.database.windows.net;Initial Catalog=Team4RM;Persist Security Info=True;User ID=adminSttk;Password=@Softtek01");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aplicacion)
                    .IsRequired()
                    .HasColumnName("aplicacion");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasColumnName("mensaje");
            });
        }
    }
}
