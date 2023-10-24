using WorkoutApi.Data;
using WorkoutApi.Entities;
using WorkoutApi.Infra;

namespace WorkoutApi.Repositories.Treinos;

public class TreinosRepository : RepositorioBase<Treino>, ITreinosRepository
{
    public TreinosRepository(DataContext dataContext) : base(dataContext)
    {
    }
}