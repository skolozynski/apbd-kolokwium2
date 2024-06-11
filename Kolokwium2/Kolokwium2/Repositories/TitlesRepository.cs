using Kolokwium2.Data;
using Kolokwium2.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Repositories;

public class TitlesRepository : ITitlesRepository
{
    private readonly DataContext _context;

    public TitlesRepository(DataContext context)
    {
        _context = context;
    }


    public async Task<List<TitleDto>> GetTitlesForCharacter(int id)
    {
        var titlesList = await _context.CharacterTitles
            .Where(e => e.CharacterId == id)
            .Include(e => e.Title)
            .Select(e => new TitleDto()
            {
                Title = e.Title.Name,
                aquiredAt = e.AcquiredAt
            }).ToListAsync();
        return titlesList;
    }
}