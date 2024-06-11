using Kolokwium2.Dtos;
using Kolokwium2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers;


[ApiController]
[Route("api/[controller]")]
public class CharactersController : ControllerBase
{
    private readonly IItemRepository _itemRepository;
    private readonly ICharacterRepository _characterRepository;

    public CharactersController(IItemRepository itemRepository, ICharacterRepository characterRepository)
    {
        _itemRepository = itemRepository;
        _characterRepository = characterRepository;
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetCharacter(int id)
    {
        return Ok();
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