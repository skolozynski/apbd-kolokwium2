using Kolokwium2.Data;
using Kolokwium2.Models;
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

    public async Task<Character?> GetCharacter(int id)
    {
        return await _context.Characters.FirstOrDefaultAsync(e => e.Id == id);
    }
}