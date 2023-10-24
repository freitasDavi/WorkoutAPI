using WorkoutApi.Data;
using WorkoutApi.Entities;
using WorkoutApi.Infra;

namespace WorkoutApi.Repositories;

public class ExerciciosRepositorio : RepositorioBase<Exercicio>, IExerciciosRepository
{
    public ExerciciosRepositorio(DataContext dataContext) : base(dataContext)
    {
    }
}