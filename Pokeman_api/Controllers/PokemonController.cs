using Microsoft.AspNetCore.Mvc;
namespace pokemon_api;
[ApiController]
[Route("api/[controller]")]
public class pokemonController : ControllerBase
{
    private Pokemon Pikachu = new Pokemon();

    private List<Pokemon> pokemon = new List<Pokemon>
{
    new Pokemon(){Id="002",Name="Bulbasaur",Type="Grass",Ability ="Overgrow",Level=3},
    new Pokemon() {Id="003", Name = "Bulbasaur",Type = "Grass",Ability  = "Overgrow",Level = 3}
};


[HttpGet]

public ActionResult<List<Pokemon>>GetPokemon()
{
    return Ok(pokemon);
}
[HttpGet("{id}")]
public ActionResult<Pokemon> GetPokemonById(string id)
{
    return Ok(pokemon.Find{pokemon=>pokemon.Id==id });
}

}

