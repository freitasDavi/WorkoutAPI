using WorkoutApi.Infra;

namespace WorkoutApi.Entities;

public class TreinoExercicio : Entity
{
    public int CodigoTreino { get; set; }
    public int CodigoExercicio { get; set; }
    public Treino? Treino { get; set; } 
    public Exercicio? Exercicio { get; set; }
    
}