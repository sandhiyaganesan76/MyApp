using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CombineSample.Migrations
{
    /// <inheritdoc />
    public partial class yourmigrations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "employee_project",
                table: "Employee_Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AddEmployee_Details",
                columns: table => new
                {
                    employeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employeeEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employeeMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employmentStartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employeeLocation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddEmployee_Details", x => x.employeeId);
                });

            migrationBuilder.CreateTable(
                name: "Manager_Details",
                columns: table => new
                {
                    manager_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    manager_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manager_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manager_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manager_password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manager_Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager_Details", x => x.manager_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddEmployee_Details");

            migrationBuilder.DropTable(
                name: "Manager_Details");

            migrationBuilder.DropColumn(
                name: "employee_project",
                table: "Employee_Details");
        }
    }
}
