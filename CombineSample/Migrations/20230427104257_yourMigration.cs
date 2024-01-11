using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CombineSample.Migrations
{
    /// <inheritdoc />
    public partial class yourMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee_Details",
                columns: table => new
                {
                    employee_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_working_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_technology = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_project = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_training_start_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_training_end_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_vacation_start_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_vacation_end_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_trainer_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_vacation_req = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_vacation_reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employee_Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Details", x => x.employee_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_Details");
        }
    }
}
