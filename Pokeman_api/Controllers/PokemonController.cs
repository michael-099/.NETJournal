using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace pokemon_api;
[ApiController]
[Route("api/[controller]")]
public class pokemonController : ControllerBase
{
    private Pokemon Pikachu = new Pokemon();

    private List<Pokemon> pokemon = new List<Pokemon>
{
    new Pokemon { Id = "1", Name = "Bulbasaur", Type = "Grass/Poison", Level = 5 },
    new Pokemon { Id = "2", Name = "Charmander", Type = "Fire", Level = 5 },
    new Pokemon { Id = "3", Name = "Squirtle", Type = "Water", Level = 5 },
    new Pokemon { Id = "5", Name = "Jigglypuff", Type = "Normal/Fairy", Level = 5 },
    new Pokemon { Id = "6", Name = "Geodude", Type = "Rock/Ground", Level = 5 },
    new Pokemon { Id = "7", Name = "Abra", Type = "Psychic", Level = 5 },
    new Pokemon { Id = "8", Name = "Machop", Type = "Fighting", Level = 5 },
    new Pokemon { Id = "9", Name = "Gastly", Type = "Ghost/Poison", Level = 5 },
    new Pokemon { Id = "10", Name = "Onix", Type = "Rock/Ground", Level = 5 },



};


    [HttpGet]

    public ActionResult<List<Pokemon>> GetPokemon()
    {
        return Ok(pokemon);
    }
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
        newPokemon = new Pokemon
        {
            Id = "004",
            Name = "Bulbasaur",
            Type = "Grass",
            Ability = "Overgrow",
            Level = 2

        };
        pokemon.Add(newPokemon);
        return Ok(pokemon);
    }
    [HttpDelete("{id}")]

    public ActionResult<List<Pokemon>> DeletePokemon(string id)
    {
        var deletePokemon = pokemon.Find(p => p.Id == id);
        if (deletePokemon == null)
        {
            return NotFound();
        }
        pokemon.Remove(deletePokemon);
        return Ok(pokemon);

    }
    [HttpPatch("{name}")]
    public IActionResult<Pokemon> PatchPokemon(string name, [FromBody] JsonPatchDocument<Pokemon> patchDocument)
    {
        var existingPokemon = pokemon.Find(p => p.Name == name);
        if (existingPokemon == null)
        {
            return NotFound();
        }
        patchDocument.ApplyTo(existingPokemon, ModelState);
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(existingPokemon);
    }


    [HttpPut]
    public ActionResult<Pokemon> ModifyPokemon(Pokemon updatedPokemon)
    {
        var existingPokemon = pokemon.FirstOrDefault(p => p.Id == updatedPokemon.Id);

        if (existingPokemon == null)
        {
            return NotFound();
        }
        existingPokemon.Name = updatedPokemon.Name;
        existingPokemon.Type = updatedPokemon.Type;
        existingPokemon.Level = updatedPokemon.Level;

        return Ok(existingPokemon);
    }


}





