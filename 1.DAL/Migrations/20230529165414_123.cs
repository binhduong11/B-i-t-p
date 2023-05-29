using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificate_Employee_EmployeeID",
                table: "Certificate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Certificate",
                table: "Certificate");

            migrationBuilder.RenameTable(
                name: "Certificate",
                newName: "Certificates");

            migrationBuilder.RenameIndex(
                name: "IX_Certificate_EmployeeID",
                table: "Certificates",
                newName: "IX_Certificates_EmployeeID");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID1",
                table: "Certificates",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certificates",
                table: "Certificates",
                column: "CertificateID");

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_EmployeeID1",
                table: "Certificates",
                column: "EmployeeID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_Employee_EmployeeID",
                table: "Certificates",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_Employee_EmployeeID1",
                table: "Certificates",
                column: "EmployeeID1",
                principalTable: "Employee",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_Employee_EmployeeID",
                table: "Certificates");

            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_Employee_EmployeeID1",
                table: "Certificates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Certificates",
                table: "Certificates");

            migrationBuilder.DropIndex(
                name: "IX_Certificates_EmployeeID1",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "EmployeeID1",
                table: "Certificates");

            migrationBuilder.RenameTable(
                name: "Certificates",
                newName: "Certificate");

            migrationBuilder.RenameIndex(
                name: "IX_Certificates_EmployeeID",
                table: "Certificate",
                newName: "IX_Certificate_EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certificate",
                table: "Certificate",
                column: "CertificateID");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificate_Employee_EmployeeID",
                table: "Certificate",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
