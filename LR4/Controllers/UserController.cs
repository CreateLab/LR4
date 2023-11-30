using LR4.Models;
using LR4.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LR4.Controllers;

[ApiController]
public sealed class UserController:ControllerBase
{
   private readonly IUserRepository _userRepository;

   public UserController(IUserRepository userRepository)
   {
      _userRepository = userRepository;
   }
   
   [HttpPost("/add-user")]
   public Task Add([FromBody] string name)
   {
      var u = new User
      {
         Name = name
      };
      return _userRepository.Add(u);
   }
   
   [HttpGet("/get-all-names")]
   public Task<List<string>> GetAllNames()
   {
      return _userRepository.GetAllNames();
   }
}