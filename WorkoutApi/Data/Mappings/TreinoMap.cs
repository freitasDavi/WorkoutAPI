using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutApi.Entities;

namespace WorkoutApi.Data.Mappings;

public class TreinoMap : IEntityTypeConfiguration<Treino>
{
    public void Configure(EntityTypeBuilder<Treino> builder)
    {
        builder.ToTable("TREINOS");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasColumnName("IDTREINO")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Nome)
            .HasMaxLength(60);
        
        builder.Property(x => x.Dia);
        builder.Property(x => x.TotalTreinos);
        builder.Property(x => x.TotalTreinosExecutados);
        builder.Property(x => x.CodigoUsuario);

        // Assocs
        builder.HasOne(x => x.Usuario)
            .WithMany(x => x.Treinos)
            .HasForeignKey(x => x.CodigoUsuario);
        
        builder.HasMany(x => x.TreinosExecutados)
            .WithOne(x => x.Treino)
            .HasForeignKey(x => x.CodigoTreino);
        
        // builder
        //     .HasMany(x => x.Exercicios)
        //     .WithMany(x => x.Treinos)
        //     .UsingEntity<TreinoExercicioMap>();

        // Indexes
    }
}