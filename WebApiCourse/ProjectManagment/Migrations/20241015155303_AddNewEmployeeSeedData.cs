using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectManagment.Migrations
{
    public partial class AddNewEmployeeSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "FirstName", "LastName", "Position", "ProjectId" },
                values: new object[] { new Guid("e47a2f9b-7e6a-4b4e-bf78-d9e8e2d5cbb3"), 31, "Ali", "Midci", "Mid Developer", new Guid("f98e1ba1-f7cc-4d6b-a995-69575dc7e8b7") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("e47a2f9b-7e6a-4b4e-bf78-d9e8e2d5cbb3"));
        }
    }
}
