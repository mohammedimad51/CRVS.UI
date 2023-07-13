using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class BirthCertificate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BirthCertificates",
                columns: table => new
                {
                    BirthCertificateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CertificateNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChildName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirthCertificates", x => x.BirthCertificateId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BirthCertificates");
        }
    }
}
