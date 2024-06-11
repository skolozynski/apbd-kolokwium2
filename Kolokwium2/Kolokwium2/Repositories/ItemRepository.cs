using Kolokwium2.Data;
using Kolokwium2.Dtos;
using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Repositories;

public class ItemRepository : IItemRepository
{
    private readonly DataContext _context;

    public ItemRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<bool> DoesItemsExist( List<ItemDto> itemDtos)
    {
        foreach (ItemDto itemDto in itemDtos)
        {
            var res = await _context.Items.AnyAsync(e => e.Id == itemDto.ItemId);
            if (res == false)
                return false;
        }
        return true;
    }

    public async Task<bool> HasEnoughFreeSpace(int characterId, List<ItemDto> itemsDtos)
    {
        var character = await _context.Characters.FirstAsync(e => e.Id == characterId);
        var characterFreeSpace = character.MaxWeight - character.CurrentWeight;
        var itemsMas = 0;
        foreach (var itemDto in itemsDtos)
        {
            var item = await _context.Items.FirstAsync(e => e.Id == itemDto.ItemId);
            itemsMas += item.Weight;
        }

        return characterFreeSpace > itemsMas;
    }

    public async Task AddItemsToCharacter(int id, List<ItemDto> items)
    {
        foreach (var itemDto in items)
        {
            var item = await _context.Items.FirstAsync(e => e.Id == itemDto.ItemId);
            await _context.Backpacks.AddAsync(new Backpack()
            {
                CharacterId = id,
                ItemId = item.Id,
                Amount = 1
            });
        }
        await _context.SaveChangesAsync();
    }
}