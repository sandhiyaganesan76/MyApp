using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CombineSample.Migrations
{
    /// <inheritdoc />
    public partial class yourmigration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "manager_password",
                table: "Manager_Details",
                newName: "managerPassword");

            migrationBuilder.RenameColumn(
                name: "manager_number",
                table: "Manager_Details",
                newName: "managerNumber");

            migrationBuilder.RenameColumn(
                name: "manager_name",
                table: "Manager_Details",
                newName: "managerName");

            migrationBuilder.RenameColumn(
                name: "manager_email",
                table: "Manager_Details",
                newName: "managerEmail");

            migrationBuilder.RenameColumn(
                name: "manager_Image",
                table: "Manager_Details",
                newName: "managerImage");

            migrationBuilder.RenameColumn(
                name: "manager_id",
                table: "Manager_Details",
                newName: "managerId");

            migrationBuilder.RenameColumn(
                name: "employee_working_status",
                table: "Employee_Details",
                newName: "leaveReason");

            migrationBuilder.RenameColumn(
                name: "employee_vacation_start_time",
                table: "Employee_Details",
                newName: "employeeWorkingStatus");

            migrationBuilder.RenameColumn(
                name: "employee_vacation_req",
                table: "Employee_Details",
                newName: "employeeProject");

            migrationBuilder.RenameColumn(
                name: "employee_vacation_reason",
                table: "Employee_Details",
                newName: "employeePassword");

            migrationBuilder.RenameColumn(
                name: "employee_vacation_end_time",
                table: "Employee_Details",
                newName: "employeeNumber");

            migrationBuilder.RenameColumn(
                name: "employee_technology",
                table: "Employee_Details",
                newName: "employeeName");

            migrationBuilder.RenameColumn(
                name: "employee_project",
                table: "Employee_Details",
                newName: "employeeLeaveStartTime");

            migrationBuilder.RenameColumn(
                name: "employee_password",
                table: "Employee_Details",
                newName: "employeeLeaveEndTime");

            migrationBuilder.RenameColumn(
                name: "employee_number",
                table: "Employee_Details",
                newName: "employeeLeave");

            migrationBuilder.RenameColumn(
                name: "employee_name",
                table: "Employee_Details",
                newName: "employeeEmail");

            migrationBuilder.RenameColumn(
                name: "employee_email",
                table: "Employee_Details",
                newName: "employeeDOB");

            migrationBuilder.RenameColumn(
                name: "employee_Image",
                table: "Employee_Details",
                newName: "employeeImage");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "Employee_Details",
                newName: "employeeId");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeMartialStatus",
                table: "Employee_Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "employeeAge",
                table: "Employee_Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeMartialStatus",
                table: "AddEmployee_Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "employeeAge",
                table: "AddEmployee_Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "employeeDOB",
                table: "AddEmployee_Details",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeMartialStatus",
                table: "Employee_Details");

            migrationBuilder.DropColumn(
                name: "employeeAge",
                table: "Employee_Details");

            migrationBuilder.DropColumn(
                name: "EmployeeMartialStatus",
                table: "AddEmployee_Details");

            migrationBuilder.DropColumn(
                name: "employeeAge",
                table: "AddEmployee_Details");

            migrationBuilder.DropColumn(
                name: "employeeDOB",
                table: "AddEmployee_Details");

            migrationBuilder.RenameColumn(
                name: "managerPassword",
                table: "Manager_Details",
                newName: "manager_password");

            migrationBuilder.RenameColumn(
                name: "managerNumber",
                table: "Manager_Details",
                newName: "manager_number");

            migrationBuilder.RenameColumn(
                name: "managerName",
                table: "Manager_Details",
                newName: "manager_name");

            migrationBuilder.RenameColumn(
                name: "managerImage",
                table: "Manager_Details",
                newName: "manager_Image");

            migrationBuilder.RenameColumn(
                name: "managerEmail",
                table: "Manager_Details",
                newName: "manager_email");

            migrationBuilder.RenameColumn(
                name: "managerId",
                table: "Manager_Details",
                newName: "manager_id");

            migrationBuilder.RenameColumn(
                name: "leaveReason",
                table: "Employee_Details",
                newName: "employee_working_status");

            migrationBuilder.RenameColumn(
                name: "employeeWorkingStatus",
                table: "Employee_Details",
                newName: "employee_vacation_start_time");

            migrationBuilder.RenameColumn(
                name: "employeeProject",
                table: "Employee_Details",
                newName: "employee_vacation_req");

            migrationBuilder.RenameColumn(
                name: "employeePassword",
                table: "Employee_Details",
                newName: "employee_vacation_reason");

            migrationBuilder.RenameColumn(
                name: "employeeNumber",
                table: "Employee_Details",
                newName: "employee_vacation_end_time");

            migrationBuilder.RenameColumn(
                name: "employeeName",
                table: "Employee_Details",
                newName: "employee_technology");

            migrationBuilder.RenameColumn(
                name: "employeeLeaveStartTime",
                table: "Employee_Details",
                newName: "employee_project");

            migrationBuilder.RenameColumn(
                name: "employeeLeaveEndTime",
                table: "Employee_Details",
                newName: "employee_password");

            migrationBuilder.RenameColumn(
                name: "employeeLeave",
                table: "Employee_Details",
                newName: "employee_number");

            migrationBuilder.RenameColumn(
                name: "employeeImage",
                table: "Employee_Details",
                newName: "employee_Image");

            migrationBuilder.RenameColumn(
                name: "employeeEmail",
                table: "Employee_Details",
                newName: "employee_name");

            migrationBuilder.RenameColumn(
                name: "employeeDOB",
                table: "Employee_Details",
                newName: "employee_email");

            migrationBuilder.RenameColumn(
                name: "employeeId",
                table: "Employee_Details",
                newName: "employee_id");
        }
    }
}
