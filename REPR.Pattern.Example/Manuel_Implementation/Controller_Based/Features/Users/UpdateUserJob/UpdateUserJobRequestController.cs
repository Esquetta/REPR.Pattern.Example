using Microsoft.AspNetCore.Mvc;


namespace REPR.Pattern.Example.Manuel_Implementation.Controller_Based.Features.Users.UpdateUserJob
{
    [Route("api/users/update-job")]
    [ApiController]
    public class UpdateUserJobRequestController : ControllerBase
    {
        [HttpPut]
        public IActionResult UpdateUserJobAsync([FromBody] UpdateUserJobRequest updateUserJobRequest)
        {
            //Process...

            var response = new UpdateUserJobResponse()
            {
                UserId = updateUserJobRequest.UserId,
                Message = "Job information has been successfully updated..."
            };
            return Ok(response);
        }
    }
}
