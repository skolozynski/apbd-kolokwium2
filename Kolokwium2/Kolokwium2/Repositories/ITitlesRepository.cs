using Kolokwium2.Dtos;

namespace Kolokwium2.Repositories;

public interface ITitlesRepository
{
    public Task<List<TitleDto>> GetTitlesForCharacter(int id);
}