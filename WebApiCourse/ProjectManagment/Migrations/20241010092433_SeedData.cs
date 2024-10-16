using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManagment.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Description", "Field", "ImageUrl", "Name" },
                values: new object[] { new Guid("a88e2ba1-f7cc-4d6b-a995-69575dc7e8b7"), "Another Web Application Programming Interface", "Information Technology", null, "Asp.Net Core Web API Project 2" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Description", "Field", "ImageUrl", "Name" },
                values: new object[] { new Guid("f98e1ba1-f7cc-4d6b-a995-69575dc7e8b7"), "Web Application Programming Interface", "Computer Science", null, "Asp.Net Core Web API Project 1" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "FirstName", "LastName", "Position", "ProjectId" },
                values: new object[] { new Guid("6595d486-6a51-49c3-b4a3-b55f432f2a61"), 24, "Emre", "CEVİK", "Junior Developer", new Guid("a88e2ba1-f7cc-4d6b-a995-69575dc7e8b7") });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "FirstName", "LastName", "Position", "ProjectId" },
                values: new object[] { new Guid("d66f8e6b-b499-4f68-8595-afeb4d95a5db"), 23, "Taner", "Bilinmiyor", "Mid Developer", new Guid("f98e1ba1-f7cc-4d6b-a995-69575dc7e8b7") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("6595d486-6a51-49c3-b4a3-b55f432f2a61"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("d66f8e6b-b499-4f68-8595-afeb4d95a5db"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: new Guid("a88e2ba1-f7cc-4d6b-a995-69575dc7e8b7"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: new Guid("f98e1ba1-f7cc-4d6b-a995-69575dc7e8b7"));
        }
    }
}
