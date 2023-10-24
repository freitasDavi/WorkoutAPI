using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkoutApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EXERCICIOS",
                columns: table => new
                {
                    IDEXERCICIO = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Img = table.Column<string>(type: "TEXT", nullable: false),
                    GrupoMuscular = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EXERCICIOS", x => x.IDEXERCICIO);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    IDUSUARIOS = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Sexo = table.Column<int>(type: "INTEGER", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Objetivo = table.Column<string>(type: "TEXT", nullable: false),
                    Senha = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.IDUSUARIOS);
                });

            migrationBuilder.CreateTable(
                name: "TREINOS",
                columns: table => new
                {
                    IDTREINO = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Dia = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalTreinos = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalTreinosExecutados = table.Column<int>(type: "INTEGER", nullable: false),
                    CodigoUsuario = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TREINOS", x => x.IDTREINO);
                    table.ForeignKey(
                        name: "FK_TREINOS_USUARIOS_CodigoUsuario",
                        column: x => x.CodigoUsuario,
                        principalTable: "USUARIOS",
                        principalColumn: "IDUSUARIOS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TreinoExercicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CodigoTreino = table.Column<int>(type: "INTEGER", nullable: false),
                    CodigoExercicio = table.Column<int>(type: "INTEGER", nullable: false),
                    TreinoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ExercicioId = table.Column<int>(type: "INTEGER", nullable: false),
                    ExercicioId1 = table.Column<int>(type: "INTEGER", nullable: false),
                    ExerciciosId = table.Column<int>(type: "INTEGER", nullable: false),
                    TreinoId1 = table.Column<int>(type: "INTEGER", nullable: false),
                    TreinosId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreinoExercicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TreinoExercicio_EXERCICIOS_ExercicioId",
                        column: x => x.ExercicioId,
                        principalTable: "EXERCICIOS",
                        principalColumn: "IDEXERCICIO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreinoExercicio_EXERCICIOS_ExercicioId1",
                        column: x => x.ExercicioId1,
                        principalTable: "EXERCICIOS",
                        principalColumn: "IDEXERCICIO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreinoExercicio_EXERCICIOS_ExerciciosId",
                        column: x => x.ExerciciosId,
                        principalTable: "EXERCICIOS",
                        principalColumn: "IDEXERCICIO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreinoExercicio_TREINOS_TreinoId",
                        column: x => x.TreinoId,
                        principalTable: "TREINOS",
                        principalColumn: "IDTREINO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreinoExercicio_TREINOS_TreinoId1",
                        column: x => x.TreinoId1,
                        principalTable: "TREINOS",
                        principalColumn: "IDTREINO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreinoExercicio_TREINOS_TreinosId",
                        column: x => x.TreinosId,
                        principalTable: "TREINOS",
                        principalColumn: "IDTREINO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TREINOSEXECUTADOS",
                columns: table => new
                {
                    ID_TREINOSEXECUTADOS = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CodigoTreino = table.Column<int>(type: "INTEGER", nullable: false),
                    CodigoUsuario = table.Column<int>(type: "INTEGER", nullable: false),
                    Completo = table.Column<bool>(type: "INTEGER", nullable: false),
                    DataExecucao = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TREINOSEXECUTADOS", x => x.ID_TREINOSEXECUTADOS);
                    table.ForeignKey(
                        name: "FK_TREINOSEXECUTADOS_TREINOS_CodigoTreino",
                        column: x => x.CodigoTreino,
                        principalTable: "TREINOS",
                        principalColumn: "IDTREINO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TREINOSEXECUTADOS_USUARIOS_CodigoUsuario",
                        column: x => x.CodigoUsuario,
                        principalTable: "USUARIOS",
                        principalColumn: "IDUSUARIOS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TreinoExercicio_ExercicioId",
                table: "TreinoExercicio",
                column: "ExercicioId");

            migrationBuilder.CreateIndex(
                name: "IX_TreinoExercicio_ExercicioId1",
                table: "TreinoExercicio",
                column: "ExercicioId1");

            migrationBuilder.CreateIndex(
                name: "IX_TreinoExercicio_ExerciciosId",
                table: "TreinoExercicio",
                column: "ExerciciosId");

            migrationBuilder.CreateIndex(
                name: "IX_TreinoExercicio_TreinoId",
                table: "TreinoExercicio",
                column: "TreinoId");

            migrationBuilder.CreateIndex(
                name: "IX_TreinoExercicio_TreinoId1",
                table: "TreinoExercicio",
                column: "TreinoId1");

            migrationBuilder.CreateIndex(
                name: "IX_TreinoExercicio_TreinosId",
                table: "TreinoExercicio",
                column: "TreinosId");

            migrationBuilder.CreateIndex(
                name: "IX_TREINOS_CodigoUsuario",
                table: "TREINOS",
                column: "CodigoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_TREINOSEXECUTADOS_CodigoTreino",
                table: "TREINOSEXECUTADOS",
                column: "CodigoTreino");

            migrationBuilder.CreateIndex(
                name: "IX_TREINOSEXECUTADOS_CodigoUsuario",
                table: "TREINOSEXECUTADOS",
                column: "CodigoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "USUARIOS",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TreinoExercicio");

            migrationBuilder.DropTable(
                name: "TREINOSEXECUTADOS");

            migrationBuilder.DropTable(
                name: "EXERCICIOS");

            migrationBuilder.DropTable(
                name: "TREINOS");

            migrationBuilder.DropTable(
                name: "USUARIOS");
        }
    }
}
