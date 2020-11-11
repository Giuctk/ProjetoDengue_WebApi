using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gravidade",
                columns: table => new
                {
                    IdGravidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(30)", nullable: true),
                    Prioridade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gravidade", x => x.IdGravidade);
                });

            migrationBuilder.CreateTable(
                name: "Localizacao",
                columns: table => new
                {
                    IdLocalizacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CEP = table.Column<string>(type: "varchar(7)", nullable: true),
                    Rua = table.Column<string>(type: "varchar(200)", nullable: true),
                    Numero = table.Column<string>(type: "varchar(10)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(200)", nullable: true),
                    Cidade = table.Column<string>(type: "varchar(100)", nullable: true),
                    SiglaEstado = table.Column<string>(type: "varchar(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizacao", x => x.IdLocalizacao);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    IdStatus = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.IdStatus);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "varchar(10)", nullable: true),
                    Senha = table.Column<string>(type: "varchar(50)", nullable: true),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", nullable: true),
                    Telefone = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Atendimento",
                columns: table => new
                {
                    IdAtendimento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdLocalizacao = table.Column<int>(nullable: false),
                    IdGravidade = table.Column<int>(nullable: true),
                    IdAgenteAdministrativo = table.Column<int>(nullable: true),
                    IdAgenteCampo = table.Column<int>(nullable: true),
                    IdStatus = table.Column<int>(nullable: true),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    DataAtendimento = table.Column<DateTime>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: true),
                    ObservacaoRequisitante = table.Column<string>(type: "varchar(3000)", nullable: true),
                    ObservacaoAgente = table.Column<string>(type: "varchar(3000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimento", x => x.IdAtendimento);
                    table.ForeignKey(
                        name: "FK_Atendimento_Usuarios_IdAgenteAdministrativo",
                        column: x => x.IdAgenteAdministrativo,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Atendimento_Usuarios_IdAgenteCampo",
                        column: x => x.IdAgenteCampo,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Atendimento_Gravidade_IdGravidade",
                        column: x => x.IdGravidade,
                        principalTable: "Gravidade",
                        principalColumn: "IdGravidade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Atendimento_Localizacao_IdLocalizacao",
                        column: x => x.IdLocalizacao,
                        principalTable: "Localizacao",
                        principalColumn: "IdLocalizacao",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Atendimento_Status_IdStatus",
                        column: x => x.IdStatus,
                        principalTable: "Status",
                        principalColumn: "IdStatus",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_IdAgenteAdministrativo",
                table: "Atendimento",
                column: "IdAgenteAdministrativo");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_IdAgenteCampo",
                table: "Atendimento",
                column: "IdAgenteCampo");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_IdGravidade",
                table: "Atendimento",
                column: "IdGravidade");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_IdLocalizacao",
                table: "Atendimento",
                column: "IdLocalizacao");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_IdStatus",
                table: "Atendimento",
                column: "IdStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atendimento");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Gravidade");

            migrationBuilder.DropTable(
                name: "Localizacao");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
