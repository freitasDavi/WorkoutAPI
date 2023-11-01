using System.Data.Entity;
using WorkoutApi.Data;
using WorkoutApi.Entities;
using WorkoutApi.Infra;

namespace WorkoutApi.Repositories;

public class ExerciciosRepositorio : RepositorioBase<Exercicio>, IExerciciosRepository
{
    private readonly DataContext _dataContext;
    public ExerciciosRepositorio(DataContext dataContext) : base(dataContext)
    {
        _dataContext = dataContext;
    }


    public async Task InserirExerciciosNoTreino(List<TreinoExercicio> treinosExercicios)
    {
        _dataContext.AddRange(treinosExercicios);
        await _dataContext.SaveChangesAsync();
    }
}