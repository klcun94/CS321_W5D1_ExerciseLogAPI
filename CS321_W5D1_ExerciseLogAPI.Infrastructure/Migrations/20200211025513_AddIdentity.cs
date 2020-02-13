using Microsoft.EntityFrameworkCore.Migrations;

namespace CS321_W5D1_ExerciseLogAPI.Infrastructure.Migrations
{
    public partial class AddIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                column: "ConcurrencyStamp",
                value: "976669fc-63cb-4445-8430-cd177caaa1c9");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                column: "ConcurrencyStamp",
                value: "91639cec-cd9a-4109-b17c-22508b645f61");
        }
    }
}
