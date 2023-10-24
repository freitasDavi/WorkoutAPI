using WorkoutApi.Infra;

namespace WorkoutApi.Entities;

public class TreinoExecutado : Entity
{
    public int CodigoTreino { get; set; }
    public int CodigoUsuario { get; set; }
    public bool Completo { get; set; }
    public DateTime DataExecucao { get; set; }
    public Usuario Usuario { get; set; } = null!;
    public Treino Treino { get; set; } = null!;
}