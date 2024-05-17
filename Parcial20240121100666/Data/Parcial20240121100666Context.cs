using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SportAPI.Data;

public partial class Parcial20240121100666Context : DbContext
{
    public Parcial20240121100666Context()
    {
    }

    public Parcial20240121100666Context(DbContextOptions<Parcial20240121100666Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Sport> Sport { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2302502;Database=Parcial20240121100666;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sport>(entity =>
        {
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
