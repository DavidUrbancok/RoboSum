#nullable disable

namespace RoboSum.Persistence.PostgreSQL.Migrations;

using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

/// <inheritdoc cref="Migration"/>
public partial class InitialMigration : Migration
{
    /// <inheritdoc cref="Migration.Up(MigrationBuilder)"/>
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Competitions",
            columns: table => new
            {
                Id = table.Column<int>(type: "integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                RoboSum = table.Column<bool>(type: "boolean", nullable: false),
                RoboCross = table.Column<bool>(type: "boolean", nullable: false),
                RegistrationId = table.Column<int>(type: "integer", nullable: false),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Competitions", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Schools",
            columns: table => new
            {
                Id = table.Column<int>(type: "integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                AddressId = table.Column<int>(type: "integer", nullable: false),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Schools", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Registrations",
            columns: table => new
            {
                Id = table.Column<int>(type: "integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                TeamId = table.Column<int>(type: "integer", nullable: false),
                RegistrationYear = table.Column<int>(type: "integer", nullable: false),
                Remarks = table.Column<string>(type: "text", nullable: true),
                CompetitionId = table.Column<int>(type: "integer", nullable: false),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Registrations", x => x.Id);
                table.ForeignKey(
                    name: "FK_Registrations_Competitions_CompetitionId",
                    column: x => x.CompetitionId,
                    principalTable: "Competitions",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Addresses",
            columns: table => new
            {
                Id = table.Column<int>(type: "integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                Street = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                HouseNumber = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                City = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                ZipCode = table.Column<int>(type: "integer", maxLength: 16, nullable: false),
                Country = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                SchoolId = table.Column<int>(type: "integer", nullable: false),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Addresses", x => x.Id);
                table.ForeignKey(
                    name: "FK_Addresses_Schools_SchoolId",
                    column: x => x.SchoolId,
                    principalTable: "Schools",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Person",
            columns: table => new
            {
                Id = table.Column<int>(type: "integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                FirstName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                LastName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                Discriminator = table.Column<string>(type: "text", nullable: false),
                Grade = table.Column<int>(type: "integer", nullable: true),
                TeamId = table.Column<int>(type: "integer", nullable: true),
                SchoolId = table.Column<int>(type: "integer", nullable: true),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Person", x => x.Id);
                table.ForeignKey(
                    name: "FK_Person_Schools_SchoolId",
                    column: x => x.SchoolId,
                    principalTable: "Schools",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Teams",
            columns: table => new
            {
                Id = table.Column<int>(type: "integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                Email = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                SchoolId = table.Column<int>(type: "integer", nullable: false),
                TeacherId = table.Column<int>(type: "integer", nullable: false),
                RegistrationId = table.Column<int>(type: "integer", nullable: false),
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Teams", x => x.Id);
                table.ForeignKey(
                    name: "FK_Teams_Person_TeacherId",
                    column: x => x.TeacherId,
                    principalTable: "Person",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Teams_Registrations_RegistrationId",
                    column: x => x.RegistrationId,
                    principalTable: "Registrations",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Teams_Schools_SchoolId",
                    column: x => x.SchoolId,
                    principalTable: "Schools",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_Addresses_SchoolId",
            table: "Addresses",
            column: "SchoolId",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_Person_SchoolId",
            table: "Person",
            column: "SchoolId");

        migrationBuilder.CreateIndex(
            name: "IX_Person_TeamId",
            table: "Person",
            column: "TeamId");

        migrationBuilder.CreateIndex(
            name: "IX_Registrations_CompetitionId",
            table: "Registrations",
            column: "CompetitionId",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_Teams_RegistrationId",
            table: "Teams",
            column: "RegistrationId",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_Teams_SchoolId",
            table: "Teams",
            column: "SchoolId");

        migrationBuilder.CreateIndex(
            name: "IX_Teams_TeacherId",
            table: "Teams",
            column: "TeacherId");

        migrationBuilder.AddForeignKey(
            name: "FK_Person_Teams_TeamId",
            table: "Person",
            column: "TeamId",
            principalTable: "Teams",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }

    /// <inheritdoc cref="Migration.Down(MigrationBuilder)"/>
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Person_Teams_TeamId",
            table: "Person");

        migrationBuilder.DropTable(
            name: "Addresses");

        migrationBuilder.DropTable(
            name: "Teams");

        migrationBuilder.DropTable(
            name: "Person");

        migrationBuilder.DropTable(
            name: "Registrations");

        migrationBuilder.DropTable(
            name: "Schools");

        migrationBuilder.DropTable(
            name: "Competitions");
    }
}
