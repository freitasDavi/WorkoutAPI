using WorkoutApi.Infra;

namespace WorkoutApi.Entities;

public class Treino : Entity
{
    public string Nome { get; set; } = "";
    public EnumDiaTreino Dia { get; set; }
    public int TotalTreinos { get; set; } 
    public int TotalTreinosExecutados { get; set; }
    public int CodigoUsuario { get; set; }
    public List<Exercicio> Exercicios { get; set; } = new ();
    public List<TreinoExecutado> TreinosExecutados { get; set; } = new();
    public Usuario Usuario { get; set; } = null!;
}

public enum EnumDiaTreino
{
    A = 1,
    B = 2,
    C = 3,
    D = 4
}