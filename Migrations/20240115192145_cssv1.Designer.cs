﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Physiosoft.Data;

#nullable disable

namespace Physiosoft.Migrations
{
    [DbContext(typeof(PhysiosoftDbContext))]
    [Migration("20240115192145_cssv1")]
    partial class cssv1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Physiosoft.Data.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("appointment_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentID"));

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("appointment_date");

                    b.Property<string>("AppointmentStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("appointment_status");

                    b.Property<int>("DurationMinutes")
                        .HasMaxLength(3)
                        .HasColumnType("int")
                        .HasColumnName("duration_minutes");

                    b.Property<bool>("HasScans")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("has_scans");

                    b.Property<string>("Notes")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("notes");

                    b.Property<int>("PatientID")
                        .HasColumnType("int")
                        .HasColumnName("patient_id");

                    b.Property<string>("PatientIssuse")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("patient_issue");

                    b.Property<int?>("PhysioID")
                        .HasColumnType("int")
                        .HasColumnName("physio_id");

                    b.HasKey("AppointmentID")
                        .HasName("PK__APPOINTMENT");

                    b.HasIndex("PhysioID");

                    b.HasIndex(new[] { "AppointmentDate" }, "appointment_date");

                    b.HasIndex(new[] { "PatientID" }, "patient_id");

                    b.ToTable("APPOINTMENTS", (string)null);
                });

            modelBuilder.Entity("Physiosoft.Data.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("patient_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("address");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Firstname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("firstname");

                    b.Property<bool>("HasReviewed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("has_reviewed");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("lastname");

                    b.Property<string>("Notes")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("notes");

                    b.Property<string>("PatientIssue")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("patient_issue");

                    b.Property<string>("RegNum")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)")
                        .HasColumnName("reg_num");

                    b.Property<string>("Ssn")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("ssn");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("telephone");

                    b.Property<string>("Vat")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)")
                        .HasColumnName("vat");

                    b.HasKey("PatientId")
                        .HasName("PK__PATIENTS__4D5CE4769C9C68C2");

                    b.HasIndex(new[] { "Lastname" }, "IX_PATIENTS_LASTNAME");

                    b.HasIndex(new[] { "Ssn" }, "UQ_PATIENTS_SSN")
                        .IsUnique();

                    b.ToTable("PATIENTS", (string)null);
                });

            modelBuilder.Entity("Physiosoft.Data.Physio", b =>
                {
                    b.Property<int>("PhysioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("physio_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhysioId"));

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("firstname");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("lastname");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("telephone");

                    b.HasKey("PhysioId")
                        .HasName("PK__PHYSIOS__8BB9145E55AAA5F5");

                    b.HasIndex(new[] { "Lastname" }, "IX_PHYSIOS_Lastname");

                    b.HasIndex(new[] { "Telephone" }, "UQ_PHYSIOS_TELEPHONE")
                        .IsUnique();

                    b.ToTable("PHYSIOS", (string)null);
                });

            modelBuilder.Entity("Physiosoft.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<bool>("IsAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("is_admin");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("password");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("username");

                    b.HasKey("UserId")
                        .HasName("PK__USERS");

                    b.HasIndex(new[] { "Email" }, "email")
                        .IsUnique();

                    b.HasIndex(new[] { "Username" }, "username")
                        .IsUnique();

                    b.ToTable("USERS", (string)null);
                });

            modelBuilder.Entity("Physiosoft.Data.Appointment", b =>
                {
                    b.HasOne("Physiosoft.Data.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientID")
                        .IsRequired()
                        .HasConstraintName("FK_Appointments_Patients");

                    b.HasOne("Physiosoft.Data.Physio", "Physio")
                        .WithMany("Appointments")
                        .HasForeignKey("PhysioID")
                        .HasConstraintName("FK_Appointments_Physios");

                    b.Navigation("Patient");

                    b.Navigation("Physio");
                });

            modelBuilder.Entity("Physiosoft.Data.Patient", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Physiosoft.Data.Physio", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
