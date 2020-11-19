﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TestApp.Library.DAL.Models
{
    public partial class TestAppEntities : DbContext
    {
        public TestAppEntities()
        {
        }

        public TestAppEntities(DbContextOptions<TestAppEntities> options)
            : base(options)
        {
        }

        public virtual DbSet<Cars_Jorge> Cars_Jorge { get; set; }
        public virtual DbSet<Cars_Luis> Cars_Luis { get; set; }
        public virtual DbSet<Cars_Mario> Cars_Mario { get; set; }
        public virtual DbSet<Cars_Yair> Cars_Yair { get; set; }
        public virtual DbSet<CustomFiles> CustomFiles { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=sql5097.site4now.net;Initial Catalog=DB_A49E03_testapp;user id=DB_A49E03_testapp_admin;password=testapp123456789");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars_Jorge>(entity =>
            {
                entity.HasKey(e => e.car_id)
                    .HasName("PK__Cars_Jor__BDFD24F5E37049CA");

                entity.Property(e => e.car_id).ValueGeneratedNever();

                entity.Property(e => e.created_at).HasColumnType("datetime");

                entity.Property(e => e.make)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.model)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cars_Luis>(entity =>
            {
                entity.HasKey(e => e.car_id);

                entity.Property(e => e.created_at)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.is_active).HasDefaultValueSql("((1))");

                entity.Property(e => e.make)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.model)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cars_Mario>(entity =>
            {
                entity.HasKey(e => e.car_id);

                entity.Property(e => e.created_at)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.is_active).HasDefaultValueSql("((1))");

                entity.Property(e => e.make)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.model)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cars_Yair>(entity =>
            {
                entity.HasKey(e => e.car_id);

                entity.Property(e => e.created_at)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.is_active).HasDefaultValueSql("((1))");

                entity.Property(e => e.make)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.model)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomFiles>(entity =>
            {
                entity.HasKey(e => e.customfile_id);

                entity.Property(e => e.created_at)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.is_active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.path)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.HasKey(e => e.person_id);

                entity.Property(e => e.created_at)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.first_names)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.is_active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.last_names)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.user_id);

                entity.Property(e => e.created_at)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.email)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.first_names)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.is_active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.last_names)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.password)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
