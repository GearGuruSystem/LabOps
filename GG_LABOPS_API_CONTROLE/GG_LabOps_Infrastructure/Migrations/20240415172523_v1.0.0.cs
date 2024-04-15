using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GG_LabOps_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Laboratorio",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeyOwner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipamentId = table.Column<long>(type: "bigint", nullable: false),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Laboratorio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_Equipamento",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LaboratoryId = table.Column<long>(type: "bigint", nullable: false),
                    Inventory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hostname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateRegister = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BrandId = table.Column<long>(type: "bigint", nullable: false),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    ModelId = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Equipamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_Equipamento_TB_Laboratorio_LaboratoryId",
                        column: x => x.LaboratoryId,
                        principalTable: "TB_Laboratorio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_MarcaEquipamento",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipamentId = table.Column<long>(type: "bigint", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_MarcaEquipamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_MarcaEquipamento_TB_Equipamento_EquipamentId",
                        column: x => x.EquipamentId,
                        principalTable: "TB_Equipamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_ModeloEquipamento",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipamentId = table.Column<long>(type: "bigint", nullable: false),
                    ModelNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ModeloEquipamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_ModeloEquipamento_TB_Equipamento_EquipamentId",
                        column: x => x.EquipamentId,
                        principalTable: "TB_Equipamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_TipoEquipamento",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipamentId = table.Column<long>(type: "bigint", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TipoEquipamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_TipoEquipamento_TB_Equipamento_EquipamentId",
                        column: x => x.EquipamentId,
                        principalTable: "TB_Equipamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_Equipamento_LaboratoryId",
                table: "TB_Equipamento",
                column: "LaboratoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_MarcaEquipamento_EquipamentId",
                table: "TB_MarcaEquipamento",
                column: "EquipamentId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ModeloEquipamento_EquipamentId",
                table: "TB_ModeloEquipamento",
                column: "EquipamentId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_TipoEquipamento_EquipamentId",
                table: "TB_TipoEquipamento",
                column: "EquipamentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_MarcaEquipamento");

            migrationBuilder.DropTable(
                name: "TB_ModeloEquipamento");

            migrationBuilder.DropTable(
                name: "TB_TipoEquipamento");

            migrationBuilder.DropTable(
                name: "TB_Equipamento");

            migrationBuilder.DropTable(
                name: "TB_Laboratorio");
        }
    }
}
