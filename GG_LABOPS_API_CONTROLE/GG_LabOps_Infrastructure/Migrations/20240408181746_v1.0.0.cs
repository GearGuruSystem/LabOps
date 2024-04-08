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
                name: "TB_Brand_Equipament",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LaboratoryId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Brand_Equipament", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_Laboratory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inventory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hostname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandEquipamentId = table.Column<long>(type: "bigint", nullable: false),
                    SerieNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipamentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipamentModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdOwner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateRegister = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Laboratory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_Laboratory_TB_Brand_Equipament_BrandEquipamentId",
                        column: x => x.BrandEquipamentId,
                        principalTable: "TB_Brand_Equipament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_Laboratory_BrandEquipamentId",
                table: "TB_Laboratory",
                column: "BrandEquipamentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Laboratory");

            migrationBuilder.DropTable(
                name: "TB_Brand_Equipament");
        }
    }
}
