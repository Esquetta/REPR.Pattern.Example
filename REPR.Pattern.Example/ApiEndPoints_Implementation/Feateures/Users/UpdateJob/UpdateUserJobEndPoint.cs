using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace REPR.Pattern.Example.ApiEndPoints_Implementation.Feateures.Users.UpdateJob
{
    public class UpdateUserJobEndPoint:EndpointBaseAsync.WithRequest<UpdateUserJobRequest>.WithActionResult<UpdateUserJobResponse>
    {
        [HttpPut("api4/users/update-job")]
        public override async Task<ActionResult<UpdateUserJobResponse>> HandleAsync(UpdateUserJobRequest request, CancellationToken cancellationToken = default)
        {
            var response = new UpdateUserJobResponse(request.UserId, "Job information has been successfully updated...");

            return response;
        }
    }
}
