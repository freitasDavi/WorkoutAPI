using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutApi.Entities;

namespace WorkoutApi.Data.Mappings;

public class UsuarioMap : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("USUARIOS");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasColumnName("IDUSUARIOS")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Email);
        builder.Property(x => x.Nome);
        builder.Property(x => x.Sexo);
        builder.Property(x => x.DataNascimento);
        builder.Property(x => x.Objetivo);
        builder.Property(x => x.Senha);

        // Assocs
        builder.HasMany(x => x.Treinos)
            .WithOne(x => x.Usuario)
            .HasForeignKey(x => x.CodigoUsuario);

        builder.HasMany(x => x.TreinoExecutados)
            .WithOne(x => x.Usuario)
            .HasForeignKey(x => x.CodigoUsuario);
        
        //Indexes
        builder
            .HasIndex(x => x.Email, "IX_User_Email")
            .IsUnique();
    }
}