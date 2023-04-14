using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "amountOwed",
                table: "AbpUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "amountOwes",
                table: "AbpUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "isRegistered",
                table: "AbpUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "totalAmount",
                table: "AbpUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "amountOwed",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "amountOwes",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "isRegistered",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "totalAmount",
                table: "AbpUsers");
        }
    }
}
