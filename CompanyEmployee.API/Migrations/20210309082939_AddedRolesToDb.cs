using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyEmployee.API.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "360e992e-ccad-4850-a6db-cd8e3971fcdf", "daeca0dd-8f6c-4a3b-b8a7-590a364de4aa", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "275a3a01-c41a-4213-b338-502f8220d692", "77e62e83-2eb7-4379-b079-3727f3d7c9b4", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "275a3a01-c41a-4213-b338-502f8220d692");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "360e992e-ccad-4850-a6db-cd8e3971fcdf");
        }
    }
}
