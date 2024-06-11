using Kolokwium2.Dtos;

namespace Kolokwium2.Repositories;

public interface IItemRepository
{
    public Task<bool> DoesItemsExist(List<ItemDto> itemsDtos);

    public Task<bool> HasEnoughFreeSpace(int characterId, List<ItemDto> itemsDtos);

    public Task AddItemsToCharacter(int id, List<ItemDto> items);

    public Task<List<BackpackItemDto>> GetBackapckItemsList(int characterId);
}