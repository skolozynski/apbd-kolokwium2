namespace Kolokwium2.Repositories;

public interface ICharacterRepository
{
    public Task<bool> DoesCharacterExist(int id);
}