using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabOps.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaracteristicaTipos",
                columns: table => new
                {
                    IDCaracteristicaTipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioAtualizacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaracteristicaTipos", x => x.IDCaracteristicaTipo);
                });

            migrationBuilder.CreateTable(
                name: "CaracteristicasValor",
                columns: table => new
                {
                    IDCaracteristicaValor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioAtualizacao = table.Column<int>(type: "int", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaracteristicasValor", x => x.IDCaracteristicaValor);
                });

            migrationBuilder.CreateTable(
                name: "Fabricantes",
                columns: table => new
                {
                    IDFabricante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioAtualizacao = table.Column<int>(type: "int", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricantes", x => x.IDFabricante);
                });

            migrationBuilder.CreateTable(
                name: "Laboratorios",
                columns: table => new
                {
                    IDLaboratorio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDUsuarioResponsavel = table.Column<int>(type: "int", nullable: true),
                    ChaveResponsavel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioAtualizacao = table.Column<int>(type: "int", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratorios", x => x.IDLaboratorio);
                });

            migrationBuilder.CreateTable(
                name: "Situacoes",
                columns: table => new
                {
                    IDSituacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioAtualizacao = table.Column<int>(type: "int", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Situacoes", x => x.IDSituacao);
                });

            migrationBuilder.CreateTable(
                name: "TiposEquipamento",
                columns: table => new
                {
                    IDTipoEquipamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioAtualizacao = table.Column<int>(type: "int", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposEquipamento", x => x.IDTipoEquipamento);
                });

            migrationBuilder.CreateTable(
                name: "CaracteristicasTipoTipoEquipamento",
                columns: table => new
                {
                    CaracteristicaTipo_ID = table.Column<int>(type: "int", nullable: false),
                    TipoEquipamento_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaracteristicasTipoTipoEquipamento", x => new { x.CaracteristicaTipo_ID, x.TipoEquipamento_ID });
                    table.ForeignKey(
                        name: "FK_CaracteristicasTipoTipoEquipamento_CaracteristicaTipos_CaracteristicaTipo_ID",
                        column: x => x.CaracteristicaTipo_ID,
                        principalTable: "CaracteristicaTipos",
                        principalColumn: "IDCaracteristicaTipo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaracteristicasTipoTipoEquipamento_TiposEquipamento_TipoEquipamento_ID",
                        column: x => x.TipoEquipamento_ID,
                        principalTable: "TiposEquipamento",
                        principalColumn: "IDTipoEquipamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipamentos",
                columns: table => new
                {
                    IDEquipamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    IDSituacao = table.Column<int>(type: "int", nullable: false),
                    IDTipoEquipamento = table.Column<int>(type: "int", nullable: false),
                    IDFabricante = table.Column<int>(type: "int", nullable: false),
                    IDLaboratorio = table.Column<int>(type: "int", nullable: true),
                    UsuarioInsercao = table.Column<int>(type: "int", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FabricanteIDFabricante = table.Column<int>(type: "int", nullable: true),
                    LaboratorioIDLaboratorio = table.Column<int>(type: "int", nullable: true),
                    SituacaoIDSituacao = table.Column<int>(type: "int", nullable: true),
                    TipoEquipamentoIDTipoEquipamento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamentos", x => x.IDEquipamento);
                    table.ForeignKey(
                        name: "FK_Equipamentos_Fabricantes_FabricanteIDFabricante",
                        column: x => x.FabricanteIDFabricante,
                        principalTable: "Fabricantes",
                        principalColumn: "IDFabricante");
                    table.ForeignKey(
                        name: "FK_Equipamentos_Fabricantes_IDFabricante",
                        column: x => x.IDFabricante,
                        principalTable: "Fabricantes",
                        principalColumn: "IDFabricante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipamentos_Laboratorios_IDLaboratorio",
                        column: x => x.IDLaboratorio,
                        principalTable: "Laboratorios",
                        principalColumn: "IDLaboratorio");
                    table.ForeignKey(
                        name: "FK_Equipamentos_Laboratorios_LaboratorioIDLaboratorio",
                        column: x => x.LaboratorioIDLaboratorio,
                        principalTable: "Laboratorios",
                        principalColumn: "IDLaboratorio");
                    table.ForeignKey(
                        name: "FK_Equipamentos_Situacoes_IDSituacao",
                        column: x => x.IDSituacao,
                        principalTable: "Situacoes",
                        principalColumn: "IDSituacao",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipamentos_Situacoes_SituacaoIDSituacao",
                        column: x => x.SituacaoIDSituacao,
                        principalTable: "Situacoes",
                        principalColumn: "IDSituacao");
                    table.ForeignKey(
                        name: "FK_Equipamentos_TiposEquipamento_IDTipoEquipamento",
                        column: x => x.IDTipoEquipamento,
                        principalTable: "TiposEquipamento",
                        principalColumn: "IDTipoEquipamento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipamentos_TiposEquipamento_TipoEquipamentoIDTipoEquipamento",
                        column: x => x.TipoEquipamentoIDTipoEquipamento,
                        principalTable: "TiposEquipamento",
                        principalColumn: "IDTipoEquipamento");
                });

            migrationBuilder.CreateTable(
                name: "EquipamentosCaracteristicas",
                columns: table => new
                {
                    IDEquipamentoCaracteristica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDEquipamento = table.Column<int>(type: "int", nullable: false),
                    IDCaracteristicaTipo = table.Column<int>(type: "int", nullable: false),
                    IDCaracteristicaValor = table.Column<int>(type: "int", nullable: true),
                    ValorIndividual = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioAtualizacao = table.Column<int>(type: "int", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EquipamentoIDEquipamento = table.Column<int>(type: "int", nullable: false),
                    CaracteristicaTipoIDCaracteristicaTipo = table.Column<int>(type: "int", nullable: true),
                    CaracteristicaValorIDCaracteristicaValor = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipamentosCaracteristicas", x => x.IDEquipamentoCaracteristica);
                    table.ForeignKey(
                        name: "FK_EquipamentosCaracteristicas_CaracteristicaTipos_CaracteristicaTipoIDCaracteristicaTipo",
                        column: x => x.CaracteristicaTipoIDCaracteristicaTipo,
                        principalTable: "CaracteristicaTipos",
                        principalColumn: "IDCaracteristicaTipo");
                    table.ForeignKey(
                        name: "FK_EquipamentosCaracteristicas_CaracteristicaTipos_IDCaracteristicaTipo",
                        column: x => x.IDCaracteristicaTipo,
                        principalTable: "CaracteristicaTipos",
                        principalColumn: "IDCaracteristicaTipo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipamentosCaracteristicas_CaracteristicasValor_CaracteristicaValorIDCaracteristicaValor",
                        column: x => x.CaracteristicaValorIDCaracteristicaValor,
                        principalTable: "CaracteristicasValor",
                        principalColumn: "IDCaracteristicaValor");
                    table.ForeignKey(
                        name: "FK_EquipamentosCaracteristicas_CaracteristicasValor_IDCaracteristicaValor",
                        column: x => x.IDCaracteristicaValor,
                        principalTable: "CaracteristicasValor",
                        principalColumn: "IDCaracteristicaValor");
                    table.ForeignKey(
                        name: "FK_EquipamentosCaracteristicas_Equipamentos_EquipamentoIDEquipamento",
                        column: x => x.EquipamentoIDEquipamento,
                        principalTable: "Equipamentos",
                        principalColumn: "IDEquipamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaracteristicasTipoTipoEquipamento_TipoEquipamento_ID",
                table: "CaracteristicasTipoTipoEquipamento",
                column: "TipoEquipamento_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_FabricanteIDFabricante",
                table: "Equipamentos",
                column: "FabricanteIDFabricante");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_IDFabricante",
                table: "Equipamentos",
                column: "IDFabricante");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_IDLaboratorio",
                table: "Equipamentos",
                column: "IDLaboratorio");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_IDSituacao",
                table: "Equipamentos",
                column: "IDSituacao");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_IDTipoEquipamento",
                table: "Equipamentos",
                column: "IDTipoEquipamento");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_LaboratorioIDLaboratorio",
                table: "Equipamentos",
                column: "LaboratorioIDLaboratorio");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_SituacaoIDSituacao",
                table: "Equipamentos",
                column: "SituacaoIDSituacao");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_TipoEquipamentoIDTipoEquipamento",
                table: "Equipamentos",
                column: "TipoEquipamentoIDTipoEquipamento");

            migrationBuilder.CreateIndex(
                name: "IX_EquipamentosCaracteristicas_CaracteristicaTipoIDCaracteristicaTipo",
                table: "EquipamentosCaracteristicas",
                column: "CaracteristicaTipoIDCaracteristicaTipo");

            migrationBuilder.CreateIndex(
                name: "IX_EquipamentosCaracteristicas_CaracteristicaValorIDCaracteristicaValor",
                table: "EquipamentosCaracteristicas",
                column: "CaracteristicaValorIDCaracteristicaValor");

            migrationBuilder.CreateIndex(
                name: "IX_EquipamentosCaracteristicas_EquipamentoIDEquipamento",
                table: "EquipamentosCaracteristicas",
                column: "EquipamentoIDEquipamento");

            migrationBuilder.CreateIndex(
                name: "IX_EquipamentosCaracteristicas_IDCaracteristicaTipo",
                table: "EquipamentosCaracteristicas",
                column: "IDCaracteristicaTipo");

            migrationBuilder.CreateIndex(
                name: "IX_EquipamentosCaracteristicas_IDCaracteristicaValor",
                table: "EquipamentosCaracteristicas",
                column: "IDCaracteristicaValor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaracteristicasTipoTipoEquipamento");

            migrationBuilder.DropTable(
                name: "EquipamentosCaracteristicas");

            migrationBuilder.DropTable(
                name: "CaracteristicaTipos");

            migrationBuilder.DropTable(
                name: "CaracteristicasValor");

            migrationBuilder.DropTable(
                name: "Equipamentos");

            migrationBuilder.DropTable(
                name: "Fabricantes");

            migrationBuilder.DropTable(
                name: "Laboratorios");

            migrationBuilder.DropTable(
                name: "Situacoes");

            migrationBuilder.DropTable(
                name: "TiposEquipamento");
        }
    }
}