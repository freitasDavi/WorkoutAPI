using WorkoutApi.Data;
using WorkoutApi.Entities;
using WorkoutApi.Infra;

namespace WorkoutApi.Repositories;

public class ExerciciosRepository : RepositoryBase<Exercicio>, IExerciciosRepository
{
    public ExerciciosRepository(DataContext dataContext) : base(dataContext)
    {
    }
}