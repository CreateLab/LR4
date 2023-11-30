using LR4.DB;
using LR4.Models;
using Microsoft.EntityFrameworkCore;

namespace LR4.Repositories;

public sealed class UserRepository:IUserRepository
{
    private readonly LR4Context _context;

    public UserRepository(LR4Context context)
    {
        _context = context;
    }

    public Task Add(User user)
    {
        _context.Users.Add(user);
        return _context.SaveChangesAsync();
    }

    public Task<List<string>> GetAllNames()
    {
        return _context.Users.Select(x => x.Name).ToListAsync();
    }
}