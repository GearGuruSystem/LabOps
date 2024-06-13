using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auth.LabOps.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aplicacoes",
                columns: table => new
                {
                    IDAplicacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aplicacoes", x => x.IDAplicacao);
                });

            migrationBuilder.CreateTable(
                name: "GrupoUsuarios",
                columns: table => new
                {
                    IDGrupoUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    UsuarioInsercao = table.Column<int>(type: "int", nullable: false),
                    InseridoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioAtualizacao = table.Column<int>(type: "int", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoUsuarios", x => x.IDGrupoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IDUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InseridoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IDUsuario);
                });

            migrationBuilder.CreateTable(
                name: "GrupoUsuarioXAplicacoes",
                columns: table => new
                {
                    IDAplicacao = table.Column<int>(type: "int", nullable: false),
                    IDGrupoUsuario = table.Column<int>(type: "int", nullable: false),
                    Permissao = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoUsuarioXAplicacoes", x => new { x.IDAplicacao, x.IDGrupoUsuario });
                    table.ForeignKey(
                        name: "FK_GrupoUsuarioXAplicacoes_Aplicacoes_IDAplicacao",
                        column: x => x.IDAplicacao,
                        principalTable: "Aplicacoes",
                        principalColumn: "IDAplicacao",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrupoUsuarioXAplicacoes_GrupoUsuarios_IDGrupoUsuario",
                        column: x => x.IDGrupoUsuario,
                        principalTable: "GrupoUsuarios",
                        principalColumn: "IDGrupoUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioXGrupoUsuarios",
                columns: table => new
                {
                    IDUsuario = table.Column<int>(type: "int", nullable: false),
                    IDGrupoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioXGrupoUsuarios", x => new { x.IDUsuario, x.IDGrupoUsuario });
                    table.ForeignKey(
                        name: "FK_UsuarioXGrupoUsuarios_GrupoUsuarios_IDGrupoUsuario",
                        column: x => x.IDGrupoUsuario,
                        principalTable: "GrupoUsuarios",
                        principalColumn: "IDGrupoUsuario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioXGrupoUsuarios_Usuarios_IDUsuario",
                        column: x => x.IDUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IDUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GrupoUsuarioXAplicacoes_IDGrupoUsuario",
                table: "GrupoUsuarioXAplicacoes",
                column: "IDGrupoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioXGrupoUsuarios_IDGrupoUsuario",
                table: "UsuarioXGrupoUsuarios",
                column: "IDGrupoUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrupoUsuarioXAplicacoes");

            migrationBuilder.DropTable(
                name: "UsuarioXGrupoUsuarios");

            migrationBuilder.DropTable(
                name: "Aplicacoes");

            migrationBuilder.DropTable(
                name: "GrupoUsuarios");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
