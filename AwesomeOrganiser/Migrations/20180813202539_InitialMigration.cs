using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AwesomeOrganiser.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaskTitle = table.Column<string>(nullable: true),
                    TaskDescription = table.Column<string>(nullable: true),
                    TaskDueDate = table.Column<DateTime>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false),
                    TaskComments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskId);
                });

                //migrationBuilder.InsertData(
                //     table: "Cars",
                //columns: new[] { "CarId", "Make", "Model" },
                //values: new object[] { 1, "Ferrari", "F40" });

                //migrationBuilder.InsertData(
                //    table: "Cars",
                //    columns: new[] { "CarId", "Make", "Model" },
                //    values: new object[] { 2, "Ferrari", "F50" });

                //migrationBuilder.InsertData(
                //    table: "Cars",
                //    columns: new[] { "CarId", "Make", "Model" },
                //    values: new object[] { 3, "Labourghini", "Countach" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
