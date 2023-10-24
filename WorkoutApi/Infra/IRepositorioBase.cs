namespace WorkoutApi.Infra;

public interface IRepositorioBase<TEntity>
{
    public Task<List<TEntity>> GetAll();
    public Task<Entity?> GetById(int id);
    public Task Create(TEntity entity);
    public Task DeleteById(int id);

}