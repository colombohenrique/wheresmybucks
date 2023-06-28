using Application.Services.Interfaces;
using Infrastructure.Identity.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using wheresmybucks.Controllers.Base;

namespace wheresmybucks.Controllers
{
    public class UserController : BaseController
    {
        [HttpPost("v1/users")]
        [AllowAnonymous]
        [SwaggerOperation(Summary = "Post user endpoint.", Description = "Post user endpoint")]
        public async Task<IActionResult> RegisterDirector([FromServices] IUserService _userService, [FromBody] UserDto userDto)
        {
            var result = await _userService.RegisterUser(userDto);
            return ApiResponse(result);
        }

        [HttpGet("v1/users/{email}")]
        [SwaggerOperation(Summary = "Get User by email", Description = "Get User by email")]
        public async Task<ActionResult> GetUser([FromServices] IUserService _userService, [FromRoute] string email)
        {
            var result = await _userService.GetUserByEmail(email);
            return ApiResponse(result);
        }
      
        [HttpPut("v1/users/")]
        [SwaggerOperation(Summary = "Update User Endpoint", Description = "Update User")]
        public async Task<ActionResult> UpdateUser([FromServices] IUserService _userService, [FromBody] UserDto request)
        {
            var result = await _userService.UpdateUser(request);
            return ApiResponse(result);
        }
    }
}
