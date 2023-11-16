using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserTestProject.Web.Models.Users;

namespace UserTestProject.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        //Users API

        [HttpGet("/users")]
        [ProducesResponseType(typeof(List<UserResponse>),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUsersAsync()
        {
            return Ok();
        }


        [HttpGet("/users/{userId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUserAsync(int userId)
        {
            return Ok();
        }


        [HttpPost("/users")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateUserAsync(CreateUserRequest createUserRequest)
        {
            return Ok();
        }



        [HttpDelete("/users/{usersId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteUserAsync(int userId)
        {
            return Ok();
        }

        //User profile API

        [HttpGet("/users/profiles")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUserProfilesAsync()
        {
            return Ok();
        }


        [HttpGet("/users/{userId}/profiles")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUserProfileAsync()
        {
            return Ok();
        }


        [HttpPost("/users/{userId}/profiles")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateUserProfileAsync(CreateUserProfileRequest createUserProfileRequest)
        {
            return Ok();
        }



        [HttpDelete("/users/{usersId}/profiles")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteUserProfileAsync()
        {
            return Ok();
        }


    }

}

