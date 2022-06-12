using CF.Entities.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CF.Entities
{
    public class HospitalContext : DbContext
    {
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<PrescriptionMedicament> Medicaments { get; set; }
        public virtual DbSet<PrescriptionMedicament> PrescriptionsMedicamentes { get; set; }

        public HospitalContext() { }
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DoctorEfConfiguration).GetTypeInfo().Assembly);
        }
    }
}
