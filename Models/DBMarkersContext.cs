using System;
using System.Collections.Generic;
using maps2.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoLogin.Models;

public partial class DBMarkersContext : DbContext
{
    public DBMarkersContext()
    {
    }

    public DBMarkersContext(DbContextOptions<DBMarkersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.idAsesor).HasName("UQ__Usuarios__2A586E0BED2885E5");

            entity.ToTable("USUARIO");

            entity.Property(e => e.nombres)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.aPaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.aMaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.refnmobiliaria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.nick)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.contra)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.correo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.foto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.obs)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.dob)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.revisado)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

