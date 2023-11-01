
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WorkoutApi.Entities;
using WorkoutApi.Repositories;

namespace WorkoutApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExerciciosController : ControllerBase
{
    private readonly IExerciciosRepository _exerciciosRepository;

    public ExerciciosController(IExerciciosRepository exerciciosRepository)
    {
        _exerciciosRepository = exerciciosRepository;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Exercicio>>> GetAll()
    {
        var exercicios = await _exerciciosRepository.GetAll();
        
        return Ok(exercicios);
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<List<Exercicio>>> GetById([FromRoute]int id)
    {
        var exercicio = await _exerciciosRepository.GetById(id);

        return Ok(exercicio);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Exercicio exercicio)
    {
        await _exerciciosRepository.Create(exercicio);

        return Ok();
    }

    [HttpPut("adicionarExercicios")]
    public async Task<IActionResult> AdicionarExerciciosNoTreino([FromBody] List<TreinoExercicio> exercicios)
    {
        await _exerciciosRepository.InserirExerciciosNoTreino(exercicios);
        
        return Ok();
    }
}