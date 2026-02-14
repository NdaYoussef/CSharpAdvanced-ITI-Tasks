using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day8.Migrations
{
    /// <inheritdoc />
    public partial class EditManyToManyRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PropertiesOwner_PropertyId",
                table: "PropertiesOwner",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertiesOwner_Owners_OwnerId",
                table: "PropertiesOwner",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertiesOwner_Properties_PropertyId",
                table: "PropertiesOwner",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertiesOwner_Owners_OwnerId",
                table: "PropertiesOwner");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertiesOwner_Properties_PropertyId",
                table: "PropertiesOwner");

            migrationBuilder.DropIndex(
                name: "IX_PropertiesOwner_PropertyId",
                table: "PropertiesOwner");
        }
    }
}
