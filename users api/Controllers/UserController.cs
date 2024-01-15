using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace users_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{

    private List<Users> user = new List<Users>{
    new Users{Id="001",Name="Miki",Email="m@gmail.com",},
    new Users{Id="002",Name="yeab",Email="yy@gmail.com",}

};
    [HttpGet]
    public IActionResult GetAllUsers()
    {
        return Ok(user);
    }
    // [HttpGet("{id}")]



}
