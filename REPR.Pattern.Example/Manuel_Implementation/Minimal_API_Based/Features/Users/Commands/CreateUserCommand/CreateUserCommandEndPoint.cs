using Mediator;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.Features.Users.Commands.CreateUserCommand
{
    public static class CreateUserCommandEndPoint
    {
        public static RouteGroupBuilder CreateUserEndPoint(this RouteGroupBuilder routeGroupBuilder)
        {
            routeGroupBuilder.MapPost("/create", async (CreateUserCommandRequest createUserCommandRequest, IMediator mediator) =>
            {
                var result = await mediator.Send(createUserCommandRequest);
                return new ObjectResult(result)
                {
                    StatusCode = (int)HttpStatusCode.Created
                };
            });

            return routeGroupBuilder;
        }

    }
}
