using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day8.Migrations
{
    /// <inheritdoc />
    public partial class makeManagerIdNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SalesOffices_ManagerId",
                table: "SalesOffices");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "SalesOffices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOffices_ManagerId",
                table: "SalesOffices",
                column: "ManagerId",
                unique: true,
                filter: "[ManagerId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SalesOffices_ManagerId",
                table: "SalesOffices");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "SalesOffices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesOffices_ManagerId",
                table: "SalesOffices",
                column: "ManagerId",
                unique: true);
        }
    }
}
