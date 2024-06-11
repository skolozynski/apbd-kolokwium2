using Kolokwium2.Data;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Repositories;

public class CharacterRepository : ICharacterRepository
{
    private readonly DataContext _context;

    public CharacterRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<bool> DoesCharacterExist(int id)
    {
        return await _context.Characters.AnyAsync(e => e.Id == id);
    }
}