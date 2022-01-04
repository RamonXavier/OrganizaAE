using Microsoft.EntityFrameworkCore.Migrations;

namespace OrganizaAE.Migrations
{
    public partial class modify_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdMounth",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "IdSocial",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Payments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMounth",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdSocial",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
