using Microsoft.AspNetCore.Mvc;
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
    public async Task<ActionResult<List<Treino>>> GetById([FromRoute]int id)
    {
        var treino = await _treinosRepository.GetById(id);

        return Ok(treino);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Treino treino)
    {
        await _treinosRepository.Create(treino);

        return Ok();
    }
}