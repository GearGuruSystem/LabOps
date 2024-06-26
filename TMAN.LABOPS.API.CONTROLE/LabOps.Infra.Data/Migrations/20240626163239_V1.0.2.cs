using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabOps.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class V102 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cl_IdEquipamentos",
                table: "Tb_Laboratorio");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Cl_IdEquipamentos",
                table: "Tb_Laboratorio",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
