using System;
using System.Collections;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class IdentityMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clinic",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    address = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    pib = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    work_hours = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    phone_number = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("clinic_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "specialization",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("specialization_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_account",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_type = table.Column<int>(type: "integer", nullable: false),
                    email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    first_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    password = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("user_account_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    admin_type = table.Column<int>(type: "integer", nullable: false),
                    user_account_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("admin_pkey", x => x.id);
                    table.ForeignKey(
                        name: "admin_user_account_fkey",
                        column: x => x.user_account_id,
                        principalTable: "user_account",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "doctor",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying", nullable: true),
                    user_account_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("doctor_pkey", x => x.id);
                    table.ForeignKey(
                        name: "doctor_user_account_fkey",
                        column: x => x.user_account_id,
                        principalTable: "user_account",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "medical_staff",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    clinic_id = table.Column<long>(type: "bigint", nullable: false),
                    user_account_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("medical_staff_pkey", x => x.id);
                    table.ForeignKey(
                        name: "medical_staff_clinic_fkey",
                        column: x => x.clinic_id,
                        principalTable: "clinic",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "medical_staff_user_account_fkey",
                        column: x => x.user_account_id,
                        principalTable: "user_account",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "patient",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    jmbg = table.Column<string>(type: "character varying", nullable: false),
                    gender = table.Column<int>(type: "integer", nullable: false),
                    date_of_birth = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    phone_number = table.Column<string>(type: "character varying", nullable: false),
                    user_account_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("patient_pkey", x => x.id);
                    table.ForeignKey(
                        name: "patient_user_account_fkey",
                        column: x => x.user_account_id,
                        principalTable: "user_account",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "appointment_slot",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    doctor_id = table.Column<long>(type: "bigint", nullable: false),
                    clinic_id = table.Column<long>(type: "bigint", nullable: false),
                    date_and_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    duration_in_minutes = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("appointment_slot_pkey", x => x.id);
                    table.ForeignKey(
                        name: "appointment_slot_clinic_fkey",
                        column: x => x.clinic_id,
                        principalTable: "clinic",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "appointment_slot_doctor_fkey",
                        column: x => x.doctor_id,
                        principalTable: "doctor",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "doctor_works_at_clinic",
                columns: table => new
                {
                    doctor_id = table.Column<long>(type: "bigint", nullable: false),
                    clinic_id = table.Column<long>(type: "bigint", nullable: false),
                    specialization_id = table.Column<long>(type: "bigint", nullable: false),
                    note = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("doctor_works_at_clinic_pkey", x => new { x.doctor_id, x.clinic_id, x.specialization_id });
                    table.ForeignKey(
                        name: "doctor_works_at_clinic_clinic_fkey",
                        column: x => x.clinic_id,
                        principalTable: "clinic",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "doctor_works_at_clinic_doctor_fkey",
                        column: x => x.doctor_id,
                        principalTable: "doctor",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "doctor_works_at_clinic_specialization_fkey",
                        column: x => x.specialization_id,
                        principalTable: "specialization",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "appointment",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    note = table.Column<string>(type: "character varying", nullable: false),
                    is_approved = table.Column<BitArray>(type: "bit(1)", nullable: false, defaultValueSql: "(0)::bit(1)"),
                    patient_id = table.Column<long>(type: "bigint", nullable: false),
                    appointment_slot_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("appointment_pkey", x => x.id);
                    table.ForeignKey(
                        name: "appointment_appointment_slot_fkey",
                        column: x => x.appointment_slot_id,
                        principalTable: "appointment_slot",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "appointment_patient_fkey",
                        column: x => x.patient_id,
                        principalTable: "patient",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "admin_user_account_id_key",
                table: "admin",
                column: "user_account_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "appointment_appointment_slot_id_key",
                table: "appointment",
                column: "appointment_slot_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_appointment_patient_id",
                table: "appointment",
                column: "patient_id");

            migrationBuilder.CreateIndex(
                name: "IX_appointment_slot_clinic_id",
                table: "appointment_slot",
                column: "clinic_id");

            migrationBuilder.CreateIndex(
                name: "IX_appointment_slot_doctor_id",
                table: "appointment_slot",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "doctor_user_account_id_key",
                table: "doctor",
                column: "user_account_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_doctor_works_at_clinic_clinic_id",
                table: "doctor_works_at_clinic",
                column: "clinic_id");

            migrationBuilder.CreateIndex(
                name: "IX_doctor_works_at_clinic_specialization_id",
                table: "doctor_works_at_clinic",
                column: "specialization_id");

            migrationBuilder.CreateIndex(
                name: "IX_medical_staff_clinic_id",
                table: "medical_staff",
                column: "clinic_id");

            migrationBuilder.CreateIndex(
                name: "medical_staff_user_account_id_key",
                table: "medical_staff",
                column: "user_account_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "patient_user_account_id_key",
                table: "patient",
                column: "user_account_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "appointment");

            migrationBuilder.DropTable(
                name: "doctor_works_at_clinic");

            migrationBuilder.DropTable(
                name: "medical_staff");

            migrationBuilder.DropTable(
                name: "appointment_slot");

            migrationBuilder.DropTable(
                name: "patient");

            migrationBuilder.DropTable(
                name: "specialization");

            migrationBuilder.DropTable(
                name: "clinic");

            migrationBuilder.DropTable(
                name: "doctor");

            migrationBuilder.DropTable(
                name: "user_account");
        }
    }
}
