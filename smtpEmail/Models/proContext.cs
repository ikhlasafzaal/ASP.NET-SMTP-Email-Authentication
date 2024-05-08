using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace smtpEmail.Models
{
    public partial class proContext : DbContext
    {
        public proContext()
        {
        }

        public proContext(DbContextOptions<proContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Register> Registers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=.;Initial Catalog=pro;user id=sa;password=aptech;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Register>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__register__C2B7EDE844FBE882");

                entity.ToTable("register");

                entity.HasIndex(e => e.Rname, "UQ__register__DDD6735120227F7F")
                    .IsUnique();

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Remail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("remail");

                entity.Property(e => e.Rname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rname");

                entity.Property(e => e.Rpass)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rpass");

                entity.Property(e => e.Runame)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("runame");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
