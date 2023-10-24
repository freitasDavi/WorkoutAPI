using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutApi.Entities;

namespace WorkoutApi.Data.Mappings;

public class TreinoExecutadoMap : IEntityTypeConfiguration<TreinoExecutado>
{
    public void Configure(EntityTypeBuilder<TreinoExecutado> builder)
    {
        builder.ToTable("TREINOSEXECUTADOS");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id)
            .HasColumnName("ID_TREINOSEXECUTADOS")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.CodigoTreino);
        builder.Property(x => x.CodigoUsuario);
        builder.Property(x => x.Completo);
        builder.Property(x => x.DataExecucao);

        builder.HasOne(x => x.Usuario)
            .WithMany(x => x.TreinoExecutados)
            .HasForeignKey(x => x.CodigoUsuario);
        
        builder.HasOne(x => x.Treino)
            .WithMany(x => x.TreinosExecutados)
            .HasForeignKey(x => x.CodigoTreino);
    }
}