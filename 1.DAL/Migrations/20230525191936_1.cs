using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "Datetime", nullable: false),
                    Phone = table.Column<string>(type: "varchar(10)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Employee_type = table.Column<int>(type: "int", nullable: false),
                    Employee_count = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpInYear = table.Column<int>(type: "int", nullable: true),
                    ProSkill = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Graduation_date = table.Column<DateTime>(type: "Datetime", nullable: true),
                    Graduation_rank = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Education = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Majors = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Semester = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    University_name = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Certificate",
                columns: table => new
                {
                    CertificateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CertificateRank = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CertificatedDate = table.Column<DateTime>(type: "Datetime", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificate", x => x.CertificateID);
                    table.ForeignKey(
                        name: "FK_Certificate_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certificate_EmployeeID",
                table: "Certificate",
                column: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificate");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
