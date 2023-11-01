using WorkoutApi.Entities;
using WorkoutApi.Infra;

namespace WorkoutApi.Repositories.Treinos;

public interface ITreinosRepository : IRepositorioBase<Treino>
{
    Task<Treino?> getTreinoById(int id);
}