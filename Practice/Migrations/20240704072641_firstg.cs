using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Practice.Migrations
{
    /// <inheritdoc />
    public partial class firstg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dept",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deptname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dept", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emp", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Dept",
                columns: new[] { "Id", "Deptname" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "Engineering" },
                    { 3, "HR" },
                    { 4, "Finance" },
                    { 5, "Talent Equisition" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dept");

            migrationBuilder.DropTable(
                name: "Emp");
        }
    }
}
