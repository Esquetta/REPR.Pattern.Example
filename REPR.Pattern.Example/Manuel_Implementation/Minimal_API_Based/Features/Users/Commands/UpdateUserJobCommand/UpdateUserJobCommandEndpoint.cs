using Mediator;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.Features.Users.Commands.UpdateUserJobCommand
{
    public static class UpdateUserJobCommandEndpoint
    {
        public static RouteGroupBuilder UpdateUserJobEndPoint(this RouteGroupBuilder routeGroupBuilder)
        {
            routeGroupBuilder.MapPut(pattern: "/update-job", async (UpdateUserJobCommandRequest updateUserJobCommandRequest, IMediator mediator) =>
            {
                var result = await mediator.Send(updateUserJobCommandRequest);
                return new ObjectResult(result)
                {
                    StatusCode = (int)HttpStatusCode.Created
                };
            });

            return routeGroupBuilder;
        }
    }
}
