using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutApi.Entities;

namespace WorkoutApi.Data.Mappings;

public class TreinoExercicioMap : IEntityTypeConfiguration<Entities.TreinoExercicio>
{
    public void Configure(EntityTypeBuilder<Entities.TreinoExercicio> builder)
    {
        builder.ToTable("TREINO_EXERCICIOS");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("IDTREINOEXERCICIO")
            .ValueGeneratedOnAdd();

        builder.HasOne(x => x.Treino)
            .WithMany(x => x.TreinoExercicios)
            .HasForeignKey(x => x.CodigoTreino);

        builder.HasOne(x => x.Exercicio)
            .WithMany(x => x.TreinoExercicios)
            .HasForeignKey(x => x.CodigoExercicio);
    }
}