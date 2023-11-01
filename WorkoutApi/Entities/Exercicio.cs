using WorkoutApi.Infra;

namespace WorkoutApi.Entities;

public class Exercicio : Entity
{
    public string Nome { get; set; } = string.Empty;
    public string Img { get; set; } = string.Empty;
    public string GrupoMuscular { get; set; } = string.Empty;
    public List<Treino> Treinos { get; set; } = new();
    public List<TreinoExercicio> TreinoExercicios { get; set; } = new();
}