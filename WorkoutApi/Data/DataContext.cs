using Microsoft.EntityFrameworkCore;
using WorkoutApi.Data.Mappings;

namespace WorkoutApi.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UsuarioMap());
        modelBuilder.ApplyConfiguration(new ExercicioMap());
        modelBuilder.ApplyConfiguration(new TreinoMap());
        modelBuilder.ApplyConfiguration(new TreinoExecutadoMap());
    }
}