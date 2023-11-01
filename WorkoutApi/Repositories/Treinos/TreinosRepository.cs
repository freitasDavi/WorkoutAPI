using Microsoft.EntityFrameworkCore;
using WorkoutApi.Data;
using WorkoutApi.Entities;
using WorkoutApi.Infra;

namespace WorkoutApi.Repositories.Treinos;

public class TreinosRepository : RepositorioBase<Treino>, ITreinosRepository
{
    private readonly DataContext _dataContext;
    public TreinosRepository(DataContext dataContext) : base(dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<Treino?> getTreinoById(int id)
    {
        var treino = await _dataContext.Treinos
                                    .Include(x => x.TreinoExercicios)
                                    .ThenInclude(x => x.Exercicio)
                                    .FirstOrDefaultAsync(x => x.Id == id);

        return treino;
    }
}