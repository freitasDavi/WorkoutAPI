using WorkoutApi.Entities;
using WorkoutApi.Infra;

namespace WorkoutApi.Repositories;

public interface IExerciciosRepository : IRepositorioBase<Exercicio>
{
    public Task InserirExerciciosNoTreino(List<TreinoExercicio> treinosExercicios);
}