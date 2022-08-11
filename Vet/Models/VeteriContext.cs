using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Vet.Models
{
    public partial class VeteriContext : DbContext
    {

        public VeteriContext(DbContextOptions<VeteriContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.Property(e => e.Contact).HasMaxLength(30);

                entity.Property(e => e.DateAppointment).HasColumnType("datetime");

                entity.Property(e => e.OwnerName).HasMaxLength(100);

                entity.Property(e => e.PetName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
