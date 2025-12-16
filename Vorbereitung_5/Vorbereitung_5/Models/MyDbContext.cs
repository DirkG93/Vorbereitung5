using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Vorbereitung_5.Models;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Wohnung> Wohnungs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=WohnungDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Wohnung>(entity =>
        {
            entity.HasKey(e => e.WohnungId).HasName("PK__Wohnung__DDB01FE7DC06CE03");

            entity.ToTable("Wohnung");

            entity.Property(e => e.WohnungId).HasColumnName("WohnungID");
            entity.Property(e => e.FlaecheQm).HasColumnName("FlaecheQM");
            entity.Property(e => e.MieteChf)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("MieteCHF");
            entity.Property(e => e.Ort)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
