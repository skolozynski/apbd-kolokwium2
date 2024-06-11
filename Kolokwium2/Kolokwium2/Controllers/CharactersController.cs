using Kolokwium2.Dtos;
using Kolokwium2.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kolokwium2.Controllers;


[ApiController]
[Route("api/[controller]")]
public class CharactersController : ControllerBase
{
    private readonly IItemRepository _itemRepository;
    private readonly ICharacterRepository _characterRepository;
    private readonly ITitlesRepository _titlesRepository;

    public CharactersController(
        IItemRepository itemRepository,
        ICharacterRepository characterRepository,
        ITitlesRepository titlesRepository)
    {
        _itemRepository = itemRepository;
        _characterRepository = characterRepository;
        _titlesRepository = titlesRepository;
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetCharacter(int id)
    {
        var character = await _characterRepository.GetCharacter(id);
        if (character == null) return NotFound($"Character with id {id} does not exist");
        var characterTitles = await _titlesRepository.GetTitlesForCharacter(id);
        var backpackItemsList = await _itemRepository.GetBackapckItemsList(id);

        var repsonse = new CharacterResponse()
        {
            FirstName = character.FirstName,
            LastName = character.LastName,
            CurrentWeight = character.CurrentWeight,
            MaxWeight = character.MaxWeight,
            BackpackItems = backpackItemsList,
            Titles = characterTitles
        };
        return Ok(repsonse);
    }
    

    [HttpPost("{id:int}/backpacks")]
    public async Task<IActionResult> AddItemsToBackapck(int id, List<ItemDto> items)
    {
        if (!await _characterRepository.DoesCharacterExist(id))
            return NotFound($"Character with {id} does not exist");
        if (!await _itemRepository.DoesItemsExist(items))
            return NotFound("Some items do not exist");
        if (!await _itemRepository.HasEnoughFreeSpace(id, items))
            return BadRequest($"Character with id {id} does not have enough free weight");

        await _itemRepository.AddItemsToCharacter(id, items);
        
        return Ok($"Items were added to character with id {id}");
    }
    
}