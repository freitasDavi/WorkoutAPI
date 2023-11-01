using Microsoft.AspNetCore.Mvc;
using WorkoutApi.DTOs;
using WorkoutApi.Entities;
using WorkoutApi.Repositories.Treinos;

namespace WorkoutApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TreinosController : ControllerBase
{
    private readonly ITreinosRepository _treinosRepository;

    public TreinosController(ITreinosRepository treinosRepository)
    {
        _treinosRepository = treinosRepository;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Treino>>> GetAll()
    {
        var treinos = await _treinosRepository.GetAll();
        
        return Ok(treinos);
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<TreinoResponseDTO>> GetById([FromRoute]int id)
    {
        var treino = await _treinosRepository.getTreinoById(id);

        if (treino is null) return NoContent();

        var treinoResponse = TreinoResponseDTO.fromEntity(treino);
        
        return Ok(treinoResponse);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Treino treino)
    {
        await _treinosRepository.Create(treino);

        return Ok();
    }
}