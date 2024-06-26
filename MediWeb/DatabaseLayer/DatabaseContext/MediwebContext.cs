﻿using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data;

public partial class MediwebContext : DbContext
{
    private readonly IConfiguration _configuration;

    public MediwebContext(DbContextOptions<MediwebContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<AppointmentSlot> AppointmentSlots { get; set; }

    public virtual DbSet<Clinic> Clinics { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<DoctorWorksAtClinic> DoctorWorksAtClinics { get; set; }

    public virtual DbSet<MedicalStaff> MedicalStaff { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Specialization> Specializations { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnectionString"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("admin_pkey");

            entity.ToTable("admin");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AdminType).HasColumnName("admin_type");
            entity.Property(e => e.UserAccountId).HasColumnName("user_account_id");

            entity.HasOne(d => d.UserAccount).WithOne(p => p.Admin)
                .HasForeignKey<UserAccount>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("admin_user_account_fkey");
        });

        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("appointment_pkey");

            entity.ToTable("appointment");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AppointmentSlotId).HasColumnName("appointment_slot_id");
            entity.Property(e => e.IsApproved)
                .HasColumnType("bit(1)")
                .HasColumnName("is_approved");
            entity.Property(e => e.Note)
                .HasColumnType("character varying")
                .HasColumnName("note");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");

            entity.HasOne(d => d.AppointmentSlot).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.AppointmentSlotId)
                .HasConstraintName("appointment_appointment_slot_fkey");

            entity.HasOne(d => d.Patient).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("appointment_patient_fkey");
        });

        modelBuilder.Entity<AppointmentSlot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("appointment_slot_pkey");

            entity.ToTable("appointment_slot");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClinicId).HasColumnName("clinic_id");
            entity.Property(e => e.DateAndTime).HasColumnName("date_and_time");
            entity.Property(e => e.DoctorId).HasColumnName("doctor_id");
            entity.Property(e => e.DurationInMinutes).HasColumnName("duration_in_minutes");

            entity.HasOne(d => d.Clinic).WithMany(p => p.AppointmentSlots)
                .HasForeignKey(d => d.ClinicId)
                .HasConstraintName("appointment_slot_clinic_fkey");

            entity.HasOne(d => d.Doctor).WithMany(p => p.AppointmentSlots)
                .HasForeignKey(d => d.DoctorId)
                .HasConstraintName("appointment_slot_doctor_fkey");
        });

        modelBuilder.Entity<Clinic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("clinic_pkey");

            entity.ToTable("clinic");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .HasColumnName("address");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .HasColumnName("phone_number");
            entity.Property(e => e.Pib)
                .HasMaxLength(100)
                .HasColumnName("pib");
            entity.Property(e => e.WorkHours)
                .HasMaxLength(50)
                .HasColumnName("work_hours");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("doctor_pkey");

            entity.ToTable("doctor");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Title)
                .HasColumnType("character varying")
                .HasColumnName("title");
            entity.Property(e => e.UserAccountId).HasColumnName("user_account_id");

            entity.HasOne(d => d.UserAccount).WithOne(p => p.Doctor)
                .HasForeignKey<UserAccount>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("doctor_user_account_fkey");
        });

        modelBuilder.Entity<DoctorWorksAtClinic>(entity =>
        {
            entity.HasKey(e => new { e.DoctorId, e.ClinicId, e.SpecializationId }).HasName("doctor_works_at_clinic_pkey");

            entity.ToTable("doctor_works_at_clinic");

            entity.Property(e => e.DoctorId).HasColumnName("doctor_id");
            entity.Property(e => e.ClinicId).HasColumnName("clinic_id");
            entity.Property(e => e.SpecializationId).HasColumnName("specialization_id");
            entity.Property(e => e.Note)
                .HasMaxLength(500)
                .HasColumnName("note");

            entity.HasOne(d => d.Clinic).WithMany(p => p.DoctorWorksAtClinics)
                .HasForeignKey(d => d.ClinicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("doctor_works_at_clinic_clinic_fkey");

            entity.HasOne(d => d.Doctor).WithMany(p => p.DoctorWorksAtClinics)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("doctor_works_at_clinic_doctor_fkey");

            entity.HasOne(d => d.Specialization).WithMany(p => p.DoctorWorksAtClinics)
                .HasForeignKey(d => d.SpecializationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("doctor_works_at_clinic_specialization_fkey");
        });

        modelBuilder.Entity<MedicalStaff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("medical_staff_pkey");

            entity.ToTable("medical_staff");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClinicId).HasColumnName("clinic_id");
            entity.Property(e => e.UserAccountId).HasColumnName("user_account_id");

            entity.HasOne(d => d.Clinic).WithMany(p => p.MedicalStaffs)
                .HasForeignKey(d => d.ClinicId)
                .HasConstraintName("medical_staff_clinic_fkey");

            entity.HasOne(d => d.UserAccount).WithOne(p => p.MedicalStaff)
                .HasForeignKey<UserAccount>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("medical_staff_user_account_fkey");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("patient_pkey");

            entity.ToTable("patient");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_of_birth");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.Jmbg)
                .HasColumnType("character varying")
                .HasColumnName("jmbg");
            entity.Property(e => e.PhoneNumber)
                .HasColumnType("character varying")
                .HasColumnName("phone_number");
            entity.Property(e => e.UserAccountId).HasColumnName("user_account_id");

            entity.HasOne(d => d.UserAccount).WithOne(p => p.Patient)
                .HasForeignKey<UserAccount>(d => d.Id)
                .HasConstraintName("patient_user_account_fkey");
        });

        modelBuilder.Entity<Specialization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("specialization_pkey");

            entity.ToTable("specialization");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_account_pkey");

            entity.ToTable("user_account");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate).HasColumnName("created_date");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .HasColumnName("password");
            entity.Property(e => e.UserType).HasColumnName("user_type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
