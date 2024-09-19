using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eff1.Migrations
{
    /// <inheritdoc />
    public partial class test4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Author_NationalityId",
                table: "Author",
                column: "NationalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Author_Nationality_NationalityId",
                table: "Author",
                column: "NationalityId",
                principalTable: "Nationality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_Nationality_NationalityId",
                table: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Author_NationalityId",
                table: "Author");
        }
    }
}
