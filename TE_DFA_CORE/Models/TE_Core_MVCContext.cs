using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TE_DFA_CORE.Models
{
    public partial class TE_Core_MVCContext : DbContext
    {
        public TE_Core_MVCContext()
        {
        }

        public TE_Core_MVCContext(DbContextOptions<TE_Core_MVCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Trainee> Trainees { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ELW5152\\SQLEXPRESS01;Database=TE_Core_MVC;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainee>(entity =>
            {
                entity.HasKey(e => e.Tid)
                    .HasName("PK__Trainees__C456D72970CAE4B3");

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.Tdesignation)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Tname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
