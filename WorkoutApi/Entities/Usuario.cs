using WorkoutApi.Infra;

namespace WorkoutApi.Entities;

public class Usuario : Entity
{
    public string Nome { get; set; } = string.Empty;
    public EnumSexo Sexo { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Objetivo { get; set; }
    public string Senha { get; set; }
    public string Email { get; set; }
    public List<Treino> Treinos { get; set; } = new();
    public List<TreinoExecutado> TreinoExecutados { get; set; } = new();
}

public enum EnumSexo
{
    Masc = 1,
    Fem = 2
}