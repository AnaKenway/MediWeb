﻿// <auto-generated />
using System;
using System.Collections;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(MediWebContext))]
    partial class MediWebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DataLayer.EntityModels.Admin", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("AdminType")
                        .HasColumnType("integer")
                        .HasColumnName("admin_type");

                    b.Property<long>("UserAccountId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_account_id");

                    b.HasKey("Id")
                        .HasName("admin_pkey");

                    b.HasIndex(new[] { "UserAccountId" }, "admin_user_account_id_key")
                        .IsUnique();

                    b.ToTable("admin", (string)null);
                });

            modelBuilder.Entity("DataLayer.EntityModels.Appointment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AppointmentSlotId")
                        .HasColumnType("bigint")
                        .HasColumnName("appointment_slot_id");

                    b.Property<BitArray>("IsApproved")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit(1)")
                        .HasColumnName("is_approved")
                        .HasDefaultValueSql("(0)::bit(1)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("note");

                    b.Property<long>("PatientId")
                        .HasColumnType("bigint")
                        .HasColumnName("patient_id");

                    b.HasKey("Id")
                        .HasName("appointment_pkey");

                    b.HasIndex("PatientId");

                    b.HasIndex(new[] { "AppointmentSlotId" }, "appointment_appointment_slot_id_key")
                        .IsUnique();

                    b.ToTable("appointment", (string)null);
                });

            modelBuilder.Entity("DataLayer.EntityModels.AppointmentSlot", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("ClinicId")
                        .HasColumnType("bigint")
                        .HasColumnName("clinic_id");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_and_time");

                    b.Property<long>("DoctorId")
                        .HasColumnType("bigint")
                        .HasColumnName("doctor_id");

                    b.Property<int>("DurationInMinutes")
                        .HasColumnType("integer")
                        .HasColumnName("duration_in_minutes");

                    b.HasKey("Id")
                        .HasName("appointment_slot_pkey");

                    b.HasIndex("ClinicId");

                    b.HasIndex("DoctorId");

                    b.ToTable("appointment_slot", (string)null);
                });

            modelBuilder.Entity("DataLayer.EntityModels.Clinic", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("address");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("phone_number");

                    b.Property<string>("Pib")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("pib");

                    b.Property<string>("WorkHours")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("work_hours");

                    b.HasKey("Id")
                        .HasName("clinic_pkey");

                    b.ToTable("clinic", (string)null);
                });

            modelBuilder.Entity("DataLayer.EntityModels.Doctor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Title")
                        .HasColumnType("character varying")
                        .HasColumnName("title");

                    b.Property<long>("UserAccountId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_account_id");

                    b.HasKey("Id")
                        .HasName("doctor_pkey");

                    b.HasIndex(new[] { "UserAccountId" }, "doctor_user_account_id_key")
                        .IsUnique();

                    b.ToTable("doctor", (string)null);
                });

            modelBuilder.Entity("DataLayer.EntityModels.DoctorWorksAtClinic", b =>
                {
                    b.Property<long>("DoctorId")
                        .HasColumnType("bigint")
                        .HasColumnName("doctor_id");

                    b.Property<long>("ClinicId")
                        .HasColumnType("bigint")
                        .HasColumnName("clinic_id");

                    b.Property<long>("SpecializationId")
                        .HasColumnType("bigint")
                        .HasColumnName("specialization_id");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("note");

                    b.HasKey("DoctorId", "ClinicId", "SpecializationId")
                        .HasName("doctor_works_at_clinic_pkey");

                    b.HasIndex("ClinicId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("doctor_works_at_clinic", (string)null);
                });

            modelBuilder.Entity("DataLayer.EntityModels.MedicalStaff", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("ClinicId")
                        .HasColumnType("bigint")
                        .HasColumnName("clinic_id");

                    b.Property<long>("UserAccountId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_account_id");

                    b.HasKey("Id")
                        .HasName("medical_staff_pkey");

                    b.HasIndex("ClinicId");

                    b.HasIndex(new[] { "UserAccountId" }, "medical_staff_user_account_id_key")
                        .IsUnique();

                    b.ToTable("medical_staff", (string)null);
                });

            modelBuilder.Entity("DataLayer.EntityModels.Patient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_of_birth");

                    b.Property<int>("Gender")
                        .HasColumnType("integer")
                        .HasColumnName("gender");

                    b.Property<string>("Jmbg")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("jmbg");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("phone_number");

                    b.Property<long>("UserAccountId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_account_id");

                    b.HasKey("Id")
                        .HasName("patient_pkey");

                    b.HasIndex(new[] { "UserAccountId" }, "patient_user_account_id_key")
                        .IsUnique();

                    b.ToTable("patient", (string)null);
                });

            modelBuilder.Entity("DataLayer.EntityModels.Specialization", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("specialization_pkey");

                    b.ToTable("specialization", (string)null);
                });

            modelBuilder.Entity("DataLayer.EntityModels.UserAccount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("password");

                    b.Property<int>("UserType")
                        .HasColumnType("integer")
                        .HasColumnName("user_type");

                    b.HasKey("Id")
                        .HasName("user_account_pkey");

                    b.ToTable("user_account", (string)null);
                });

            modelBuilder.Entity("DataLayer.EntityModels.Admin", b =>
                {
                    b.HasOne("DataLayer.EntityModels.UserAccount", "UserAccount")
                        .WithOne("Admin")
                        .HasForeignKey("DataLayer.EntityModels.Admin", "UserAccountId")
                        .IsRequired()
                        .HasConstraintName("admin_user_account_fkey");

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("DataLayer.EntityModels.Appointment", b =>
                {
                    b.HasOne("DataLayer.EntityModels.AppointmentSlot", "AppointmentSlot")
                        .WithOne("Appointment")
                        .HasForeignKey("DataLayer.EntityModels.Appointment", "AppointmentSlotId")
                        .IsRequired()
                        .HasConstraintName("appointment_appointment_slot_fkey");

                    b.HasOne("DataLayer.EntityModels.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .IsRequired()
                        .HasConstraintName("appointment_patient_fkey");

                    b.Navigation("AppointmentSlot");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DataLayer.EntityModels.AppointmentSlot", b =>
                {
                    b.HasOne("DataLayer.EntityModels.Clinic", "Clinic")
                        .WithMany("AppointmentSlots")
                        .HasForeignKey("ClinicId")
                        .IsRequired()
                        .HasConstraintName("appointment_slot_clinic_fkey");

                    b.HasOne("DataLayer.EntityModels.Doctor", "Doctor")
                        .WithMany("AppointmentSlots")
                        .HasForeignKey("DoctorId")
                        .IsRequired()
                        .HasConstraintName("appointment_slot_doctor_fkey");

                    b.Navigation("Clinic");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DataLayer.EntityModels.Doctor", b =>
                {
                    b.HasOne("DataLayer.EntityModels.UserAccount", "UserAccount")
                        .WithOne("Doctor")
                        .HasForeignKey("DataLayer.EntityModels.Doctor", "UserAccountId")
                        .IsRequired()
                        .HasConstraintName("doctor_user_account_fkey");

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("DataLayer.EntityModels.DoctorWorksAtClinic", b =>
                {
                    b.HasOne("DataLayer.EntityModels.Clinic", "Clinic")
                        .WithMany("DoctorWorksAtClinics")
                        .HasForeignKey("ClinicId")
                        .IsRequired()
                        .HasConstraintName("doctor_works_at_clinic_clinic_fkey");

                    b.HasOne("DataLayer.EntityModels.Doctor", "Doctor")
                        .WithMany("DoctorWorksAtClinics")
                        .HasForeignKey("DoctorId")
                        .IsRequired()
                        .HasConstraintName("doctor_works_at_clinic_doctor_fkey");

                    b.HasOne("DataLayer.EntityModels.Specialization", "Specialization")
                        .WithMany("DoctorWorksAtClinics")
                        .HasForeignKey("SpecializationId")
                        .IsRequired()
                        .HasConstraintName("doctor_works_at_clinic_specialization_fkey");

                    b.Navigation("Clinic");

                    b.Navigation("Doctor");

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("DataLayer.EntityModels.MedicalStaff", b =>
                {
                    b.HasOne("DataLayer.EntityModels.Clinic", "Clinic")
                        .WithMany("MedicalStaff")
                        .HasForeignKey("ClinicId")
                        .IsRequired()
                        .HasConstraintName("medical_staff_clinic_fkey");

                    b.HasOne("DataLayer.EntityModels.UserAccount", "UserAccount")
                        .WithOne("MedicalStaff")
                        .HasForeignKey("DataLayer.EntityModels.MedicalStaff", "UserAccountId")
                        .IsRequired()
                        .HasConstraintName("medical_staff_user_account_fkey");

                    b.Navigation("Clinic");

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("DataLayer.EntityModels.Patient", b =>
                {
                    b.HasOne("DataLayer.EntityModels.UserAccount", "UserAccount")
                        .WithOne("Patient")
                        .HasForeignKey("DataLayer.EntityModels.Patient", "UserAccountId")
                        .IsRequired()
                        .HasConstraintName("patient_user_account_fkey");

                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("DataLayer.EntityModels.AppointmentSlot", b =>
                {
                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("DataLayer.EntityModels.Clinic", b =>
                {
                    b.Navigation("AppointmentSlots");

                    b.Navigation("DoctorWorksAtClinics");

                    b.Navigation("MedicalStaff");
                });

            modelBuilder.Entity("DataLayer.EntityModels.Doctor", b =>
                {
                    b.Navigation("AppointmentSlots");

                    b.Navigation("DoctorWorksAtClinics");
                });

            modelBuilder.Entity("DataLayer.EntityModels.Patient", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("DataLayer.EntityModels.Specialization", b =>
                {
                    b.Navigation("DoctorWorksAtClinics");
                });

            modelBuilder.Entity("DataLayer.EntityModels.UserAccount", b =>
                {
                    b.Navigation("Admin");

                    b.Navigation("Doctor");

                    b.Navigation("MedicalStaff");

                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
