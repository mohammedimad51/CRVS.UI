using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class MIG3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ChildName",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CertificateNo",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Alive",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AllPDFs",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Approval",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "BHour",
                table: "BirthCertificates",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<DateTime>(
                name: "BOD",
                table: "BirthCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "BODText",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "BabyWeight",
                table: "BirthCertificates",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "BirthOccurredBy",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BirthPerformerName",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthPerformerWorkingAddress",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BirthType",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BornAliveThenDied",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BornDisable",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CivilStatusDirectorate",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "BirthCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Creator",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DistrictID",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DocumentType",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DohID",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "DurationOfPregnancy",
                table: "BirthCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FamilyDOH",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyDistrict",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyGovernorate",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyHomeNo",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyMahala",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyNahia",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyPHC",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilySector",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyZigag",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FatherAge",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FatherBOD",
                table: "BirthCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FatherFName",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FatherFullName",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FatherJob",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FatherLName",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FatherMName",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FatherMobile",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FatherNationality",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FatherReligion",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "FirstStage",
                table: "BirthCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GovernorateCivilStatusDirectorate",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GovernorateID",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HospitalManagerName",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HospitalManagerSig",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgBirthCertificate",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgFatherUnifiedNationalIdBack",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgFatherUnifiedNationalIdFront",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgMarriageCertificate",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgMotherUnifiedNationalIdBack",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgMotherUnifiedNationalIdFront",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgResidencyCardBack",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgResidencyCardFront",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InformerJobTitle",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InformerName",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "BirthCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BirthCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDisabled",
                table: "BirthCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "IsDisabledType",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KinshipOfTheNewborn",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LicenseNo",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LicenseYear",
                table: "BirthCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MotherAge",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "MotherBOD",
                table: "BirthCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "MotherFName",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MotherFullName",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotherJob",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MotherLName",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MotherMName",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MotherMobile",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MotherNationality",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MotherReligion",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NahiaID",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationalID",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NationalIdFor",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NoAbortion",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfBirth",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PageNumber",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassportNo",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlaceOfBirth",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "QrCode",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RationCard",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecordNumber",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Relative",
                table: "BirthCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SecondStage",
                table: "BirthCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "StillBirth",
                table: "BirthCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "VillageID",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Disables",
                columns: table => new
                {
                    DisableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisableCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disables", x => x.DisableId);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    DohId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "Dohs",
                columns: table => new
                {
                    DohId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DohName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dohs", x => x.DohId);
                });

            migrationBuilder.CreateTable(
                name: "FacilityTypes",
                columns: table => new
                {
                    FacilityTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityTypes", x => x.FacilityTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Governorates",
                columns: table => new
                {
                    GovernorateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GovernorateName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorates", x => x.GovernorateId);
                });

            migrationBuilder.CreateTable(
                name: "HealthInstitutions",
                columns: table => new
                {
                    HealthInstitutionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthInstitutionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    DohId = table.Column<int>(type: "int", nullable: false),
                    FacilityTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthInstitutions", x => x.HealthInstitutionId);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "Nahias",
                columns: table => new
                {
                    NahiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NahiaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    DohId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nahias", x => x.NahiaId);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    NationalityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.NationalityId);
                });

            migrationBuilder.CreateTable(
                name: "Religions",
                columns: table => new
                {
                    ReligionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReligionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religions", x => x.ReligionId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BirthCertificates_FatherJob",
                table: "BirthCertificates",
                column: "FatherJob");

            migrationBuilder.AddForeignKey(
                name: "FK_BirthCertificates_Jobs_FatherJob",
                table: "BirthCertificates",
                column: "FatherJob",
                principalTable: "Jobs",
                principalColumn: "JobId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BirthCertificates_Jobs_FatherJob",
                table: "BirthCertificates");

            migrationBuilder.DropTable(
                name: "Disables");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Dohs");

            migrationBuilder.DropTable(
                name: "FacilityTypes");

            migrationBuilder.DropTable(
                name: "Governorates");

            migrationBuilder.DropTable(
                name: "HealthInstitutions");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Nahias");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "Religions");

            migrationBuilder.DropIndex(
                name: "IX_BirthCertificates_FatherJob",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "Alive",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "AllPDFs",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "Approval",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "BHour",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "BOD",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "BODText",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "BabyWeight",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "BirthOccurredBy",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "BirthPerformerName",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "BirthPerformerWorkingAddress",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "BirthType",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "BornAliveThenDied",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "BornDisable",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "CivilStatusDirectorate",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "Creator",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "DistrictID",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "DocumentType",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "DohID",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "DurationOfPregnancy",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyDOH",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyDistrict",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyGovernorate",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyHomeNo",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyMahala",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyNahia",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyPHC",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FamilySector",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyZigag",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FatherAge",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FatherBOD",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FatherFName",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FatherFullName",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FatherJob",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FatherLName",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FatherMName",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FatherMobile",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FatherNationality",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FatherReligion",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "FirstStage",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "GovernorateCivilStatusDirectorate",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "GovernorateID",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "HospitalManagerName",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "HospitalManagerSig",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "ImgBirthCertificate",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "ImgFatherUnifiedNationalIdBack",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "ImgFatherUnifiedNationalIdFront",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "ImgMarriageCertificate",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "ImgMotherUnifiedNationalIdBack",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "ImgMotherUnifiedNationalIdFront",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "ImgResidencyCardBack",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "ImgResidencyCardFront",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "InformerJobTitle",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "InformerName",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "IsDisabled",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "IsDisabledType",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "KinshipOfTheNewborn",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "LicenseNo",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "LicenseYear",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "MotherAge",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "MotherBOD",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "MotherFName",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "MotherFullName",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "MotherJob",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "MotherLName",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "MotherMName",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "MotherMobile",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "MotherNationality",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "MotherReligion",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "NahiaID",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "NationalID",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "NationalIdFor",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "NoAbortion",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "NumberOfBirth",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "PageNumber",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "PassportNo",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "PlaceOfBirth",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "QrCode",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "RationCard",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "RecordNumber",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "Relative",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "SecondStage",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "StillBirth",
                table: "BirthCertificates");

            migrationBuilder.DropColumn(
                name: "VillageID",
                table: "BirthCertificates");

            migrationBuilder.AlterColumn<string>(
                name: "ChildName",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CertificateNo",
                table: "BirthCertificates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
