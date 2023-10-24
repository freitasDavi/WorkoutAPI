using Microsoft.EntityFrameworkCore;
using WorkoutApi.Data;

namespace WorkoutApi.Infra;

public class RepositorioBase<TEntity> : IRepositorioBase<TEntity> where TEntity : Entity
{
    private readonly DataContext _dataContext;
    private readonly DbSet<TEntity> DbSet;
    
    public RepositorioBase(DataContext dataContext)
    {
       _dataContext = dataContext;
       DbSet = dataContext.Set<TEntity>();
    }
    public async Task<List<TEntity>> GetAll()
    {
        return await DbSet.ToListAsync();
    }

    public async Task<Entity?> GetById(int id)
    {
        var item = await DbSet.FirstOrDefaultAsync(x => x.Id == id);

        return item;
    }

    public async Task Create(TEntity entity)
    {
        await DbSet.AddAsync(entity);
        await _dataContext.SaveChangesAsync();
    }

    public async Task DeleteById(int id)
    {
        var item = await DbSet.FirstOrDefaultAsync(x => x.Id == id);

        if (item is null) throw new Exception("Item not found");

        DbSet.Remove(item);
        await _dataContext.SaveChangesAsync();
    }
}