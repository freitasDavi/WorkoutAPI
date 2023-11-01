using Microsoft.EntityFrameworkCore;
using WorkoutApi.Data.Mappings;
using WorkoutApi.Entities;

namespace WorkoutApi.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Exercicio> Exercicios { get; set; }
    public DbSet<Treino> Treinos { get; set; }
    public DbSet<TreinoExercicio> TreinosExercicios { get; set; }
    public DbSet<TreinoExecutado> TreinosExecutados { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UsuarioMap());
        modelBuilder.ApplyConfiguration(new ExercicioMap());
        modelBuilder.ApplyConfiguration(new TreinoMap());
        modelBuilder.ApplyConfiguration(new TreinoExecutadoMap());
        modelBuilder.ApplyConfiguration(new TreinoExercicioMap());
    }
}