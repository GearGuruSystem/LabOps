using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabOps.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class V101 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_EquipamentoCaracteristica_Tb_CaracteristicaTipo_Cl_CaracteristicaTipo",
                table: "Tb_EquipamentoCaracteristica");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_EquipamentoCaracteristica_Tb_CaracteristicaValor_Cl_CaracteristicaValor",
                table: "Tb_EquipamentoCaracteristica");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_EquipamentoCaracteristica_Tb_Equipamento_EquipamentoId",
                table: "Tb_EquipamentoCaracteristica");

            migrationBuilder.DropIndex(
                name: "IX_Tb_EquipamentoCaracteristica_EquipamentoId",
                table: "Tb_EquipamentoCaracteristica");

            migrationBuilder.DropColumn(
                name: "EquipamentoId",
                table: "Tb_EquipamentoCaracteristica");

            migrationBuilder.RenameColumn(
                name: "Cl_Equipamento",
                table: "Tb_EquipamentoCaracteristica",
                newName: "Cl_IdEquipamentos");

            migrationBuilder.RenameColumn(
                name: "Cl_CaracteristicaValor",
                table: "Tb_EquipamentoCaracteristica",
                newName: "Cl_IdCaracteristicaValor");

            migrationBuilder.RenameColumn(
                name: "Cl_CaracteristicaTipo",
                table: "Tb_EquipamentoCaracteristica",
                newName: "Cl_IdCaracteristicaTipo");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_EquipamentoCaracteristica_Cl_CaracteristicaValor",
                table: "Tb_EquipamentoCaracteristica",
                newName: "IX_Tb_EquipamentoCaracteristica_Cl_IdCaracteristicaValor");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_EquipamentoCaracteristica_Cl_CaracteristicaTipo",
                table: "Tb_EquipamentoCaracteristica",
                newName: "IX_Tb_EquipamentoCaracteristica_Cl_IdCaracteristicaTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_EquipamentoCaracteristica_Cl_IdEquipamentos",
                table: "Tb_EquipamentoCaracteristica",
                column: "Cl_IdEquipamentos");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_EquipamentoCaracteristica_Tb_CaracteristicaTipo_Cl_IdCaracteristicaTipo",
                table: "Tb_EquipamentoCaracteristica",
                column: "Cl_IdCaracteristicaTipo",
                principalTable: "Tb_CaracteristicaTipo",
                principalColumn: "Cl_IdCaracteristicaTipo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_EquipamentoCaracteristica_Tb_CaracteristicaValor_Cl_IdCaracteristicaValor",
                table: "Tb_EquipamentoCaracteristica",
                column: "Cl_IdCaracteristicaValor",
                principalTable: "Tb_CaracteristicaValor",
                principalColumn: "Cl_IdCaracteristicaValor");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_EquipamentoCaracteristica_Tb_Equipamento_Cl_IdEquipamentos",
                table: "Tb_EquipamentoCaracteristica",
                column: "Cl_IdEquipamentos",
                principalTable: "Tb_Equipamento",
                principalColumn: "Cl_IdEquipamento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_EquipamentoCaracteristica_Tb_CaracteristicaTipo_Cl_IdCaracteristicaTipo",
                table: "Tb_EquipamentoCaracteristica");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_EquipamentoCaracteristica_Tb_CaracteristicaValor_Cl_IdCaracteristicaValor",
                table: "Tb_EquipamentoCaracteristica");

            migrationBuilder.DropForeignKey(
                name: "FK_Tb_EquipamentoCaracteristica_Tb_Equipamento_Cl_IdEquipamentos",
                table: "Tb_EquipamentoCaracteristica");

            migrationBuilder.DropIndex(
                name: "IX_Tb_EquipamentoCaracteristica_Cl_IdEquipamentos",
                table: "Tb_EquipamentoCaracteristica");

            migrationBuilder.RenameColumn(
                name: "Cl_IdEquipamentos",
                table: "Tb_EquipamentoCaracteristica",
                newName: "Cl_Equipamento");

            migrationBuilder.RenameColumn(
                name: "Cl_IdCaracteristicaValor",
                table: "Tb_EquipamentoCaracteristica",
                newName: "Cl_CaracteristicaValor");

            migrationBuilder.RenameColumn(
                name: "Cl_IdCaracteristicaTipo",
                table: "Tb_EquipamentoCaracteristica",
                newName: "Cl_CaracteristicaTipo");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_EquipamentoCaracteristica_Cl_IdCaracteristicaValor",
                table: "Tb_EquipamentoCaracteristica",
                newName: "IX_Tb_EquipamentoCaracteristica_Cl_CaracteristicaValor");

            migrationBuilder.RenameIndex(
                name: "IX_Tb_EquipamentoCaracteristica_Cl_IdCaracteristicaTipo",
                table: "Tb_EquipamentoCaracteristica",
                newName: "IX_Tb_EquipamentoCaracteristica_Cl_CaracteristicaTipo");

            migrationBuilder.AddColumn<long>(
                name: "EquipamentoId",
                table: "Tb_EquipamentoCaracteristica",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_EquipamentoCaracteristica_EquipamentoId",
                table: "Tb_EquipamentoCaracteristica",
                column: "EquipamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_EquipamentoCaracteristica_Tb_CaracteristicaTipo_Cl_CaracteristicaTipo",
                table: "Tb_EquipamentoCaracteristica",
                column: "Cl_CaracteristicaTipo",
                principalTable: "Tb_CaracteristicaTipo",
                principalColumn: "Cl_IdCaracteristicaTipo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_EquipamentoCaracteristica_Tb_CaracteristicaValor_Cl_CaracteristicaValor",
                table: "Tb_EquipamentoCaracteristica",
                column: "Cl_CaracteristicaValor",
                principalTable: "Tb_CaracteristicaValor",
                principalColumn: "Cl_IdCaracteristicaValor");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_EquipamentoCaracteristica_Tb_Equipamento_EquipamentoId",
                table: "Tb_EquipamentoCaracteristica",
                column: "EquipamentoId",
                principalTable: "Tb_Equipamento",
                principalColumn: "Cl_IdEquipamento",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
