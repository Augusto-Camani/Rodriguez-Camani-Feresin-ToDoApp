using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace TAREALABO;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    [HttpGet("getAllUsers")]
    public IActionResult GetAllUser()
    {
        return Ok(_userService.GetUsers());
    }
    [HttpGet("getUserById/{id}")]
    public IActionResult GetUserById(int id)
    {
        return Ok(_userService.GetUserById(id));
    }
    [HttpPost("addUser")]
    public IActionResult AddUser([FromBody] UserDTO userDTO)
    {
        _userService.AddUser(userDTO);
        return StatusCode(201);
    }
    [HttpDelete("deleteUser/{id}")]
    public IActionResult DeleteUser(int id)
    {
        _userService.DeleteUser(id);
        return NoContent();
    }
}
