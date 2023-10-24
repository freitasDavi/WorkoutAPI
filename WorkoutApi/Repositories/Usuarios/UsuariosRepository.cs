using WorkoutApi.Data;
using WorkoutApi.Entities;
using WorkoutApi.Infra;

namespace WorkoutApi.Repositories.Usuarios;

public class UsuariosRepository : RepositorioBase<Usuario>, IUsuariosRepository
{
    public UsuariosRepository(DataContext dataContext) : base(dataContext)
    {
    }
}