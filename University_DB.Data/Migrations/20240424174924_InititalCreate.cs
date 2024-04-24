using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University_DB.Data.Migrations
{
    /// <inheritdoc />
    public partial class InititalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Entity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "NULL"),
                    Discriminator = table.Column<string>(type: "varchar(21)", maxLength: 21, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mark = table.Column<double>(type: "double", nullable: true),
                    Subject_id = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Journal_id = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JournalId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    SpecializationlId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Student_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Subject_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Salary = table.Column<double>(type: "double", nullable: true),
                    Teacher_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entity_Entity_JournalId",
                        column: x => x.JournalId,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entity_Entity_Journal_id",
                        column: x => x.Journal_id,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entity_Entity_SpecializationlId",
                        column: x => x.SpecializationlId,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entity_Entity_Subject_id",
                        column: x => x.Subject_id,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SpecailizationSubject",
                columns: table => new
                {
                    SpecializationsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SubjectsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecailizationSubject", x => new { x.SpecializationsId, x.SubjectsId });
                    table.ForeignKey(
                        name: "FK_SpecailizationSubject_Entity_SpecializationsId",
                        column: x => x.SpecializationsId,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecailizationSubject_Entity_SubjectsId",
                        column: x => x.SubjectsId,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TeacherSpecialization",
                columns: table => new
                {
                    SpecializationsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TeachersId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSpecialization", x => new { x.SpecializationsId, x.TeachersId });
                    table.ForeignKey(
                        name: "FK_TeacherSpecialization_Entity_SpecializationsId",
                        column: x => x.SpecializationsId,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSpecialization_Entity_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "Entity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_Journal_id",
                table: "Entity",
                column: "Journal_id");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_JournalId",
                table: "Entity",
                column: "JournalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entity_SpecializationlId",
                table: "Entity",
                column: "SpecializationlId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity_Subject_id",
                table: "Entity",
                column: "Subject_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpecailizationSubject_SubjectsId",
                table: "SpecailizationSubject",
                column: "SubjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSpecialization_TeachersId",
                table: "TeacherSpecialization",
                column: "TeachersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecailizationSubject");

            migrationBuilder.DropTable(
                name: "TeacherSpecialization");

            migrationBuilder.DropTable(
                name: "Entity");
        }
    }
}
