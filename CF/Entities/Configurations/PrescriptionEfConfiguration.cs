using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CF.Entities.Configurations
{
    public class PrescriptionEfConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasKey(e => e.IdPrescription).HasName("Prescription_pk");
            builder.Property(e => e.IdPrescription).UseIdentityColumn();
            builder.HasOne(e => e.IdDoctorNavigation)
                .WithMany(e => e.Prescriptions)
                .HasForeignKey(e => e.IdDoctor)
                .HasConstraintName("Prescription_Doctor")
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(e => e.IdPatientNavigation)
                .WithMany(e => e.Prescriptions)
                .HasForeignKey(e => e.IdPatient)
                .HasConstraintName("Prescription_Patient")
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Property(e => e.Date).IsRequired();
            builder.Property(e => e.DueDate).IsRequired();

            builder.HasData(new Prescription
            {
                IdPrescription = 1,
                Date = DateTime.Now,
                DueDate = DateTime.Today.AddDays(60),
                IdDoctor = 1,
                IdPatient = 1
            });

            builder.HasData(new Prescription
            {
                IdPrescription = 2,
                Date = DateTime.Now.AddDays(5),
                DueDate = DateTime.Today.AddDays(60),
                IdDoctor = 1,
                IdPatient = 2
            });

            builder.ToTable("Prescription");
        }
    }
}
