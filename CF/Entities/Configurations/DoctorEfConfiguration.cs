using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CF.Entities.Configurations
{
    public class DoctorEfConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(e => e.IdDoctor).HasName("Doctor_pk");
            builder.Property(e => e.IdDoctor).UseIdentityColumn();

            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(100);

            builder.HasData(new Doctor
            {
                IdDoctor = 1,
                Email = "asdfgh@gmail.com",
                FirstName = "Michał",
                LastName = "Bielecki"
            });
            builder.HasData(new Doctor
            {
                IdDoctor = 2,
                Email = "dasyudgiasdoas@gmail.com",
                FirstName = "Kamil",
                LastName = "Bielecki"
            });

            builder.ToTable("Doctor");
        }
    }
}
