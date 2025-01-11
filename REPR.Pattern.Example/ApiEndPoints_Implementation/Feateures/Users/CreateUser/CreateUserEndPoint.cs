using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace REPR.Pattern.Example.ApiEndPoints_Implementation.Feateures.Users.CreateUser
{
    public class CreateUserEndPoint:EndpointBaseAsync.WithRequest<CreateUserRequest>.WithActionResult<CreateUserResponse>
    {
        public override async Task<ActionResult<CreateUserResponse>> HandleAsync(CreateUserRequest request, CancellationToken cancellationToken = default)
        {
            var response = new CreateUserResponse(0, $"The user has been successfully created... | {request.Name}, {request.Surname}, {request.Age}");

            return response;
        }
    }
}
