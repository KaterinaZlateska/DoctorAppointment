using DoctorAppointment.Enums;
using DoctorAppointment.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<AppointmentRequest> AppointmentRequests { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Referral> Referrals { get; set; }
        public DbSet<Availability> Availabilities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 👇 This enables Table-Per-Type (TPT) mapping
            modelBuilder.Entity<Patient>().ToTable("Patients");
            modelBuilder.Entity<Doctor>().ToTable("Doctors");
            modelBuilder.Entity<Admin>().ToTable("Admins");

            // Configure relationships and constraints if needed
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.Restrict); // ✅ Keep history, set PatientId to NULL when Patient is deleted

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Restrict); // ✅ Keep history, set DoctorId to NULL when Doctor is deleted

            modelBuilder.Entity<Report>()
                .HasOne(r => r.Doctor)
                .WithMany(d => d.Reports)
                .HasForeignKey(r => r.DoctorId)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Keep history, set DoctorId to NULL when Doctor is deleted

            modelBuilder.Entity<Report>()
                .HasOne(r => r.Patient)
                .WithMany(p => p.Reports)
                .HasForeignKey(r => r.PatientId)
                .OnDelete(DeleteBehavior.Restrict); // ✅ Keep history, set PatientId to NULL when Patient is deleted

            modelBuilder.Entity<Referral>()
                .HasOne(r => r.Doctor)
                .WithMany(d => d.Referrals)
                .HasForeignKey(r => r.DoctorId)
                .OnDelete(DeleteBehavior.Cascade); // ✅ Keep history, set DoctorId to NULL when Doctor is deleted

            modelBuilder.Entity<Referral>()
                .HasOne(r => r.Patient)
                .WithMany(p => p.Referrals)
                .HasForeignKey(r => r.PatientId)
                .OnDelete(DeleteBehavior.Restrict); // ✅ Keep history, set PatientId to NULL when Patient is deleted

            modelBuilder.Entity<Availability>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Availabilities)
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Cascade); // No history needed for availability, can be deleted

            modelBuilder.Entity<AppointmentRequest>()
                .HasOne(ar => ar.Patient)
                .WithMany()
                .HasForeignKey(ar => ar.PatientId)
                .OnDelete(DeleteBehavior.Restrict); // No history needed for appointment request, can be deleted

            modelBuilder.Entity<AppointmentRequest>()
                .HasOne(ar => ar.Doctor)
                .WithMany()
                .HasForeignKey(ar => ar.DoctorId)
                .OnDelete(DeleteBehavior.Restrict); // No history needed for appointment request, can be deleted
        }


    }
}
