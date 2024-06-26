using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabOps.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class V122 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cl_Hostname",
                table: "Tb_Equipamento",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cl_Inventario",
                table: "Tb_Equipamento",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cl_SerialNumber",
                table: "Tb_Equipamento",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cl_Hostname",
                table: "Tb_Equipamento");

            migrationBuilder.DropColumn(
                name: "Cl_Inventario",
                table: "Tb_Equipamento");

            migrationBuilder.DropColumn(
                name: "Cl_SerialNumber",
                table: "Tb_Equipamento");
        }
    }
}
