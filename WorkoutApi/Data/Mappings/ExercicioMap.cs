using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutApi.Entities;

namespace WorkoutApi.Data.Mappings;

public class ExercicioMap : IEntityTypeConfiguration<Exercicio>
{
    public void Configure(EntityTypeBuilder<Exercicio> builder)
    {
        builder.ToTable("EXERCICIOS");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("IDEXERCICIO")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Nome)
            .HasMaxLength(100);
        
        builder.Property(x => x.Img);
        
        builder.Property(x => x.GrupoMuscular)
            .HasMaxLength(60);

        // Assocs
        // builder
        //     .HasMany(x => x.Treinos)
        //     .WithMany(x => x.Exercicios)
        //     .UsingEntity<TreinoExercicioMap>();
        
        //Indexes
    }
}