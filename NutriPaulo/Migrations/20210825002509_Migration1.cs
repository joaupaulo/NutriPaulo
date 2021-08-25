using Microsoft.EntityFrameworkCore.Migrations;

namespace NutriPaulo.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alimentos",
                columns: table => new
                {
                    AlimentosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CafeDaManha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Almoço = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lanche = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CafeDaNoite = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimentos", x => x.AlimentosId);
                });

            migrationBuilder.CreateTable(
                name: "Exercicios",
                columns: table => new
                {
                    ExerciciosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicios", x => x.ExerciciosId);
                });

            migrationBuilder.CreateTable(
                name: "Nutrientes",
                columns: table => new
                {
                    NutrientesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Carboidratos = table.Column<int>(type: "int", nullable: false),
                    Proteinas = table.Column<int>(type: "int", nullable: false),
                    Gorduras = table.Column<int>(type: "int", nullable: false),
                    Sodio = table.Column<int>(type: "int", nullable: false),
                    Acucar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrientes", x => x.NutrientesId);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    PessoasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SobreNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<int>(type: "int", nullable: false),
                    RG = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.PessoasId);
                });

            migrationBuilder.CreateTable(
                name: "Quantidades",
                columns: table => new
                {
                    QuantidadeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quantidades", x => x.QuantidadeId);
                });

            migrationBuilder.CreateTable(
                name: "AlimentosNutrientes",
                columns: table => new
                {
                    AlimenntosAlimentosId = table.Column<int>(type: "int", nullable: false),
                    NutrientesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlimentosNutrientes", x => new { x.AlimenntosAlimentosId, x.NutrientesId });
                    table.ForeignKey(
                        name: "FK_AlimentosNutrientes_Alimentos_AlimenntosAlimentosId",
                        column: x => x.AlimenntosAlimentosId,
                        principalTable: "Alimentos",
                        principalColumn: "AlimentosId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlimentosNutrientes_Nutrientes_NutrientesId",
                        column: x => x.NutrientesId,
                        principalTable: "Nutrientes",
                        principalColumn: "NutrientesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NutrientesAlimentos",
                columns: table => new
                {
                    AlimentosId = table.Column<int>(type: "int", nullable: false),
                    NutrientesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutrientesAlimentos", x => new { x.AlimentosId, x.NutrientesId });
                    table.ForeignKey(
                        name: "FK_NutrientesAlimentos_Alimentos_AlimentosId",
                        column: x => x.AlimentosId,
                        principalTable: "Alimentos",
                        principalColumn: "AlimentosId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NutrientesAlimentos_Nutrientes_NutrientesId",
                        column: x => x.NutrientesId,
                        principalTable: "Nutrientes",
                        principalColumn: "NutrientesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaracteristicasFisicas",
                columns: table => new
                {
                    CaracteFisicasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Altura = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    Biotipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PessoasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaracteristicasFisicas", x => x.CaracteFisicasId);
                    table.ForeignKey(
                        name: "FK_CaracteristicasFisicas_Pessoas_PessoasId",
                        column: x => x.PessoasId,
                        principalTable: "Pessoas",
                        principalColumn: "PessoasId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    EnderecosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    CEP = table.Column<int>(type: "int", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PessoasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnderecosId);
                    table.ForeignKey(
                        name: "FK_Enderecos_Pessoas_PessoasId",
                        column: x => x.PessoasId,
                        principalTable: "Pessoas",
                        principalColumn: "PessoasId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelatorioPrincipal",
                columns: table => new
                {
                    RelatorioPrincipalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatorioPrincipal", x => x.RelatorioPrincipalId);
                    table.ForeignKey(
                        name: "FK_RelatorioPrincipal_Pessoas_PessoasId",
                        column: x => x.PessoasId,
                        principalTable: "Pessoas",
                        principalColumn: "PessoasId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlimentosNutrientes_NutrientesId",
                table: "AlimentosNutrientes",
                column: "NutrientesId");

            migrationBuilder.CreateIndex(
                name: "IX_CaracteristicasFisicas_PessoasId",
                table: "CaracteristicasFisicas",
                column: "PessoasId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_PessoasId",
                table: "Enderecos",
                column: "PessoasId");

            migrationBuilder.CreateIndex(
                name: "IX_NutrientesAlimentos_NutrientesId",
                table: "NutrientesAlimentos",
                column: "NutrientesId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatorioPrincipal_PessoasId",
                table: "RelatorioPrincipal",
                column: "PessoasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlimentosNutrientes");

            migrationBuilder.DropTable(
                name: "CaracteristicasFisicas");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Exercicios");

            migrationBuilder.DropTable(
                name: "NutrientesAlimentos");

            migrationBuilder.DropTable(
                name: "Quantidades");

            migrationBuilder.DropTable(
                name: "RelatorioPrincipal");

            migrationBuilder.DropTable(
                name: "Alimentos");

            migrationBuilder.DropTable(
                name: "Nutrientes");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
