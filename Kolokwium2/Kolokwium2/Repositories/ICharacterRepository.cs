using Kolokwium2.Models;

namespace Kolokwium2.Repositories;

public interface ICharacterRepository
{
    public Task<bool> DoesCharacterExist(int id);

    public Task<Character?> GetCharacter(int id);
}