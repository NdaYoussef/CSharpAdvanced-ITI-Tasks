using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day8.Migrations
{
    /// <inheritdoc />
    public partial class AddPropertyOwnerDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertyOwner",
                table: "PropertyOwner");

            migrationBuilder.RenameTable(
                name: "PropertyOwner",
                newName: "PropertiesOwner");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertiesOwner",
                table: "PropertiesOwner",
                columns: new[] { "OwnerId", "PropertyId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertiesOwner",
                table: "PropertiesOwner");

            migrationBuilder.RenameTable(
                name: "PropertiesOwner",
                newName: "PropertyOwner");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertyOwner",
                table: "PropertyOwner",
                columns: new[] { "OwnerId", "PropertyId" });
        }
    }
}
