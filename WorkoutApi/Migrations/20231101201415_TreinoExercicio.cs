using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkoutApi.Migrations
{
    /// <inheritdoc />
    public partial class TreinoExercicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreinoExercicio_EXERCICIOS_ExercicioId",
                table: "TreinoExercicio");

            migrationBuilder.DropForeignKey(
                name: "FK_TreinoExercicio_EXERCICIOS_ExercicioId1",
                table: "TreinoExercicio");

            migrationBuilder.DropForeignKey(
                name: "FK_TreinoExercicio_EXERCICIOS_ExerciciosId",
                table: "TreinoExercicio");

            migrationBuilder.DropForeignKey(
                name: "FK_TreinoExercicio_TREINOS_TreinoId",
                table: "TreinoExercicio");

            migrationBuilder.DropForeignKey(
                name: "FK_TreinoExercicio_TREINOS_TreinoId1",
                table: "TreinoExercicio");

            migrationBuilder.DropForeignKey(
                name: "FK_TreinoExercicio_TREINOS_TreinosId",
                table: "TreinoExercicio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TreinoExercicio",
                table: "TreinoExercicio");

            migrationBuilder.DropIndex(
                name: "IX_TreinoExercicio_ExercicioId",
                table: "TreinoExercicio");

            migrationBuilder.DropIndex(
                name: "IX_TreinoExercicio_ExercicioId1",
                table: "TreinoExercicio");

            migrationBuilder.DropIndex(
                name: "IX_TreinoExercicio_ExerciciosId",
                table: "TreinoExercicio");

            migrationBuilder.DropIndex(
                name: "IX_TreinoExercicio_TreinoId",
                table: "TreinoExercicio");

            migrationBuilder.DropIndex(
                name: "IX_TreinoExercicio_TreinoId1",
                table: "TreinoExercicio");

            migrationBuilder.DropIndex(
                name: "IX_TreinoExercicio_TreinosId",
                table: "TreinoExercicio");

            migrationBuilder.DropColumn(
                name: "ExercicioId",
                table: "TreinoExercicio");

            migrationBuilder.DropColumn(
                name: "ExercicioId1",
                table: "TreinoExercicio");

            migrationBuilder.DropColumn(
                name: "ExerciciosId",
                table: "TreinoExercicio");

            migrationBuilder.DropColumn(
                name: "TreinoId",
                table: "TreinoExercicio");

            migrationBuilder.DropColumn(
                name: "TreinoId1",
                table: "TreinoExercicio");

            migrationBuilder.DropColumn(
                name: "TreinosId",
                table: "TreinoExercicio");

            migrationBuilder.RenameTable(
                name: "TreinoExercicio",
                newName: "TREINO_EXERCICIOS");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TREINO_EXERCICIOS",
                newName: "IDTREINOEXERCICIO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TREINO_EXERCICIOS",
                table: "TREINO_EXERCICIOS",
                column: "IDTREINOEXERCICIO");

            migrationBuilder.CreateTable(
                name: "ExercicioTreino",
                columns: table => new
                {
                    ExerciciosId = table.Column<int>(type: "INTEGER", nullable: false),
                    TreinosId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExercicioTreino", x => new { x.ExerciciosId, x.TreinosId });
                    table.ForeignKey(
                        name: "FK_ExercicioTreino_EXERCICIOS_ExerciciosId",
                        column: x => x.ExerciciosId,
                        principalTable: "EXERCICIOS",
                        principalColumn: "IDEXERCICIO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExercicioTreino_TREINOS_TreinosId",
                        column: x => x.TreinosId,
                        principalTable: "TREINOS",
                        principalColumn: "IDTREINO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TREINO_EXERCICIOS_CodigoExercicio",
                table: "TREINO_EXERCICIOS",
                column: "CodigoExercicio");

            migrationBuilder.CreateIndex(
                name: "IX_TREINO_EXERCICIOS_CodigoTreino",
                table: "TREINO_EXERCICIOS",
                column: "CodigoTreino");

            migrationBuilder.CreateIndex(
                name: "IX_ExercicioTreino_TreinosId",
                table: "ExercicioTreino",
                column: "TreinosId");

            migrationBuilder.AddForeignKey(
                name: "FK_TREINO_EXERCICIOS_EXERCICIOS_CodigoExercicio",
                table: "TREINO_EXERCICIOS",
                column: "CodigoExercicio",
                principalTable: "EXERCICIOS",
                principalColumn: "IDEXERCICIO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TREINO_EXERCICIOS_TREINOS_CodigoTreino",
                table: "TREINO_EXERCICIOS",
                column: "CodigoTreino",
                principalTable: "TREINOS",
                principalColumn: "IDTREINO",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TREINO_EXERCICIOS_EXERCICIOS_CodigoExercicio",
                table: "TREINO_EXERCICIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_TREINO_EXERCICIOS_TREINOS_CodigoTreino",
                table: "TREINO_EXERCICIOS");

            migrationBuilder.DropTable(
                name: "ExercicioTreino");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TREINO_EXERCICIOS",
                table: "TREINO_EXERCICIOS");

            migrationBuilder.DropIndex(
                name: "IX_TREINO_EXERCICIOS_CodigoExercicio",
                table: "TREINO_EXERCICIOS");

            migrationBuilder.DropIndex(
                name: "IX_TREINO_EXERCICIOS_CodigoTreino",
                table: "TREINO_EXERCICIOS");

            migrationBuilder.RenameTable(
                name: "TREINO_EXERCICIOS",
                newName: "TreinoExercicio");

            migrationBuilder.RenameColumn(
                name: "IDTREINOEXERCICIO",
                table: "TreinoExercicio",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "ExercicioId",
                table: "TreinoExercicio",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExercicioId1",
                table: "TreinoExercicio",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExerciciosId",
                table: "TreinoExercicio",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TreinoId",
                table: "TreinoExercicio",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TreinoId1",
                table: "TreinoExercicio",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TreinosId",
                table: "TreinoExercicio",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TreinoExercicio",
                table: "TreinoExercicio",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_TreinoExercicio_EXERCICIOS_ExercicioId",
                table: "TreinoExercicio",
                column: "ExercicioId",
                principalTable: "EXERCICIOS",
                principalColumn: "IDEXERCICIO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreinoExercicio_EXERCICIOS_ExercicioId1",
                table: "TreinoExercicio",
                column: "ExercicioId1",
                principalTable: "EXERCICIOS",
                principalColumn: "IDEXERCICIO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreinoExercicio_EXERCICIOS_ExerciciosId",
                table: "TreinoExercicio",
                column: "ExerciciosId",
                principalTable: "EXERCICIOS",
                principalColumn: "IDEXERCICIO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreinoExercicio_TREINOS_TreinoId",
                table: "TreinoExercicio",
                column: "TreinoId",
                principalTable: "TREINOS",
                principalColumn: "IDTREINO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreinoExercicio_TREINOS_TreinoId1",
                table: "TreinoExercicio",
                column: "TreinoId1",
                principalTable: "TREINOS",
                principalColumn: "IDTREINO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreinoExercicio_TREINOS_TreinosId",
                table: "TreinoExercicio",
                column: "TreinosId",
                principalTable: "TREINOS",
                principalColumn: "IDTREINO",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
