using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace lab5.Models
{
    public partial class ContractDbContext : DbContext
    {
        public static ContractDbContext Instance { get; set; }

        static ContractDbContext() => Instance = new ContractDbContext();

        private ContractDbContext()
        {
        }

        public ContractDbContext(DbContextOptions<ContractDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agreement> Agreements { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<StatusAgrement> StatusAgrements { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=contract;uid=root;pwd=7684", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Agreement>(entity =>
            {
                entity.ToTable("agreement");

                entity.HasIndex(e => e.PersonId, "agreement_person_idx");

                entity.HasIndex(e => e.StatusId, "agreement_status_idx");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateClose).HasColumnName("date_close");

                entity.Property(e => e.DateOpen).HasColumnName("date_open");

                entity.Property(e => e.Number)
                    .HasMaxLength(45)
                    .HasColumnName("number");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Agreements)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("agreement_person");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Agreements)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("agreement_status");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("person");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Inn)
                    .HasMaxLength(45)
                    .HasColumnName("inn");

                entity.Property(e => e.Shifer)
                    .HasMaxLength(45)
                    .HasColumnName("shifer");

                entity.Property(e => e.Type)
                    .HasMaxLength(45)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<StatusAgrement>(entity =>
            {
                entity.ToTable("status_agrement");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Status)
                    .HasMaxLength(45)
                    .HasColumnName("status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
