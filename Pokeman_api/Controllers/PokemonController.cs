using Microsoft.AspNetCore.Mvc;
namespace pokemon_api;
[ApiController]
[Route("api/[controller]")]
public class pokemonController : ControllerBase{
    private Pokemon pikachu = new Pokemon();

    [HttpGet]

    public Pokemon pikachu { 
        return 
    }

}