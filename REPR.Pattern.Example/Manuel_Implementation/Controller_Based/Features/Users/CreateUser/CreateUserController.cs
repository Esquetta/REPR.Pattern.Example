using Microsoft.AspNetCore.Mvc;

namespace REPR.Pattern.Example.Manuel_Implementation.Controller_Based.Features.Users.CreateUser
{
    [Route("api/users/create")]
    public class CreateUserController:ControllerBase
    {

        [HttpPost]
        public IActionResult CreateUserAsync([FromBody] CreateUserRequest createUserRequest)
        {
            //Process...

            var response = new CreateUserResponse()
            {
                UserId = 1,
                Message = "The user has been successfully created..."
            };
            return Ok(response);
        }
    }
}
