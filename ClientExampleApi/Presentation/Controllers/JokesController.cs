using Application.Interfaces;
using Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JokesController : ControllerBase
    {
        // Inyecta el servicio...

        [HttpGet("random")]
        public async Task<ActionResult<JokeDTO>> GetRandomJokeAsync()
        {
            // Completa el endpoint...
        }

        // Crea algunos endpoints más para llamar a más métodos del servicio y consumir algún otro endpoint de la API de chistes...
    }
}
