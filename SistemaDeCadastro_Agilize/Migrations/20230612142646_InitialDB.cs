using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SistemaDeCadastro_Agilize.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Associate",
                columns: table => new
                {
                    IdAssociate = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ChnAssociate = table.Column<long>(type: "bigint", nullable: false),
                    ValidadeAssociate = table.Column<string>(type: "text", nullable: false),
                    CategoryAssociate = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    FirstLicenseAssociate = table.Column<string>(type: "text", nullable: true),
                    NationalityAssociate = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NamePerson = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TelPerson = table.Column<int>(type: "integer", nullable: false),
                    EmailPerson = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CpfPerson = table.Column<long>(type: "bigint", nullable: false),
                    SexoPerson = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    RgPerson = table.Column<long>(type: "bigint", nullable: false),
                    DateBornPerson = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NeighborhoodPerson = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NumberPerson = table.Column<int>(type: "integer", nullable: false),
                    UFPerson = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    CepPerson = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Associate", x => x.IdAssociate);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    IdEmployee = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Password = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NamePerson = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    TelPerson = table.Column<int>(type: "integer", nullable: false),
                    EmailPerson = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CpfPerson = table.Column<long>(type: "bigint", nullable: false),
                    SexoPerson = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    RgPerson = table.Column<long>(type: "bigint", nullable: false),
                    DateBornPerson = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NeighborhoodPerson = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    NumberPerson = table.Column<int>(type: "integer", nullable: false),
                    UFPerson = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    CepPerson = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.IdEmployee);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    IdVehicle = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdAssociate = table.Column<long>(type: "bigint", nullable: false),
                    Brand = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    Version = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    Fuel = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    NF = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    Plate = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: false),
                    Model = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    NumberDoors = table.Column<int>(type: "integer", nullable: false),
                    Color = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    Renavam = table.Column<long>(type: "bigint", nullable: false),
                    Chassi = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    FipeCode = table.Column<long>(type: "bigint", nullable: false),
                    FipeValue = table.Column<decimal>(type: "numeric", nullable: false),
                    VehicleNationality = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    AssociateModelIdAssociate = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.IdVehicle);
                    table.UniqueConstraint("AK_Vehicle_IdAssociate", x => x.IdAssociate);
                    table.ForeignKey(
                        name: "FK_Vehicle_Associate_AssociateModelIdAssociate",
                        column: x => x.AssociateModelIdAssociate,
                        principalTable: "Associate",
                        principalColumn: "IdAssociate");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_AssociateModelIdAssociate",
                table: "Vehicle",
                column: "AssociateModelIdAssociate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "Associate");
        }
    }
}
