using Microsoft.AspNetCore.Mvc;
namespace pokemon_api;
[ApiController]
[Route("api/[controller]")]
public class pokemonController : ControllerBase
{
    private Pokemon Pikachu = new Pokemon();

    private List<Pokemon> pokemon = new List<Pokemon>
{
    new Pokemon() {Id="003", Name = "Bulbasaur",Type = "Grass",Ability  = "Overgrow",Level = 3},
    new Pokemon() {Id="002", Name = "Bulbasaur",Type = "Grass",Ability  = "Overgrow",Level = 2}


};


    // [HttpGet]

    // public ActionResult<List<Pokemon>> GetPokemon()
    // {
    //     return Ok(pokemon);
    // }
    [HttpGet("{level}")]
    public ActionResult<Pokemon> GetPokemonById(int level)
    {
        var foundPokemon = pokemon.Find(pokemon => pokemon.Level == level);
        if (foundPokemon == null)
        {
            return NotFound();

        }
        return Ok(foundPokemon);
    }

    [HttpPost]
    public ActionResult<List<Pokemon>> AddPokemon(Pokemon newPokemon)
    {
        newPokemon=new Pokemon
        {
            Id = "004",
            Name = "Bulbasaur",
            Type = "Grass",
            Ability = "Overgrow",
            // Level = 2

        };
        pokemon.Add(newPokemon);
        return Ok(pokemon);

    }


}

