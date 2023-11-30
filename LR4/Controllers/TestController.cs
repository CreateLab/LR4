using LR4.Services;
using Microsoft.AspNetCore.Mvc;

namespace LR4.Controllers;

[ApiController]
public sealed class TestController:ControllerBase
{
    
    private readonly ISum _sum;

    public TestController(ISum sum)
    {
        _sum = sum;
    }

    [HttpGet("/hello-world")]
    
    public Task<string> HelloWorld()
    {
        return Task.FromResult("Hello world");
    }
    
    [HttpGet("/sum")]
    public Task<int> Add(int a, int b)
    {
        return Task.FromResult(_sum.Add(a, b));
    }
}