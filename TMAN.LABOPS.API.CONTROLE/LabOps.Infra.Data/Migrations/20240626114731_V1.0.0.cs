using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabOps.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class V100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_CaracteristicaTipo",
                columns: table => new
                {
                    Cl_IdCaracteristicaTipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cl_Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cl_UsuarioAtualizacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cl_AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_CaracteristicaTipo", x => x.Cl_IdCaracteristicaTipo);
                });

            migrationBuilder.CreateTable(
                name: "Tb_CaracteristicaValor",
                columns: table => new
                {
                    Cl_IdCaracteristicaValor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cl_Valor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cl_UsuarioAtualizaco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cl_AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_CaracteristicaValor", x => x.Cl_IdCaracteristicaValor);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Fabricante",
                columns: table => new
                {
                    Cl_IdFabricante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cl_Nome = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Cl_UsuarioAtualizacao = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Cl_AtualizadoEm = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Fabricante", x => x.Cl_IdFabricante);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Laboratorio",
                columns: table => new
                {
                    Cl_IdLaboratorio = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cl_Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cl_UsuarioResponsavel = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Cl_ChaveDoResponsavel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cl_UsuarioAtualizacao = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cl_AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cl_IdEquipamentos = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Laboratorio", x => x.Cl_IdLaboratorio);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Situacao",
                columns: table => new
                {
                    Cl_IdSituacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cl_Situacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cl_UsuarioAtualizacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cl_AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Situacao", x => x.Cl_IdSituacao);
                });

            migrationBuilder.CreateTable(
                name: "Tb_TipoEquipamento",
                columns: table => new
                {
                    Cl_IdTipoEquipamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cl_Descricao = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Cl_UsuarioAtualizacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cl_AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_TipoEquipamento", x => x.Cl_IdTipoEquipamento);
                });

            migrationBuilder.CreateTable(
                name: "Tb_CaracteristicaTipoTipoEquipamento",
                columns: table => new
                {
                    Cl_IdCaracteristicaTipo = table.Column<int>(type: "int", nullable: false),
                    Cl_IdTipoEquipamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_CaracteristicaTipoTipoEquipamento", x => new { x.Cl_IdCaracteristicaTipo, x.Cl_IdTipoEquipamento });
                    table.ForeignKey(
                        name: "FK_Tb_CaracteristicaTipoTipoEquipamento_Tb_CaracteristicaTipo_Cl_IdCaracteristicaTipo",
                        column: x => x.Cl_IdCaracteristicaTipo,
                        principalTable: "Tb_CaracteristicaTipo",
                        principalColumn: "Cl_IdCaracteristicaTipo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_CaracteristicaTipoTipoEquipamento_Tb_TipoEquipamento_Cl_IdTipoEquipamento",
                        column: x => x.Cl_IdTipoEquipamento,
                        principalTable: "Tb_TipoEquipamento",
                        principalColumn: "Cl_IdTipoEquipamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Equipamento",
                columns: table => new
                {
                    Cl_IdEquipamento = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cl_Nome = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Cl_IdSituacao = table.Column<int>(type: "int", nullable: false),
                    Cl_IdTipoEquipamento = table.Column<int>(type: "int", nullable: false),
                    Cl_IdFabricante = table.Column<int>(type: "int", nullable: false),
                    Cl_UsuarioInsercao = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cl_AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LaboratorioId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Equipamento", x => x.Cl_IdEquipamento);
                    table.ForeignKey(
                        name: "FK_Tb_Equipamento_Tb_Fabricante_Cl_IdFabricante",
                        column: x => x.Cl_IdFabricante,
                        principalTable: "Tb_Fabricante",
                        principalColumn: "Cl_IdFabricante");
                    table.ForeignKey(
                        name: "FK_Tb_Equipamento_Tb_Laboratorio_LaboratorioId",
                        column: x => x.LaboratorioId,
                        principalTable: "Tb_Laboratorio",
                        principalColumn: "Cl_IdLaboratorio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_Equipamento_Tb_Situacao_Cl_IdSituacao",
                        column: x => x.Cl_IdSituacao,
                        principalTable: "Tb_Situacao",
                        principalColumn: "Cl_IdSituacao");
                    table.ForeignKey(
                        name: "FK_Tb_Equipamento_Tb_TipoEquipamento_Cl_IdTipoEquipamento",
                        column: x => x.Cl_IdTipoEquipamento,
                        principalTable: "Tb_TipoEquipamento",
                        principalColumn: "Cl_IdTipoEquipamento");
                });

            migrationBuilder.CreateTable(
                name: "Tb_EquipamentoCaracteristica",
                columns: table => new
                {
                    Cl_IdEquipmanetoCaracteristicas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cl_Equipamento = table.Column<long>(type: "bigint", nullable: false),
                    EquipamentoId = table.Column<long>(type: "bigint", nullable: false),
                    Cl_CaracteristicaTipo = table.Column<int>(type: "int", nullable: false),
                    Cl_CaracteristicaValor = table.Column<int>(type: "int", nullable: true),
                    Cl_ValorIndividual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cl_UsuarioAtualizacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cl_AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_EquipamentoCaracteristica", x => x.Cl_IdEquipmanetoCaracteristicas);
                    table.ForeignKey(
                        name: "FK_Tb_EquipamentoCaracteristica_Tb_CaracteristicaTipo_Cl_CaracteristicaTipo",
                        column: x => x.Cl_CaracteristicaTipo,
                        principalTable: "Tb_CaracteristicaTipo",
                        principalColumn: "Cl_IdCaracteristicaTipo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_EquipamentoCaracteristica_Tb_CaracteristicaValor_Cl_CaracteristicaValor",
                        column: x => x.Cl_CaracteristicaValor,
                        principalTable: "Tb_CaracteristicaValor",
                        principalColumn: "Cl_IdCaracteristicaValor");
                    table.ForeignKey(
                        name: "FK_Tb_EquipamentoCaracteristica_Tb_Equipamento_EquipamentoId",
                        column: x => x.EquipamentoId,
                        principalTable: "Tb_Equipamento",
                        principalColumn: "Cl_IdEquipamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_CaracteristicaTipoTipoEquipamento_Cl_IdTipoEquipamento",
                table: "Tb_CaracteristicaTipoTipoEquipamento",
                column: "Cl_IdTipoEquipamento");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Equipamento_Cl_IdFabricante",
                table: "Tb_Equipamento",
                column: "Cl_IdFabricante");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Equipamento_Cl_IdSituacao",
                table: "Tb_Equipamento",
                column: "Cl_IdSituacao");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Equipamento_Cl_IdTipoEquipamento",
                table: "Tb_Equipamento",
                column: "Cl_IdTipoEquipamento");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Equipamento_LaboratorioId",
                table: "Tb_Equipamento",
                column: "LaboratorioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_EquipamentoCaracteristica_Cl_CaracteristicaTipo",
                table: "Tb_EquipamentoCaracteristica",
                column: "Cl_CaracteristicaTipo");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_EquipamentoCaracteristica_Cl_CaracteristicaValor",
                table: "Tb_EquipamentoCaracteristica",
                column: "Cl_CaracteristicaValor");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_EquipamentoCaracteristica_EquipamentoId",
                table: "Tb_EquipamentoCaracteristica",
                column: "EquipamentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_CaracteristicaTipoTipoEquipamento");

            migrationBuilder.DropTable(
                name: "Tb_EquipamentoCaracteristica");

            migrationBuilder.DropTable(
                name: "Tb_CaracteristicaTipo");

            migrationBuilder.DropTable(
                name: "Tb_CaracteristicaValor");

            migrationBuilder.DropTable(
                name: "Tb_Equipamento");

            migrationBuilder.DropTable(
                name: "Tb_Fabricante");

            migrationBuilder.DropTable(
                name: "Tb_Laboratorio");

            migrationBuilder.DropTable(
                name: "Tb_Situacao");

            migrationBuilder.DropTable(
                name: "Tb_TipoEquipamento");
        }
    }
}
