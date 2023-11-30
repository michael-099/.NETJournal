using Microsoft.AspNetCore.Mvc;
namespace pokemon_api;
[ApiController]
[Route("api/[controller]")]
public class pokemonController : ControllerBase{
    private Pokemon Pikachu = new Pokemon();

    [HttpGet]

    public ActionResult<Pokemon>GetPokemon(){
        return BadRequest(Pikachu);
    }
    }

