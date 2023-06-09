﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreateUser",
                columns: table => new
                {
                    CreateUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreateUser", x => x.CreateUserId);
                });

            migrationBuilder.InsertData(
                table: "CreateUser",
                columns: new[] { "CreateUserId", "CompanyName", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { "Jacobjames310", "James Trucking", "jacobjames339@yahoo.com", "Jacob", "James", "jjames339" },
                    { "NyckJ111", "Johnson Ice-Cream", "njohnson104@yahoo.com", "Nyck", "Johnson", "njohnson220" },
                    { "Roshellec494", "Chen Publishing", "rchen1020@gmail.com", "Roshelle", "Chen", "rchen191" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreateUser");
        }
    }
}
