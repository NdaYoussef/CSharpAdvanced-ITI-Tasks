using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day8.Migrations
{
    /// <inheritdoc />
    public partial class firstCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyOwner",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    OwnershipPercentage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyOwner", x => new { x.OwnerId, x.PropertyId });
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalesOfficeId = table.Column<int>(type: "int", nullable: false),
                    IsManager = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesOffices",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOffices", x => x.Number);
                    table.ForeignKey(
                        name: "FK_SalesOffices_Employees_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalesOfficeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_SalesOffices_SalesOfficeId",
                        column: x => x.SalesOfficeId,
                        principalTable: "SalesOffices",
                        principalColumn: "Number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SalesOfficeId",
                table: "Employees",
                column: "SalesOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_SalesOfficeId",
                table: "Properties",
                column: "SalesOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOffices_ManagerId",
                table: "SalesOffices",
                column: "ManagerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_SalesOffices_SalesOfficeId",
                table: "Employees",
                column: "SalesOfficeId",
                principalTable: "SalesOffices",
                principalColumn: "Number",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_SalesOffices_SalesOfficeId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "PropertyOwner");

            migrationBuilder.DropTable(
                name: "SalesOffices");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
