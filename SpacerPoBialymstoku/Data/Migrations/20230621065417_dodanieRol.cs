using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpacerPoBialymstoku.Data.Migrations
{
    public partial class dodanieRol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "367d6042-41a2-4097-b246-fb359c733ba9", "17ac66ca-8139-46f8-8c1b-033dc31e8289", "Admin", "ADMIN" },
                    { "4b7f311d-1710-4b84-bf83-1b0cd1f0a4d4", "62b00b9e-21a1-4ae0-96e1-aafd96d5bee0", "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5a688171-6ffc-4aa5-ac90-9d16171b8424", 0, "3f501250-19e4-4cdd-bf7b-60b97d341bbf", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEPf7vgH7MsOYbkcEJ13Hl5DUEGY6h/+/21aK8J0rwOLgv2iy6pD1f8hHzz6XWrdgIw==", null, false, "b7dee563-ffcc-4073-987b-8c0b9966c413", false, "admin" },
                    { "c573af96-a3a6-4d91-a473-561164964964", 0, "5ee25944-15a6-489e-9414-29fea393b804", "user@gmail.com", true, false, null, "USER@GMAIL.COM", "USER", "AQAAAAEAACcQAAAAELZaUKiQ9izvO0+VEwPw5ddSUOJAuLif9SjFeyatPiaAeDIG9WGG5nUvGkUzboBzIw==", null, false, "84ad1702-5543-4e9f-98d2-e81064145e85", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "367d6042-41a2-4097-b246-fb359c733ba9", "5a688171-6ffc-4aa5-ac90-9d16171b8424" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4b7f311d-1710-4b84-bf83-1b0cd1f0a4d4", "c573af96-a3a6-4d91-a473-561164964964" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "367d6042-41a2-4097-b246-fb359c733ba9", "5a688171-6ffc-4aa5-ac90-9d16171b8424" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4b7f311d-1710-4b84-bf83-1b0cd1f0a4d4", "c573af96-a3a6-4d91-a473-561164964964" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "367d6042-41a2-4097-b246-fb359c733ba9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b7f311d-1710-4b84-bf83-1b0cd1f0a4d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a688171-6ffc-4aa5-ac90-9d16171b8424");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c573af96-a3a6-4d91-a473-561164964964");
        }
    }
}
