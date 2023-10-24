using Microsoft.AspNetCore.Mvc;
using WorkoutApi.Entities;
using WorkoutApi.Repositories.Usuarios;

namespace WorkoutApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly IUsuariosRepository _usuariosRepository;

    public UsuariosController(IUsuariosRepository usuariosRepository)
    {
        _usuariosRepository = usuariosRepository;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Usuario>>> GetAll()
    {
        var usuarios = await _usuariosRepository.GetAll();
        
        return Ok(usuarios);
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<List<Usuario>>> GetById([FromRoute]int id)
    {
        var usuario = await _usuariosRepository.GetById(id);

        return Ok(usuario);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Usuario usuario)
    {
        await _usuariosRepository.Create(usuario);

        return Ok();
    }
}