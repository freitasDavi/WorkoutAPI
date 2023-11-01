using WorkoutApi.Entities;

namespace WorkoutApi.DTOs;

public class TreinoResponseDTO
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public EnumDiaTreino Dia { get; set; }
    public int TotalTreinos { get; set; } 
    public int TotalTreinosExecutados { get; set; }
    public int CodigoUsuario { get; set; }
    public List<TreinoExecutadoDTO> TreinosExecutados { get; set; } = new();
    public List<TreinoExercicioDTO> TreinoExercicios { get; set; } = new();

    public static TreinoResponseDTO fromEntity(Treino treino)
    {
        var dto = new TreinoResponseDTO();

        dto.Id = treino.Id;
        dto.Nome = treino.Nome;
        dto.Dia = treino.Dia;
        dto.TotalTreinos = treino.TotalTreinos;
        dto.TotalTreinosExecutados = treino.TotalTreinosExecutados;
        dto.CodigoUsuario = treino.CodigoUsuario;
        dto.TreinosExecutados = TreinoExecutadoDTO.fromEntity(treino.TreinosExecutados);
        dto.TreinoExercicios = TreinoExercicioDTO.fromEntity(treino.TreinoExercicios);
        
        return dto;
    }
}

public class TreinoExecutadoDTO
{
    public int Id { get; set; }
    public int CodigoTreino { get; set; }
    public int CodigoUsuario { get; set; }
    public bool Completo { get; set; }
    public DateTime DataExecucao { get; set; }

    public static TreinoExecutadoDTO fromEntity(TreinoExecutado treino)
    {
        var dto = new TreinoExecutadoDTO
        {
            Id = treino.Id,
            CodigoTreino = treino.CodigoTreino,
            CodigoUsuario = treino.CodigoUsuario,
            Completo = treino.Completo,
            DataExecucao = treino.DataExecucao
        };

        return dto;
    }

    public static List<TreinoExecutadoDTO> fromEntity(List<TreinoExecutado> treinos)
    {
        return treinos.Select(TreinoExecutadoDTO.fromEntity).ToList();
    }
}

public class TreinoExercicioDTO
{
    public int Id { get; set; }
    public int CodigoTreino { get; set; }
    public int CodigoExercicio { get; set; }
    public ExercicioDTO Exercicio { get; set; }

    public static TreinoExercicioDTO fromEntity(TreinoExercicio treinoExercicio)
    {
        var dto = new TreinoExercicioDTO
        {
            Id = treinoExercicio.Id,
            CodigoTreino = treinoExercicio.CodigoTreino,
            CodigoExercicio = treinoExercicio.CodigoExercicio,
            Exercicio = treinoExercicio.Exercicio != null ? ExercicioDTO.fromEntity(treinoExercicio.Exercicio) : new ExercicioDTO()
        };

        return dto;
    }

    public static List<TreinoExercicioDTO> fromEntity(List<TreinoExercicio> treinoExercicios)
    {
        return treinoExercicios.Select(TreinoExercicioDTO.fromEntity).ToList();
    }
}

public class ExercicioDTO
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Img { get; set; } = string.Empty;
    public string GrupoMuscular { get; set; } = string.Empty;

    public static ExercicioDTO fromEntity(Exercicio exercicio)
    {
        var dto = new ExercicioDTO
        {
            Id = exercicio.Id,
            Nome = exercicio.Nome,
            Img = exercicio.Img,
            GrupoMuscular = exercicio.GrupoMuscular
        };

        return dto;
    }
}