using Microsoft.AspNetCore.Mvc;

namespace WebStoreApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController: ControllerBase
{
    private static List<string> _users = new()
    {
        "user1",
        "user2"
    };
    
    public UsersController()
    {
        
    }
    
    [HttpGet]
    [Route("all")]
    public ActionResult<List<string>> GetAllUsers()
    {
        return Ok(_users);
    }
}
