using BBE_1.RAPI.user;
using Microsoft.AspNetCore.Mvc;

namespace BBE_1.Controllers;

[ApiController]
public class BBE_1Controller : ControllerBase{
    [HttpPost("/user")]
    public IActionResult CreateUser(CreateUserRequest request){
        return Ok();
    }
}