using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesViewer.Migrations
{
    public partial class OrdersAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "CinemaId1",
                table: "Movies",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CinemaId",
                table: "Cinemas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId1",
                table: "Movies",
                column: "CinemaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId1",
                table: "Movies",
                column: "CinemaId1",
                principalTable: "Cinemas",
                principalColumn: "CinemaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId1",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CinemaId1",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CinemaId1",
                table: "Movies");

            migrationBuilder.AlterColumn<int>(
                name: "CinemaId",
                table: "Cinemas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "CinemaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
