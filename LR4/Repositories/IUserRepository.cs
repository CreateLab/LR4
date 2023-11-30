using LR4.Models;

namespace LR4.Repositories;

public interface IUserRepository
{
    Task Add(User user);
    
    public Task<List<string>> GetAllNames();
}